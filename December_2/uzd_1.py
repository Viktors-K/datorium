import requests
import sys

response = requests.get('https://data.gov.lv/dati/lv/api/3/action/datastore_search?resource_id=92ac6e57-c5a5-444e-aaca-ae90c120cc3d')

if response.status_code != 200:
  print("Nav izdevies saņemt atbildi")
  sys.exit()

json_data = response.json()

if not json_data:
  print("Atbilde ir tukša")
  sys.exit()

atkritumu_punkti = json_data['result']['records']

baterijas = []
riepas = []
metals = []


for punkts in atkritumu_punkti:
  if punkts['8 : Baterijas un akumulatori'] == 'x':
    baterijas.append(punkts)

  if punkts['10 : Nolietotās riepas'] == 'x':
    riepas.append(punkts)

  if punkts['3 : Metāls'] == 'x':
    metals.append(punkts)


print(atkritumu_punkti[0])