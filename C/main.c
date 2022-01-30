#include <stdlib.h>
#include <stdio.h>
#include <stdbool.h>
#define NPANINI 18
#define NBEVANDE 6
#define MAXLHT 100
#define CLT 100

int inizio();
int comprare();
int chiudere();
int scontrino();
int staff();

int panini[NPANINI];

int bevande[NBEVANDE];

char nomPanini[NPANINI][MAXLHT] =
{
	{"Big Mac"},
	{"Gran Crispy"},
	{"Chicken Asiago"},
	{"Montasio & DOP"},
	{"BBQ"},
	{"Crispy McBacon"},
	{"Double Cheeseburger"},
	{"Cheeseburger"},
	{"Hamburger"},
	{"Gluten Free Burger"},
	{"McChicken Originale"},
	{"Double Chicken BBQ"},
	{"Chickenburger"},
	{"McMuffin Bacon Egg"},
	{"Filet O Fish"},
	{"McToast"},
	{"Patatine"},
	{"Chicken Nuggets"}
};
char nomBevande[NBEVANDE][MAXLHT] =
{
	{"Acqua"},
	{"Coca Cola"},
	{"Pepsi"},
	{"Fanta"},
	{"Sprite"},
	{"Mountain Dew"}
};

int main()
{
	int scelta;
	
	int clienti[CLT];
	do
	{
		switch (inizio())
		{
		case 1: comprare();
			break;
		case 2: switch (staff())
					{
					case 1: scorte();
						break;
					case 2: chiudere();
						break;
					case 3: break;
					}
			break;
		default: printf("Inserisci un altro numero\n");
			break;
		}
	}while (scelta != 3);
}


int inizio()
{
	int scelta = 0;
	printf("Benvenuto a McDonald. Cosa vuoi fare?\n[1]Compra [2]Staff Only\n");
	scanf("%d", &scelta);
	return scelta;
}
int staff()
{
	int scelta = 0;
	printf("Cosa vuoi fare?\n[1]Aggiungi Scorte [2]Spegni il totem [3]Torna indietro\n");
	scanf("%d", &scelta);
	return scelta;
}
int scorte()
{
	int scelta = 1;
	int numAgg = 1;
	do
	{
		printf("Quale vuoi aggiungere?\n");
		for (int i = 0; i < NPANINI; ++i)
		{
			printf("[%d]%s\n", i, nomPanini[i]);
		}
		printf("[19]Modifica il numero da aggiungere(%d)\n[20]Esci\n", numAgg);
		scanf("%d", &scelta);

		if(scelta == 19)
		{
			numAgg = modNum();
		} else
		{
			panini[scelta] += numAgg;
		}
	} while (scelta != 20);

}
int modNum()
{
	int scelta = 0;
	int num;
	printf("Quale numero vuoi aggiungere?\n[1]1\n[2]2\n[3]5\n[4]10\n[5]Scegli te il numero\n");
	scanf("%d", &scelta);
	switch (scelta)
	{
	case 1: num = 1;
		break;
	case 2: num = 2;
		break;
	case 3: num = 5;
		break;
	case 4: num = 10;
		break;
	case 5: scanf("%d", &num);
		break;
	default:
		break;
	}
	return num;
}
int comprare()
{

}
int chiudere()
{

}
int scontrino() 
{

}