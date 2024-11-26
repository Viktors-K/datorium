import urllib.request
import csv
csv_link = 'https://download.cloudycdn.services/dlt/izm/media/7277008/31f0762/media?gdRTiocAUGynmaTsnjBSDT04-0nEQ5rxbMmJ-1nlHQ6Lp3_DeFfSCORqQhF5PfQzq5GazBT0qS8elim7aFc4YmsvRsSha24dmwSLz4A'
csv_filename = 'agenti.csv'
with urllib.request.urlopen(csv_link) as page:
    with open(csv_filename, 'wb') as file:
        file.write(page.read())

with open(csv_filename, 'r', encoding='utf-8') as file:
    csv_file = csv.DictReader(file,delimiter=';')
    for line in csv_file:
        if (line['TIPS'] == 'Valsts iestāde' or line['TIPS'] == 'Izglītības iestāde'):
            print(f'{line["TIPS"],line["NOSAUKUMS"],line["ADRESE"]}')
        