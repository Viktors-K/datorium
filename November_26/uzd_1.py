import urllib.request
import csv
csv_link = 'https://download.cloudycdn.services/dlt/izm/media/7277008/31f0762/media?gdRTiocAUGynmaTsnjBSDT04-0nEQ5rxbMmJ-1nlHQ6Lp3_DeFfSCORqQhF5PfQzq5GazBT0qS8elim7aFc4YmsvRsSha24dmwSLz4A'
csv_filename = 'agenti.csv'

def print_csv(input):
    for line in input:
        print(line)
        
# uzdevums 1
with urllib.request.urlopen(csv_link) as page:
    with open(csv_filename, 'wb') as file:
        file.write(page.read())
        
# uzdevums 2 
lines_2 = []
with open(csv_filename, 'r', encoding='utf-8') as file:
    csv_file = csv.DictReader(file,delimiter=';')
    for line in csv_file:
        if (line['TIPS'] == 'Valsts iestāde' or line['TIPS'] == 'Izglītības iestāde'):
            lines_2.append(line)
print_csv(lines_2)

# uzdevums 3
lines_3 = []
for line in lines_2:
    city = line['ADRESE'].split(', ')[1]
    if city == 'Rīga':
        lines_3.append(line)
print_csv(lines_3)

# uzdevums 4
lines_4 = sorted(lines_3, key=lambda x: x['NOSAUKUMS'])
print_csv(lines_4)
        