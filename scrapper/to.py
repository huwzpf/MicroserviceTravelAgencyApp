import random

parsed_data = [
    {"country": "albania", "hotel_name": "Pinea Resort & Spa", "city": "Durres", "street_name": "Rruga e Dibres"},
    {"country": "albania", "hotel_name": "Diamma Resort", "city": "Durres", "street_name": "Rruga Abdyl Frasheri"},
    {"country": "albania", "hotel_name": "Bonita Luxury Hotel", "city": "Durres", "street_name": "Rruga Abdyl Frasheri"},
    {"country": "albania", "hotel_name": "Monte Carlo Vlora", "city": "Vlora", "street_name": "Rruga 28 Nentori"},
    {"country": "albania", "hotel_name": "MonteCarlo Lungomare", "city": "Vlora", "street_name": "Rruga e Kavajes"},
    {"country": "albania", "hotel_name": "Mel Holidays", "city": "Durres", "street_name": "Bulevardi Bajram Curri"},
    {"country": "albania", "hotel_name": "Casa Durres", "city": "Durres", "street_name": "Rruga e Dibres"},
    {"country": "grecja", "hotel_name": "Rethymno Mare Water Park", "city": "Chania", "street_name": "Leoforos Vasilissis Sofias"},
    {"country": "grecja", "hotel_name": "Aldemar Olympian Village", "city": "Peloponez", "street_name": "Leoforos Alexandras"},
    {"country": "grecja", "hotel_name": "Studia Katerina", "city": "Nero", "street_name": "Leoforos Vasilissis Sofias"},
    {"country": "grecja", "hotel_name": "Irini Studios", "city": "Heraklion", "street_name": "Plateia Syntagmatos"},
    {"country": "grecja", "hotel_name": "Studia Maria", "city": "Nero", "street_name": "Leoforos Alexandras"},
    {"country": "grecja", "hotel_name": "Dias Apartments", "city": "Olimpijska", "street_name": "Plateia Syntagmatos"},
    {"country": "turcja", "hotel_name": "Turunc Resort", "city": "Marmaris", "street_name": "Bağdat Caddesi"},
    {"country": "turcja", "hotel_name": "Andriake Beach Club Hotel", "city": "Turecka", "street_name": "Atatürk Caddesi"},
    {"country": "turcja", "hotel_name": "Kimeros Park Holiday Village", "city": "Turecka", "street_name": "Bağdat Caddesi"},
    {"country": "turcja", "hotel_name": "Kleopatra Micador", "city": "Turecka", "street_name": "Atatürk Caddesi"},
    {"country": "turcja", "hotel_name": "Melissa", "city": "Turecka", "street_name": "Halaskargazi Caddesi"},
    {"country": "turcja", "hotel_name": "Kolibri Hotel", "city": "Turecka", "street_name": "Atatürk Caddesi"},
    {"country": "hiszpania", "hotel_name": "Evenia Zoraida Beach Resort", "city": "Almeria", "street_name": "Paseo del Prado"},
    {"country": "hiszpania", "hotel_name": "Evenia Olympic Park", "city": "Brava", "street_name": "Calle Mayor"},
    {"country": "hiszpania", "hotel_name": "Estival Islantilla", "city": "Luz", "street_name": "Calle Mayor"},
    {"country": "hiszpania", "hotel_name": "Cartago Nova by Alegria", "city": "Brava", "street_name": "Paseo del Prado"},
    {"country": "hiszpania", "hotel_name": "Catalonia", "city": "Brava", "street_name": "Calle de Alcalá"},
    {"country": "hiszpania", "hotel_name": "Reymar Playa", "city": "Maresme", "street_name": "Paseo del Prado"},
    {"country": "hiszpania", "hotel_name": "GHT Oasis Park & Spa", "city": "Brava", "street_name": "Gran Vía"},
    {"country": "wlochy", "hotel_name": "San Domenico", "city": "Kalabria", "street_name": "Via del Corso"},
    {"country": "wlochy", "hotel_name": "Baia di Zambrone", "city": "Kalabria", "street_name": "Via Veneto"},
    {"country": "wlochy", "hotel_name": "Rada Siri", "city": "Kalabria", "street_name": "Via Veneto"},
    {"country": "wlochy", "hotel_name": "Hotel Orizzonte Blu", "city": "Kalabria", "street_name": "Via Nazionale"},
    {"country": "chorwacja", "hotel_name": "Gradac", "city": "Riwiera", "street_name": "Kapucinska ulica"},
    {"country": "chorwacja", "hotel_name": "Villa Penava", "city": "Riwiera", "street_name": "Trg bana Josipa Jelačića"},
    {"country": "chorwacja", "hotel_name": "Apartamenty Omiś", "city": "Riwiera", "street_name": "Vukovarska ulica"},
    {"country": "chorwacja", "hotel_name": "Nano", "city": "Riwiera", "street_name": "Maksimirska ulica"},
    {"country": "chorwacja", "hotel_name": "Apartamenty Makarska", "city": "Riwiera", "street_name": "Maksimirska ulica"},
    {"country": "egipt", "hotel_name": "Marina Resort Port Ghalib", "city": "Alam", "street_name": "Sharia Tahrir"},
    {"country": "egipt", "hotel_name": "Barcelo Tiran Sharm Resort", "city": "Sheikh", "street_name": "Sharia Tahrir"},
    {"country": "egipt", "hotel_name": "Old Vic Resort Sharm", "city": "Sheikh", "street_name": "Sharia Ramsis"},
    {"country": "egipt", "hotel_name": "Marina Lodge Port Ghalib", "city": "Alam", "street_name": "Sharia Ramsis"},
    {"country": "egipt", "hotel_name": "Falcon Naama Star", "city": "Sheikh", "street_name": "Sharia Salah Salem"},
    {"country": "egipt", "hotel_name": "Protels Crystal Beach Resort", "city": "Alam", "street_name": "Sharia Tahrir"},
    {"country": "egipt", "hotel_name": "MG Alexander The Great", "city": "Alam", "street_name": "Sharia Gamal Abdel Nasser"},
    {"country": "egipt", "hotel_name": "Bliss Nada Beach Resort", "city": "Alam", "street_name": "Sharia Tahrir"}
]

def find_hotels_by_country(country):
    return [hotel for hotel in parsed_data if hotel["country"] == country]

def find_hotels_by_city(city):
    return [hotel for hotel in parsed_data if hotel["city"] == city]

def find_hotels_by_street(street_name):
    return [hotel for hotel in parsed_data if hotel["street_name"] == street_name]

def generate_transport_option(i):
    from_hotel = random.choice(parsed_data)
    to_hotel = random.choice(parsed_data)

    # Ensure from and to locations are different
    while from_hotel == to_hotel:
        to_hotel = random.choice(parsed_data)

    # Generate random start and end times
    start_day = random.randint(1,90)
    start_hour = random.randint(0,23)
    duration = random.randint(2, 12)
    if start_hour + duration > 24:
        end_day = start_day + 1
        end_hour = start_hour + duration - 24
    else:
        end_day = start_day
        end_hour = start_hour + duration

    price_adult = random.randint(50, 300)
    initial_seats = random.randint(50, 200)
    transport_type = random.choice(["Plane", "Bus", "Train"])

    # Create the transport option with the specified format
    new_tour = f"""
    new CommandTransportOption
    {{
        Id = TransportIds[{i}], Start = DateTime.UtcNow.AddDays({start_day}).AddHours({start_hour}), 
        End = DateTime.UtcNow.AddDays({end_day}).AddHours({end_hour}), 
        PriceAdult = {price_adult}, Type = "{transport_type}", InitialSeats = {initial_seats},
        FromCity = "{from_hotel['city']}", FromCountry = "{from_hotel['country']}", FromStreet = "{from_hotel['street_name']}",
        ToCity = "{to_hotel['city']}", ToCountry = "{to_hotel['country']}", ToStreet = "{to_hotel['street_name']}"
    }},
    """

    querry = f"""
    new QueryTransportOption
    {{
        Id = TransportIds[{i}], Start = DateTime.UtcNow.AddDays({start_day}).AddHours({start_hour}), 
        End = DateTime.UtcNow.AddDays({end_day}).AddHours({end_hour}), 
        PriceAdult = {price_adult}, PriceUnder3 = {int(price_adult*0.2)}, PriceUnder12 = {int(price_adult*0.5)}, PriceUnder18 = {int(price_adult*0.9)},  Type = "{transport_type}", Seats = {initial_seats},
        FromCity = "{from_hotel['city']}", FromCountry = "{from_hotel['country']}", FromStreet = "{from_hotel['street_name']}",
        ToCity = "{to_hotel['city']}", ToCountry = "{to_hotel['country']}", ToStreet = "{to_hotel['street_name']}"
    }},
    """

    return new_tour,querry

def generate_to_dbcontext(n):
    with open('dbcontexts_template/to_db_context.txt', 'r') as template:
        template_content = template.read()

    with open('dbcontexts_generated/TransportDbContext.cs', 'w', encoding='utf-8') as dbcontext:
        dbcontext.write(template_content)

        gen_guids = f"""

            Guid[] TransportIds = new Guid[{n}];
                    for (int i = 0; i < TransportIds.Length; i++)
                    {{
                        TransportIds[i] = Guid.NewGuid();
                    }}

        """

        dbcontext.write(gen_guids)


        transport_options = """
        var transportOptions = new[]
            {
                """
        dbcontext.write(transport_options)

        tos = []
        querries = []
        for i in range(n):
            new_to, querry = generate_transport_option(i)
            if new_to not in tos:
                dbcontext.write(new_to)
                tos.append(new_to)
                querries.append(querry)

        dbcontext.write("""
                                };
                modelBuilder.Entity<CommandTransportOption>().HasData(transportOptions);
            }
        }
    }
                        """
                        )
        
        query_transport_options = """
        var queryTransportOptions = new[]
                    {
            """
        dbcontext.write(query_transport_options)

        for q in querries:
            dbcontext.write(q)

        dbcontext.write("""
                                };
                modelBuilder.Entity<QueryTransportOption>().HasData(queryTransportOptions);
            }
        }
    }
                        """
                        )