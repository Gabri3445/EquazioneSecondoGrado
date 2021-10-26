#include <stdlib.h>
#include <stdio.h>

int main() 
{
  int numPrimo = 0;
  int numSecondo = 0;
  int festivo = 0;
  float tot = 0;
  float iva = 0;
  float totiva = 0;
  float totcosto = 0;
  const int costoPrimo = 20;
  const int costoSecondo = 10;
  const int iva = 10;
  const int scontoLav = 5;
  const int costoOrc = 50;
  
  printf("Scrivi il numero di primi");
  scanf("%f", numPrimo);
  
  printf("Scrivi il numero di secondi");
  scanf("%f", numSecondo);
  
  printf("E un giorni festivo? 0/1");
  scanf("%d", festivo);
  
  tot = (numPrimo * costoPrimo) + (numSecondo * costoSecondo);
  iva = tot * (sconto / 100);
  totiva = tot + iva;
  
  if(festivo == 0) 
  {
   totcosto = totiva - scontoLav;
  }
  else 
  {
   totcosto = totiva + costoOrc;
  }
  
  printf("Il costo e: %d", totcosto);

}
