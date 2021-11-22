#include <stdlib.h>
#include <stdio.h>
#define NVOTI 5

int
main ()
{
  int voto, i;
  int votoMin = 10;
  int votoMax = 0;
  float votoMed;
  int sommaMed = 0;
  i = 0;
  while (i < NVOTI)
    {
      printf ("Inserisci un voto ");
      scanf ("%d", &voto);
      printf ("\n");
      if (voto > votoMax)
	{
	  votoMax = voto;
	}
      if (voto < votoMin)
	{
	  votoMin = voto;
	}
      sommaMed = sommaMed + voto;
      i++;
    }
  votoMed = sommaMed / NVOTI;
  printf ("La media e %.2f \n", votoMed);
  printf ("Il voto massimo e %d \n", votoMax);
  printf ("Il voto minimo e %d", votoMin);
  system ("pause");
}
