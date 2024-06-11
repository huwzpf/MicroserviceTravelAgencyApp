import subprocess
import os
from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
import json
import time
import random

streets_data = {
    'albania': ['Rruga 28 Nentori', 'Rruga Abdyl Frasheri', 'Rruga e Kavajes', 'Rruga e Dibres', 'Bulevardi Bajram Curri'],
    'grecja': ['Leoforos Vasilissis Sofias', 'Leoforos Alexandras', 'Plateia Syntagmatos', 'Odou Kifisias', 'Leoforos Mesogeion'],
    'turcja': ['Atatürk Caddesi', 'İstiklal Caddesi', 'Bağdat Caddesi', 'Halaskargazi Caddesi', 'Cumhuriyet Caddesi'],
    'hiszpania': ['Calle de Alcalá', 'Paseo de la Castellana', 'Gran Vía', 'Calle Mayor', 'Paseo del Prado'],
    'wlochy': ['Via del Corso', 'Via Appia', 'Via Nazionale', 'Via Veneto', 'Via dei Fori Imperiali'],
    'niemcy': ['Unter den Linden', 'Kurfürstendamm', 'Friedrichstraße', 'Karl-Marx-Allee', 'Schlossallee'],
    'chorwacja': ['Ilica', 'Trg bana Josipa Jelačića', 'Vukovarska ulica', 'Kapucinska ulica', 'Maksimirska ulica'],
    'egipt': ['Sharia Gamal Abdel Nasser', 'Corniche el-Nil', 'Sharia Tahrir', 'Sharia Ramsis', 'Sharia Salah Salem'],
    'cypr': ['Ledra Street', 'Archbishop Makarios III Avenue', 'Kennedy Avenue', 'Avenue de L\'Europe', 'Spyrou Kyprianou Avenue']
}

def generate_hotel_dbcontext(n):
    def generate_food_price():
        return random.randint(30, 120)

    with open('dbcontexts_template/hotel_db_context.txt', 'r') as template:
        template_content = template.read()

    with open('Hotels.json', 'r', encoding='utf-8') as f:
            hotels_data = json.load(f)

    with open('dbcontexts_generated/HotelDbContext.cs', 'w', encoding='utf-8') as dbcontext:
        dbcontext.write(template_content)

        gen_guids = f"""

            Guid[] hotelIds = new Guid[{n}];
                    for (int i = 0; i < hotelIds.Length; i++)
                    {{
                        hotelIds[i] = Guid.NewGuid();
                    }}

        """

        dbcontext.write(gen_guids)

        gen_hotels = """
            var hotels = new[]
            {
        """

        i=0
        # Iterate over each country in the JSON data
        for country, hotels_list in hotels_data.items():
            # Iterate over each hotel in the current country
            for hotel_data in hotels_list:
                # Extract hotel information
                hotel_name, city, street = hotel_data.split('#')
                # Generate a new hotel string using the extracted information
                new_hotel = f"""
                new Hotel
                    {{
                        Id = hotelIds[{i}], Name = "{hotel_name.strip()}", FoodPricePerPerson = {generate_food_price()}, City = "{city.strip()}", Country = "{country}", Street = "{street.strip()}"
                    }},
                """
                # Append the new hotel string to gen_hotels
                gen_hotels += new_hotel
                i += 1

        gen_hotels = gen_hotels + \
        """

            modelBuilder.Entity<Hotel>().HasData(hotels);
        """


        gen_hotels = gen_hotels + \
            """

            };

            modelBuilder.Entity<Hotel>().HasData(hotels);
        """

        dbcontext.write(gen_hotels)

        gen_rooms = """
            var rooms = new[]
            {
        """

        for i in range(n):
            for j in range(4):
                new_room = f"""
                new Room {{ Id = Guid.NewGuid(), HotelId = hotel1Id[{i}], Size = {2 + j}, Price = {random.randint(50, 250)}, Count = {random.randint(1,3)} }},
                """
                gen_rooms = gen_rooms + new_room

        gen_rooms = gen_rooms + \
            """
            };

            modelBuilder.Entity<Room>().HasData(rooms);
        """

        dbcontext.write(gen_rooms)
        dbcontext.write(
            """
        }
    }
}
        """
        )

def create_hotel_migration(name):
    command = ['dotnet', 'ef', 'migrations', 'add', name]

    script_directory = os.path.dirname(os.path.abspath(__file__))
    root_directory = os.path.dirname(script_directory)
    destination_directory = 'hotelservice'

    working_directory = os.path.join(root_directory, destination_directory)
    os.chdir(working_directory)
    print(os.getcwd())

    # Run the command
    subprocess.run(command)

def scrap_hotels():
    options = webdriver.ChromeOptions()
    # options.add_argument("--headless")
    options.add_argument("--window-size=1920,1080")
    driver = webdriver.Chrome(options=options)

    COUNTRIES = ['albania','grecja','turcja','hiszpania','wlochy','chorwacja','turcja','egipt']

    country_hotels = {}

    for country in COUNTRIES:
        # Load the webpage
        driver.get(f"https://r.pl/{country}")
        hotels_info = []

        WebDriverWait(driver, 20).until(
                EC.presence_of_element_located((By.XPATH, '//*[@id="bloczkiHTMLID"]/a/div/div[2]/div[1]/span'))
            )
        
        WebDriverWait(driver, 20).until(
                EC.presence_of_element_located((By.XPATH, '//*[@id="bloczkiHTMLID"]/a/div/div[2]/span'))
            )

        for i in range(1,9):
            HOTEL_NAME_XPATH = f'//*[@id="bloczkiHTMLID"]/a[{i}]/div/div[2]/div[1]/span'
            TOUR_INFO_XPATH = f'//*[@id="bloczkiHTMLID"]/a[{i}]/div/div[2]/span'
            # Find hotels
            try:
                hotel = driver.find_element(By.XPATH, HOTEL_NAME_XPATH)
                tour_info = driver.find_element(By.XPATH, TOUR_INFO_XPATH)

                while hotel.text == "" or tour_info.text == "":
                    time.sleep(1)
                    driver.execute_script("window.scrollBy(0, window.innerHeight * 0.25)")
                    # Find hotels again after scrolling
                    hotel = driver.find_element(By.XPATH, HOTEL_NAME_XPATH)
                    tour_info = driver.find_element(By.XPATH, TOUR_INFO_XPATH)
                    print("Waiting...")

                print(hotel.text)
                print(tour_info.text)
                
                if "Wypoczynek" in tour_info.text:
                    city = tour_info.text.split()[-1]
                    hotels_info.append(hotel.text + "#" + city + "#" + random.choice(streets_data[country]))

            except Exception as e:
                print(f"Error occurred: {str(e)}")
        
        country_hotels[country] = hotels_info

    # Save the dictionary to a JSON file
    with open('Hotels.json', 'w') as json_file:
        json.dump(country_hotels, json_file)

    driver.quit()
