# Crociera

## Analisi

Il programma inizia con il "programma di registrazione". In esso si hanno due scelte:
1. Partire
2. Aggiungere famiglie

Nella seconda scelta si sceglie quanti membri ci sono nella famiglia dove il massimo é
quattro a causa della dimesione delle cabine. Vengono poi inseriti Nome, Cognome, Giorno
di nascita, Mese di nascita e l'anno di Nascita. A prescindere dalla dimensioni della 
famiglia vengono assegnate a una cabina.

Quando la crociera parte vengono generati i soldi spesi da ogni crocierista. 
Infine vengono stampati tutti i crocieristi e le loro informazioni.

## I/O

Input: choice, familyMemb, names\[\], surnames\[\], birthdayDay\[\], birthdayMonth\[\], birthdayYear\[\]

Output: numPeople, i, occupiedCabins\[\], names\[\], surname\[\], birthdayDay\[\], birthdayMonth\[\], birthdayYear\[\], moneySpent\[\]

## Tabella variabili

| Nome                            | Tipo              | Direzionalita | Descrizione                                 |
|---------------------------------|-------------------|---------------|---------------------------------------------|
| \_TOT_PEOPLE                    | CONST / INT / GLB | W             | Numero massimo di persone                   |
| \_NUM_CABINE                    | CONST / INT / GLB | W             | Numero massimo di un tipo singolo di cabina |
| \_MAX_LENGHT                    | CONST / INT / GLB | W             | Numero massimo di lunghezza delle stringhe  |
| numFamily                       | INT / GLB         | W             | Numero di persone                           |
| numPeople                       | INT / GLB         | O             | Numero di persone                           |
| Names\[\_TOT_PEOPLE\]           | STR / GLB / ARR   | I/O           | Nomi dei crocieristi                        |
| Surnames\[\[\_TOT_PEOPLE\]      | STR / GLB / ARR   | I/O           | Cognomi dei crocieristi                     |
| birthdayDay\[\[\_TOT_PEOPLE\]   | INT / GLB / ARR   | I/O           | Giorno di nascita dei crocieristi           |
| birthdayMonth\[\[\_TOT_PEOPLE\] | INT / GLB / ARR   | I/O           | Mese di nascita dei crocieristi             |
| birthdayYear\[\[\_TOT_PEOPLE\]  | INT / GLB / ARR   | I/O           | Anno di nascita dei crocieristi             |
| familyLenght\[\[\_TOT_PEOPLE\]  | INT / GLB / ARR   | I/O           | Quante persone ci sono in una famiglia      |
| familyIndex                     | INT / GLB         | W             | Numero di famiglie                          |
| moneySpent\[\[\_TOT_PEOPLE\]    | FLT / GLB / ARR   | O             | Soldi spesi dai crocieristi                 |
| occupiedCabins\[4\]             | INT / GLB / ARR   | O             | Cabine occupate                             |
| State                           | INT / GLB         | W             | Stato del programma                         |
| isRunning                       | BOOL / GLB        | W             | Il programma é in esecuzione?               |
| isFull                          | BOOL / GLB        | W             | La nave è piena?                            |
| isCabinFull                     | BOOL / GLB        | W             | Le cabine sono piene?                       |
| manualNames                     | BOOL / GLB        | I             | Nomi automatici o manuali                   | 
| Choice                          | INT               | I             | Scelta in vari menu                         |
| familyMemb                      | INT               | I             | Membri di una singola famiglia              |
| \_isRunning                     | BOOL              | W             | La funzione è in esecuzione?                |
| \_isCabinFull\[4\]              | BOOL / ARR        | W             | Sono piene le cabine?                       |
| I                               | INT / GLB         | O/W           | Contatore generico                          |

## Campione I/O
| Input | Output |
| ----- | ------ |
| Scelta=0 ( Registra una famiglia ) | |
| familyMemb = 2 | |
| | Membro della famiglia (1)|
| Mario | |
| Rossi | |
| 20 | |
| 12| |
| 1990 | |
| | Membro della famiglia (2) |
| Nicolo | |
| Lorusso | |
| 28 | |
| 5 | |
| 2001 | |
| Scelta=1 | |
| | Cabine Occupate |
| | Cabine da 1 occupate : 0 |
| | Cabine da 2 occupate : 1 |
| | Cabine da 3 occupate : 0 |
| | Cabine da 4 occupate : 0 |
| | Persona numero 1 |
| | Nome: Mario |
| | Cognome: Rossi |
| | Giorno di nascita: 20 |
| | Mese di nascita: 12 |
| | Anno di nascita: 1990 |
| | Soldi spesi: 391.32 |
| | Persona numero 2 |
| | Nome: Nicolo |
| | Cognome: Lorusso |
| | Giorno di nascita: 28 |
| | Mese di nascita: 5 |
| | Anno di nascita: 2001 |
| | Soldi spesi: 300.36 |
