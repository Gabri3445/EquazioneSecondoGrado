#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <stdbool.h>
#include <time.h>


//Function prototype
void registration(); //registration function
void shopping(); //shopping function
void output(); //output function
void clear(); //clear function
int findIndex();
float mcDonald();
float gucciStore();
float bar();

//Constants
#define _TOT_PEOPLE 100 //Max number of people
#define _NUM_CABINE 10 // Max number of cabines
#define _MAX_LENGHT 1000 //Max length of strings


//Main input vars
// int numFamily[_TOT_PEOPLE]; //Number of people in each family

int numFamily = 0;
int numPeople = 0; //Total number of people
char names[_TOT_PEOPLE][_MAX_LENGHT]; //Names of people
char surnames[_TOT_PEOPLE][_MAX_LENGHT]; //Surnames of people
int birthdayDay[_TOT_PEOPLE]; //Birthday day of people
int birthdayMonth[_TOT_PEOPLE]; //Birthday month of people
int birthdayYear[_TOT_PEOPLE]; //Birthday year of people
float moneySpent[_TOT_PEOPLE]; //Money spent by people
int familyLenght[_TOT_PEOPLE]; //Lenght of each family
int familyIndex = 0; //At which family are we

//Work vars
int occupiedCabins[4]; //Number of occupied cabines
/*
* [0] - Cabin 1
* [1] - Cabin 2
* [2] - Cabin 3
* [3] - Cabin 4
*/

/* No longer needed
int occupiedCabins2[_NUM_CABINE]; //Number of occupied 2 people cabines
int occupiedCabins3[_NUM_CABINE]; //Number of occupied 3 people cabines
int occupiedCabins4[_NUM_CABINE]; //Number of occupied 4 people cabines
*/

int state = 0; //0 = registration 1 = shopping 2 = output
bool isRunning = true; //Is the program running?
bool isFull = false; //Is the ship full?
bool isCabinFull = false; //Are the cabins full?
bool manualNames = true; //Manual or automatic names?

int main()
{
	srand(time(NULL));
	printf("Benvenuto al programma di registrazione\n");
	Sleep(2000L);
	clear();
	do
	{
		switch (state) {
		case 0:
			//Registration
			registration();
			break;
		case 1:
			//Shopping
			shopping();
			break;
		case 2:
			//Output
			output();
			break;
		default:
			return EXIT_FAILURE;
			break;
		}
	} while (isRunning);
	return EXIT_SUCCESS;
}

void registration()
{
	int choice, familyMemb; // Choice = menu user choice, familyMemb = number of family members entered
	bool _isRunning = true; //Is this function running
	bool _isCabinFull[4]; //Local is the cabin full?
	for (int i = 0; i < 4; i++)
	{
		_isCabinFull[i] = false;
	}
	do
	{
		if (isCabinFull == false)
		{
			printf("[0]Registra una famiglia\n");
		}
		printf("[1]Parti\n");
		printf("[2]Inserire i nomi manualmente? (%s)\n", (manualNames) ? "Manuale" : "Automatica");
		scanf("%d", &choice);
		clear();
		if (numPeople != 100 && choice == 0 && isCabinFull == false)
		{
			do
			{
				printf("Quanti membri ci sono?(Posti occupati = %d)\n", numPeople);
				scanf("%d", &familyMemb);
			} while (familyMemb < 0 || familyMemb > 4);
			if (isCabinFull == false)
			{
				if (manualNames)
				{
					for (int i = numFamily; i < familyMemb + numFamily; i++)
					{
						printf("Numero persona(%d)\nInserisci il nome\n", numPeople);
						scanf("%s", &names[i]);
						printf("Inserisci il cognome\n");
						scanf("%s", &surnames[i]);
						printf("Inserisci il giorno di nascita\n");
						scanf("%d", &birthdayDay[i]);
						while (birthdayDay[i] > 31 || birthdayDay[i] < 1)
						{
							printf("Non valido, riinserisci\n");
							scanf("%d", &birthdayDay[i]);
						}
						printf("Inserisci il mese di nascita\n");
						scanf("%d", &birthdayMonth[i]);
						while (birthdayMonth[i] > 12 || birthdayMonth[i] < 1)
						{
							printf("Non valido, riinserisci\n");
							scanf("%d", &birthdayMonth[i]);
						}
						printf("Inserisci l'anno di nascita\n");
						scanf("%d", &birthdayYear[i]);
						while (birthdayYear[i] > 2022 || birthdayYear[i] < 1900)
						{
							printf("Non valido, riinserisci\n");
							scanf("%d", &birthdayYear[i]);
						}
					}
				}

				//Cabin Logic
				switch (familyMemb)
				{
				case 4:
					if (occupiedCabins[3] < 10)
					{
						occupiedCabins[3]++;
						familyLenght[familyIndex] = familyMemb;
						familyIndex++;
						numFamily += familyMemb;
						numPeople += familyMemb;
						break;
					}
					else
					{
						_isCabinFull[3] = true;
						printf("Non ci sono abbastanza cabine per 4 persone\n");
						system("pause");
					}
					break;
				case 3:
					if (occupiedCabins[2] < 10)
					{
						occupiedCabins[2]++;
						familyLenght[familyIndex] = familyMemb;
						familyIndex++;
						numFamily += familyMemb;
						numPeople += familyMemb;
						break;
					}
					else
					{
						_isCabinFull[2] = true;
						printf("Non ci sono abbastanza cabine per 3 persone\n");
						system("pause");
					}
					break;
				case 2:
					if (occupiedCabins[1] < 10)
					{
						occupiedCabins[1]++;
						familyLenght[familyIndex] = familyMemb;
						familyIndex++;
						numFamily += familyMemb;
						numPeople += familyMemb;
						break;
					}
					else
					{
						_isCabinFull[1] = true;
						printf("Non ci sono abbastanza cabine per 2 persone\n");
						system("pause");
					}
					break;
				case 1:
					if (occupiedCabins[0] < 10)
					{
						occupiedCabins[0]++;
						familyLenght[familyIndex] = familyMemb;
						familyIndex++;
						numFamily += familyMemb;
						numPeople += familyMemb;
						break;
					}
					else
					{
						_isCabinFull[0] = true;
						printf("Non ci sono abbastanza cabine per 1 persona\n");
						system("pause");
					}
					break;
				default:
					return EXIT_FAILURE;
					break;
				}

				if (_isCabinFull[3] && _isCabinFull[2] && _isCabinFull[1] && _isCabinFull[0])
				{
					isCabinFull = true;
				}

				clear();
			}
			else
			{
				numPeople -= familyMemb;
				printf("Non ci sono abbastanza posti\n");
				Sleep(1000);
				clear();
			}
		}
		else if (choice == 1)
		{
			printf("Buon viaggio!\n");
			Sleep(1000);
			clear();
			state = 1;
			_isRunning = false;
		}
		else if (choice == 2)
		{
			if (manualNames == true)
			{
				manualNames = false;
			}
			else
			{
				manualNames = true;
			}
		}
		else
		{
			printf("Inserisci una scelta valida\n");
			Sleep(1000);
			clear();
		}
	} while (_isRunning);
}

void shopping()
{
	int choice = 0;
	int personIndex = 0;
	/* ((double)rand() / RAND_MAX) returns a random number between 0 and 1
		* Which gets multiplied by the max value to get a random number between 0 and max*/
		//moneySpent[i] = ((double)rand() / RAND_MAX) * 500;
	do
	{
		clear();
		printf("Scegli il negozio\n");
		printf("[0] McDonald\n");
		printf("[1] Gucci\n");
		printf("[2] Bar\n");
		printf("[3] Esci\n");
		scanf("%d", &choice);
		switch (choice)
		{
		case 0:
			personIndex = findIndex();
			moneySpent[personIndex] += mcDonald();
			break;
		case 1:
			personIndex = findIndex();
			moneySpent[personIndex] += gucciStore();
			break;
		case 2:
			personIndex = findIndex();
			moneySpent[personIndex] += bar();
			break;
		default:
			printf("Inserisci una scelta valida\n");
			Sleep(1000);
			clear();
			break;
		}

	} while (choice != 3);
	for (int i = 0; i < numPeople; i++)
	{
		moneySpent[i] += 199.99f;
	}
	state = 2;
}

float mcDonald()
{
	int choice = 0;
	float total = 0;
	float cosPanini[] = { 6.40f, 8.10f, 8.60f };
	char nomPanini[][20] =
	{
		{"Big Mac"},
		{"Gran Crispy"},
		{"Chicken Asiago"}
	};
	int carrello[3];
	for (int i = 0; i < 3; i++)
	{
		carrello[i] = 0;
	}
	do
	{
		printf("Quale vuoi comprare\n");
		for (int i = 0; i < 3; i++)
		{
			printf("[%d]%s = %.2f $\n", i, nomPanini[i], cosPanini[i]);
		}
		printf("[3] Esci\n");
		scanf("%d", &choice);
		if (choice < 3)
		{
			carrello[choice]++;
			total += cosPanini[choice];
		}
		else if (choice == 3)
		{
			printf("Hai comprato:\n");
			for (int i = 0; i < 3; i++)
			{
				if (carrello[i] != 0)
				{
					printf("%d %s\n", carrello[i], nomPanini[i]);
				}
			}
			printf("Totale: %.2f $\n", total);
			Sleep(1000);
			clear();
			state = 2;
		}
		else
		{
			printf("Inserisci una scelta valida\n");
			Sleep(1000);
			clear();
		}
	} while (choice != 3);
	return total;
}

float gucciStore()
{
	int choice = 0;
	float total = 0;
	float cosGucci[] = { 800.00f, 900.00f, 430.00f };
	char nomGucci[][20] =
	{
		{"T-shirt"},
		{"Pantaloni"},
		{"Scarpe"}
	};
	int carrello[3];
	for (int i = 0; i < 3; i++)
	{
		carrello[i] = 0;
	}
	do
	{
		printf("Quale vuoi comprare\n");
		for (int i = 0; i < 3; i++)
		{
			printf("[%d]%s = %.2f $\n", i, nomGucci[i], cosGucci[i]);
		}
		printf("[3] Esci\n");
		scanf("%d", &choice);
		if (choice < 3)
		{
			carrello[choice]++;
			total += cosGucci[choice];
		}
		else if (choice == 3)
		{
			printf("Hai comprato:\n");
			for (int i = 0; i < 3; i++)
			{
				if (carrello[i] != 0)
				{
					printf("%d %s\n", carrello[i], nomGucci[i]);
				}
			}
			printf("Totale: %.2f $\n", total);
			Sleep(1000);
			clear();
			state = 2;
		}
		else
		{
			printf("Inserisci una scelta valida\n");
			Sleep(1000);
			clear();
		}
	} while (choice != 3);
	return total;
}

float bar()
{
	int choice = 0;
	float total = 0;
	float cosBar[] = { 12.00f, 6.50f, 20.0f };
	char nomBar[][20] =
	{
		{"Cock Tail"},
		{"Whiskey"},
		{"Negroamaro"}
	};
	int carrello[3];
	for (int i = 0; i < 3; i++)
	{
		carrello[i] = 0;
	}
	do
	{
		printf("Quale vuoi comprare\n");
		for (int i = 0; i < 3; i++)
		{
			printf("[%d]%s = %.2f $\n", i, nomBar[i], cosBar[i]);
		}
		printf("[3] Esci\n");
		scanf("%d", &choice);
		if (choice < 3)
		{
			carrello[choice]++;
			total += cosBar[choice];
		}
		else if (choice == 3)
		{
			printf("Hai comprato:\n");
			for (int i = 0; i < 3; i++)
			{
				if (carrello[i] != 0)
				{
					printf("%d %s\n", carrello[i], nomBar[i]);
				}
			}
			printf("Totale: %.2f $\n", total);
			Sleep(1000);
			clear();
			state = 2;
		}
		else
		{
			printf("Inserisci una scelta valida\n");
			Sleep(1000);
			clear();
		}
	} while (choice != 3);
	return total;
}

int findIndex()
{
	char name[20] = ""; //local input name
	char surname[20] = ""; // local input surname
	int index = 0;
	bool isFound = false;

	do
	{
		printf("Inserisci il suo nome\n");
		scanf("%s", name);
		printf("Inserisci il suo cognome\n");
		scanf("%s", surname);
		for (int i = 0; i < numPeople; i++)
		{
			if (strcmp(name, names[i]) == 0 && strcmp(surname, surnames[i]) == 0)
			{
				index = i;
				isFound = true;
				break;
			}
		}
	} while (!isFound);
	return index;
}

void output()
{
	int counter = 0; //At which person are we
	float familySpent = 0.0f; //How much did the family spend
	clear();
	printf("Cabine Occupate\n");
	for (int i = 0; i < 4; i++)
	{
		printf("Cabine da %d occupate : %d\n", i + 1, occupiedCabins[i]);
	}
	for (int i = 0; i < familyIndex; i++)
	{
		printf("\nCabina da %d\n", familyLenght[i]);
		for (int j = 0; j < familyLenght[i]; j++)
		{
			printf("\nPersona numero %d\n", counter + 1);
			printf("Nome: %s\nCognome: %s\n", names[counter], surnames[counter]);
			printf("Giorno di nascita: %d\nMese di nascita: %d\nAnno di nascita: %d\n", birthdayDay[counter], birthdayMonth[counter], birthdayYear[counter]);
			printf("Soldi spesi dal singolo: %.2f\n", moneySpent[counter]);
			familySpent += moneySpent[counter];
			counter++;
		}
		printf("\nSoldi spesi dalla famiglia: %.2f\n", familySpent);
		familySpent = 0.0f;
	}
	isRunning = false;
}

void clear()
{
	system("cls");
}