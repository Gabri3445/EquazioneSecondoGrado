#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#define NVOTI 5

int main()
{
	int voto0, voto1, voto2, voto3, voto4;
	float votoMed;
	int votoMax, votoMin;

	printf("Inserisci il primo voto ");
	scanf("%d", &voto0);
	printf("Inserisci il secondo voto ");
	scanf("%d", &voto1);
	printf("Inserisci il terzo voto ");
	scanf("%d", &voto2);
	printf("Inserisci il quarto voto ");
	scanf("%d", &voto3);
	printf("Inserisci il quinto voto ");
	scanf("%d", &voto4);

	votoMed = (voto0 + voto1 + voto2 + voto3 + voto4) / NVOTI;

	if (voto0 > voto1 && voto0 > voto2 && voto0 > voto3 && voto0 > voto4)
	{
		votoMax = voto0;
	}
	else if (voto1 > voto2 && voto1 > voto3 && voto1 > voto4)
	{
		votoMax = voto1;
	}
	else if (voto2 > voto3 && voto2 > voto4)
	{
		votoMax = voto2;
	}
	else if (voto3 > voto4)
	{
		votoMax = voto3;
	}
	else
	{
		votoMax = voto4;
	}


	if (voto0 < voto1 && voto0 < voto2 && voto0 < voto3 && voto0 < voto4)
	{
		votoMin = voto0;
	}
	else if (voto1 < voto2 && voto1 < voto3 && voto1 < voto4)
	{
		votoMin = voto1;
	}
	else if (voto2 < voto3 && voto2 < voto4)
	{
		votoMin = voto2;
	}
	else if (voto3 < voto4)
	{
		votoMin = voto3;
	}
	else
	{
		votoMin = voto4;
	}

	printf("La media e' %.2f\n", votoMed);
	printf("Il voto minimo e' %d\n", votoMin);
	printf("Il voto massimo e' %d\n", votoMax);
}