import requests
import random
import time
import schedule
import argparse


def login(ip):
    url = f'{ip}/api/Auth/Login/'
    payload = {"username": "admin", "password": "passwordadmin"}
    response = requests.post(url, json=payload)
    response.raise_for_status()
    return response.json()["token"]

def get_tours(ip):
    url = f'{ip}/api/Tours/'
    params = {'minDuration': 7, 'maxDuration': 9}
    response = requests.get(url, params=params)
    response.raise_for_status()
    return response.json()

def get_hotels(token,ip):
    url = f'{ip}/api/Hotels'
    headers = {'Authorization': f'{token}'}
    response = requests.get(url, headers=headers)
    response.raise_for_status()
    return response.json()

def make_reservation(token, tours_data,ip):
    url = f'{ip}/api/Reservations/'
    headers = {'Authorization': f'{token}'}

    for tour in tours_data:
        payload = {
            "toHotelTransportOptionId": tour["toHotelTransportOptionId"],
            "fromHotelTransportOptionId": tour["fromHotelTransportOptionId"],
            "hotelId": tour["hotelId"],
            "numberOfAdults": 2,
            "numberOfUnder3": 0,
            "numberOfUnder10": 0,
            "numberOfUnder18": 0,
            "foodIncluded": True,
            "rooms": [{"size": 2, "count": 1}]
        }
        response = requests.post(url, json=payload, headers=headers)
        response.raise_for_status()
        time.sleep(3)

def save_first_hotel(hotels):
    if hotels:
        return hotels[0]
    else:
        return None
    
def get_transport_options(token,ip):
    url = f'{ip}/api/TransportOptions'
    headers = {'Authorization': f'{token}'}
    response = requests.get(url, headers=headers)
    response.raise_for_status()
    return response.json()

def save_first_transport_option(transport_options):
    if transport_options:
        return transport_options[0]
    else:
        return None

def post_discount_hotel(token, hotel_id,ip):
    headers = {'Authorization': f'{token}'}
    random_value = round(random.random(),2)
    payload = {"id": hotel_id, "value": random_value}
    url = f'{ip}/api/Hotels/{hotel_id}/Discount'
    response = requests.post(url, json=payload, headers=headers)
    response.raise_for_status()
    print(f"Posted discount for hotel {hotel_id} with value {random_value}")

def post_discount_transport(token, transport_option_id,ip):
    headers = {'Authorization': f'{token}'}
    random_value = round(random.random(),2)
    payload = {"id": transport_option_id, "value": random_value}
    url = f'{ip}/api/TransportOptions/{transport_option_id}/Discount'
    response = requests.post(url, json=payload, headers=headers)
    response.raise_for_status()
    print(f"Posted discount for transport option {transport_option_id} with value {random_value}")

def main():
    parser = argparse.ArgumentParser(description='Run generator on specific IP.')

    parser.add_argument('ip', type=str, help='IP with port.')

    args = parser.parse_args()

    if args.ip:
        ip = args.ip
    else:
        ip = "http://localhost:18460"

    print(f'IP: {ip}')


    token = login(ip)

    tours_data = get_tours(ip)

    make_reservation(token, tours_data,ip)

    hotels = get_hotels(token,ip)
    first_hotel = save_first_hotel(hotels)
    if first_hotel:
        print("First hotel saved:", first_hotel)
        schedule.every(5).seconds.do(post_discount_hotel, token, first_hotel['id'],ip)
    else:
        print("No hotels found.")

    transport_options = get_transport_options(token,ip)
    first_transport_option = save_first_transport_option(transport_options)
    if first_transport_option:
        print("First transport option saved:", first_transport_option)
        schedule.every(7).seconds.do(post_discount_transport, token, first_transport_option['id'],ip)
    else:
        print("No transport options found.")

    while True:
        schedule.run_pending()
        time.sleep(1)

if __name__ == "__main__":
    main()
