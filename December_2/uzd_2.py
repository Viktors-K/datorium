alfabets = '_AĀBCČDEĒFGĢHIĪJKĶLĻMNŅOPRSŠTUŪVZŽ'

# izveidoju sarakstu ar 34 empty strings
saraksts = ['' for i in range(len(alfabets))]

# pilda kodu, kamēr saraksts nav aizpildīts1
while '' in saraksts[1:]:
  vards = input('Ievadi vārdu: ')

  if not vards.isalpha() or not vards[0].isupper():
    print('Vārds nav derīgs')
    continue

  pozicija = alfabets.index(vards[0])

  if saraksts[pozicija] == '':
    saraksts[pozicija] = vards
    print(f'Vārds {vards} pievienots {pozicija}. vietā')

  else:
    vecs_vards = saraksts[pozicija]
    saraksts[pozicija] = vards
    print(f'Vārds {vecs_vards} ir aizvietots ar vārds {vards}')