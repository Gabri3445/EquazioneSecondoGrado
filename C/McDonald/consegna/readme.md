# McDonald

## Analisi

Il programma inizia chiedendo all&#39;utente se è un cliente o un membro dello staff. Se è un cliente gli chiede cosa deve comprare. Se le scorte sono superiori a uno il programma stampa l&#39;alimento o bevanda rilevante. Quando l&#39;utente sceglie un alimento questo viene aggiunto al carrello. Quando l&#39;utente finisce il programma stampa lo scontrino e chiede all&#39;utente se ha un coupon e se si viene applicato uno sconto che dipende dal coupon. Se l&#39;utente è un membro dello staff allora gli viene presentata una altra scelta. L&#39;utente sceglie se vuole aggiungere le scorte dove puó modificare il numero da aggiungere, se vuole finire la giornata il cui menu fa vedere quanti clienti ci sono stati, il profitto totale e la media dei costi. Si possono salvare le scorte in un file solo con la versione di C#.

## I/O

Input: panini[], bevande[], carrello[], scelta, numAgg, num, couponInp

Output: clienti[], cosPanini[], cosBevande[], nomPanini[], nomBevande[], profitto, media

## Tabella variabili

| Nome | Tipo | Direzionalitá | Descrizione |
| --- | --- | --- | --- |
| NPANINI | CONST/INT/GLB | W | Numero di panini |
| CLT | CONST/INT/GLB | W | Numero massimo di clienti |
| NBEVANDE | CONST/INT/GLB | W | Numero di bevande |
| MAXLHT | CONST/INT/GLB | W | Numero massimo di caratteri nelle stringhe |
| NCOUPON | CONST/INT/GLB | W | Numero di coupon |
| Panini[NPANINI] | ARR/INT/GLB | I | Scorte dei panini |
| Bevande[NBEVANDE] | ARR/INT/GLB | I | Scorte delle bevande |
| cosPanini[NPANINI] | ARR/FLT/GLB | W | Costo dei panini |
| cosBevande[NBEVANDE] | ARR/FLT/GLB | W | Costo delle bevande |
| nomPanini[NPANINI] | ARR/STR/GLB | O | Nome dei panini |
| nomBevande[NBEVANDE] | ARR/STR/GLB | O | Nome delle bevande |
| CLIENTI[CLT] | ARR/INT/GLB | W | Resoconto di ogni cliente |
| numClienti | INT/GLB | W | Quale cliente viene servito |
| Profitto | FLT/GLB | O | Resoconto di fine giornata calcolato sommando ogni elemento di clienti |
| Carrello[24] | INT/GLB | W/I | Quale alimenti o bevande il cliente ha scelto |
| couponList | ARR/STR/GLB | W | Ogni coupon attivabile |
| couponSconto | ARR/FLT/GLB | W | Quanto sconto deve essere tolto in percentuale calcolato con ( percentuale di sconto / 100 ) |
| couponScelto | INT/GLB | W | Coupon applicato dal cliente |
| couponBool | BOOL/GLB | W | Se è stato applicato un coupon oppure no |
| Scelta | INT | I | Input dell&#39;utente per navigare nei menu o per scegliere un alimento. Presente in quasi tutte le funzioni |
| numAgg | INT | I | Numero di scorte da aggiungere |
| num | INT | I | Modifica numAgg con la sua funzione |
| i | INT | W | Contatore generico. Presente in svariate funzioni |
| media | FLT | O | Media di tutti i resoconti calcolato con ( sum / numero di clienti ) |
| Sum | FLT | W | Somma di tutti i resoconti |
| avg | FLT | W | Vedi media. Viene usata nella funzione apposita |
| couponInp | ARR/STR | I | Coupon inserito dall&#39;utente |
| filePath | STR/GLB | W | Dove viene salvato il file |

## Campione I/O

| Input | Output |
| --- | --- |
| Scelta=1(compra) |
 |
| Scelta=0 |
 |
| Scelta=20 |
 |
| Scelta=2 |
 |
| Scelta=4 |
 |
| Scelta=4 |
 |
| Scelta=24 (termina) |
 |
|
 | (1)Big Mac = 6.40 $ |
|
 | (1)Chicken Asiago = 8.60 $ |
|
 | (2)BBQ = 8.60 $ |
|
 | (1)Pepsi= 0.55 $ |
| couponInp=0 |
 |
|
 | Costo totale:32.75 |
| Scelta=1(compra) |
 |
| Scelta=3 |
 |
| Scelta=18 |
 |
| Scelta=22 |
 |
| Scelta=24 (termina) |
 |
|
 | (1)Montasio &amp; Pancetta = 8.60 $ |
|
 | (1)Acqua= 1.50 $ |
|
 | (1)Sprite= 2.80 $ |
| couponInp= MCDONALD10 |
 |
|
 | Costo totale:11.61 |
| Scelta= 2(menu staff) |
 |
| Scelta= 2(spegni il totem) |
 |
|
 | Numero di clienti: 2 |
|
 | Media totale:22.18 |
|
 | Resoconto totale:44.36 |
