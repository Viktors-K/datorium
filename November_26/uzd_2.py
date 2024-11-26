import requests
import sys
url = 'https://restcountries.com/v3.1/all'
response = requests.get(url)
if response.status_code == 200:
    print('200 OK')
else:
    print(f'Error code: {response.status_code}')
    sys.exit()

countries = response.json()

#3 uzdevums
country_names = []
for country in countries:
    country_names.append(country['name']['common'])
print(country_names)

#4 uzdevums
country_count = len(countries)
print(f'Total countries:{country_count}')

#5 uzdevums
country_totalpop = 0
for country in countries:
    country_totalpop += country['population']
country_avgpop = country_totalpop/country_count
print(f'Average population:{round(country_avgpop)}')

#6 uzdevums
pop_list = {}
for country in countries:
    pop_list[country['name']['common']] = country['population']
max_pop = max(pop_list, key=pop_list.get)
print(f'Largest population:{max_pop} with a population of {pop_list[max_pop]}.')

#7 uzdevums
country_totalarea = 0
for country in countries:
    country_totalarea += country['area']
print(f'Total area:{round(country_totalarea)} km2')

#8 uzdevums
for country in countries:
    if country['name']['common'] == 'Latvia':
        selected_country = country
print(f'{selected_country['name']['common']} is in the {selected_country['subregion']} region.')
print(f'{selected_country['name']['common']} borders {selected_country['borders']}.')