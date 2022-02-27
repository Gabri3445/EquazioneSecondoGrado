#include <stdlib.h>
#include <stdio.h>
#include <stdbool.h>
#include <string.h>
#define NPANINI 18
#define NBEVANDE 6
#define MAXLHT 100
#define CLT 100
#define NCOUPON 5

int inizio();
int comprare();
int chiudere();
int scontrino();
int staff();
int modNum();
int scorte();
float mediaf(float arr[]);
bool sconto();
void clear();

int panini[NPANINI];

int bevande[NBEVANDE];

float cosPanini[NPANINI] = { 6.40f, 8.10f, 8.60f, 8.60f, 8.60f, 6.70f, 2.90f, 1.80f, 1.30f, 4.50f, 6.40f, 2.90f, 1.80f, 2.40f, 2.90f, 1.80f, 1.90f, 5.60f };

float cosBevande[NBEVANDE] = { 1.50f, 2.80f, 0.55f, 2.80f, 2.80f, 1.90f };

char nomPanini[NPANINI][MAXLHT] =
{
	{"Big Mac"},
	{"Gran Crispy"},
	{"Chicken Asiago"},
	{"Montasio & Pancetta"},
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
	{"6 Chicken Nuggets"}
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

float clienti[CLT];

int numClienti = 0;

float profitto = 0;

int carrello[24];

char couponList[NCOUPON][MAXLHT] =
{
	{"MCDONALD5"},
	{"MCDONALD10"},
	{"MCDONALD15"},
	{"MCDONALD20"},
	{"MCDONALD25"}
};

float couponSconto[NCOUPON] = { 0.05f, 0.10f, 0.15f, 0.20f, 0.25f };

int couponScelto[NCOUPON];

bool couponBool = false;

int main()
{
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
	} while (true);
}


int inizio()
{
	int scelta = 0;
	clear();
	printf("Benvenuto a McDonald. Cosa vuoi fare?\n[1]Compra [2]Staff Only\n");
	scanf("%d", &scelta);
	return scelta;
}
int staff()
{
	int scelta = 0;
	clear();
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
		clear();
		printf("Quale vuoi aggiungere?\n");
		for (int i = 0; i < NPANINI; ++i)
		{
			printf("[%d]%s\n", i, nomPanini[i]);
		}
		for (int i = 0; i < NBEVANDE; ++i)
		{
			printf("[%d]%s\n", i + 18, nomBevande[i]);
		}
		printf("[24]Modifica il numero da aggiungere(%d)\n[25]Esci\n", numAgg);
		scanf("%d", &scelta);

		if (scelta == 24)
		{
			numAgg = modNum();
		}
		else if (scelta < 18)
		{
			panini[scelta] += numAgg;
		}
		else if (scelta >= 18)
		{
			bevande[scelta - 18] += numAgg;
		}
	} while (scelta != 25);
	return 0;
}
int modNum()
{
	clear();
	int scelta = 0;
	int num = 1;
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
	int scelta = 1;
	do
	{
		clear();
		printf("Quale vuoi comprare?\n");
		for (int i = 0; i < NPANINI; ++i)
		{
			if (panini[i] > 0)
			{
				printf("[%d]%s(%d) = %.2f $\n", i, nomPanini[i], panini[i], cosPanini[i]);
			}
		}
		for (int i = 0; i < NBEVANDE; ++i)
		{
			if (bevande[i] > 0)
			{
				printf("[%d]%s(%d) = %.2f $\n", i + 18, nomBevande[i], bevande[i], cosBevande[i]);
			}
		}
		printf("[24]Termina\n");
		scanf("%d", &scelta);
		if (scelta < 24)
		{
			if (scelta < 18 && panini[scelta] > 0)
			{
				panini[scelta] -= 1;
				carrello[scelta] += 1;
			}
			else if (scelta >= 18 && bevande[scelta - 18] > 0)
			{
				bevande[scelta - 18] -= 1;
				carrello[scelta] += 1;
			}
			else
			{
				printf("Scegli un altro alimento, questo non é disponibile\n");
			}
		}
		else if (scelta == 24)
		{
			scontrino();
		}
	} while (scelta != 24);

	return 0;
}
int chiudere()
{
	int i = 0;
	float media = 0;
	clear();
	while (clienti[i] > 0)
	{
		profitto += clienti[i];
		i++;
	}
	media = mediaf(clienti);
	printf("Numero di clienti: %d\n", i);
	printf("Profitto Totale: %.2f\n", profitto);
	if (media > 0)
	{
		printf("Media degli importi: %.2f\n", media);
	}
	system("pause");
	exit(0);
}
int scontrino()
{
	clear();
	for (int i = 0; i < NBEVANDE + NPANINI; i++)
	{
		if (carrello[i] > 0)
		{
			if (i < 18)
			{
				printf("(%d)%s = %.2f $\n", carrello[i], nomPanini[i], cosPanini[i]);
			}
			else if (i >= 18)
			{
				printf("(%d)%s= %.2f $\n", carrello[i], nomBevande[i - 18], cosBevande[i - 18]);
			}
		}
	}
	for (int i = 0; i < NBEVANDE + NPANINI; i++)
	{
		if (carrello[i] > 0)
		{
			if (i < 18)
			{
				clienti[numClienti] += cosPanini[i] * carrello[i];
			}
			else if (i >= 18)
			{
				clienti[numClienti] += cosBevande[i - 18] * carrello[i];
			}
		}
	}
	if(clienti[numClienti] > 0)
	{
		printf("Ecco lo scontrino:\n");
		sconto();
		if (couponBool == true)
		{
			for (int i = 0; i < NCOUPON; i++)
			{
				if (couponScelto[i] > 0)
				{
					clienti[numClienti] = clienti[numClienti] - (couponSconto[i] * clienti[numClienti]);
				}
			}
		}
		printf("Costo totale:%.2f\n", clienti[numClienti]);
		numClienti += 1;
		system("pause");
	}
	for (int i = 0; i < 24; i++)
	{
		carrello[i] = 0;
	}
	return 0;
}
float mediaf(float arr[])
{
	float sum = 0;
	float avg;
	int i = 0;
	while (arr[i] > 0)
	{
		sum += arr[i];
		i++;
	}
	avg = sum / i;
	return avg;
}
bool sconto()
{
	char couponInp[MAXLHT] = { "" };
	printf("Se hai un coupon inseriscilo (Se non hai un coupon scrivi 0)\n");
	scanf("%s", &couponInp);
	for (int i = 0; i < NCOUPON; i++)
	{
		if (strcmp(couponList[i], couponInp) == 0)
		{
			couponScelto[i] += 1;
			couponBool = true;
			return 0;
		}
		else
		{
			couponBool = false;
		}
	}
	return 0;
}
void clear()
{
	system("cls");
}
