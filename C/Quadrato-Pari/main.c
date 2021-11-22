//area del quadrato solo con numero pari
#include <stdlib.h>
#include <stdio.h>
#include <math.h>
#include <stdbool.h>

int main()
{
  int lato;
  int area;
  bool cond = true;
  
  printf("Inserisci il lato ");
  scanf("%d", lato);
  while(cond == true)
  {
    if(%lato != 0)
    {
      printf("Il numero non e pari. Inserisci di nuovo );
      scanf("d", lato);
    }
    else 
    {
      cond = true;
    }
  }
  area = pow(lato, 2);
  printf("L'area e' %d", area);
  system("pause");
}
