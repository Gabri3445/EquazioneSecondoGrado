#include <stdlib.h>
#include <stdio.h>

int main()
{
	float prodotto1 = 0;
	float prodotto2 = 0;
	float prodotto3 = 0;
	float prodotto4 = 0;
	float prodotto5 = 0;

	float sconto = 0;

	float totale = 0;
	float scontotot = 0;
	float totfinale = 0;

	char prodBool;

	printf("Inserisci il prodotto 1: ");
	scanf("%f", &prodotto1);
	printf("Vuoi continuare? Y/N ");
	scanf(" %c", &prodBool);
	if(prodBool == 'y')
	{
		printf("Inserisci il prodotto 2: ");
		scanf("%f", &prodotto2);
		printf("Vuoi continuare? Y/N ");
		scanf(" %c", &prodBool);
			if (prodBool == 'y')
			{
				printf("Inserisci il prodotto 3: ");
				scanf("%f", &prodotto3);
				printf("Vuoi continuare? Y/N ");
				scanf(" %c", &prodBool);
			}
				if (prodBool == 'y')
				{
					printf("Inserisci il prodotto 4: ");
					scanf("%f", &prodotto4);
					printf("Vuoi continuare? Y/N ");
					scanf(" %c", &prodBool);
				}
					if (prodBool == 'y')
					{
						printf("Inserisci il prodotto 5: ");
						scanf("%f", &prodotto5);
					}
	}
	totale = prodotto1 + prodotto2 + prodotto3 + prodotto4 + prodotto5;
	if (totale > 100)
	{
		sconto = totale * 0.20;
		printf("%f", sconto);
		totfinale = totale - sconto;
	}
	else 
	{
		if (totale > 50)
		{
			sconto = totale * 0.10;
			totfinale = totale - sconto;
		}
		else 
		{
			totfinale = totale;
		}
	}
	
	printf("\n");
	printf("Scontrino: \n");
	printf("Prodotto 1: %f \n", prodotto1);
	if(prodotto2 != 0) 
	{
		printf("Prodotto 2: %f \n", prodotto2);
	}
		if (prodotto3 != 0)
		{
		printf("Prodotto 3: %f \n", prodotto3);
		}
			if (prodotto4 != 0)
			{
				printf("Prodotto 4: %f \n", prodotto4);
			}
				if (prodotto5 != 0)
				{
					printf("Prodotto 5: %f \n", prodotto5);
				}
	printf("Costo totale: %f \n", totale);
	if (sconto != 0)
	{
		printf("Sconto: %f \n", sconto);
		printf("Costo con lo sconto: %f \n", totfinale);
	}
	system("pause");
}