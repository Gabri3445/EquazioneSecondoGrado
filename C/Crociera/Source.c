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
int familyLenght[_TOT_PEOPLE];
int familyIndex = 0;

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
			//Travelling
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
	int choice, familyMemb;
	bool _isRunning = true; //Is this running
	bool _isCabinFull[4];
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
		scanf("%d", &choice);
		clear();
		if (numPeople != 100 && choice == 0)
		{
			do
			{
				printf("Quanti membri ci sono?(Posti occupati = %d)\n", numPeople);
				scanf("%d", &familyMemb);
			} while (familyMemb < 0 || familyMemb > 4);
			numPeople += familyMemb;
			if (isCabinFull == false)
			{
				familyLenght[familyIndex] = familyMemb;
				familyIndex++;
				for (int i = numFamily; i < familyMemb + numFamily; i++)
				{
					printf("Membro della famiglia(%d)\nInserisci il nome\n", numPeople);
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

				numFamily += familyMemb;


				//Cabin Logic
				switch (familyMemb)
				{
				case 4:
					if (occupiedCabins[3] <= 10)
					{
						occupiedCabins[3]++;
						break;
					}
					else
					{
						_isCabinFull[3] = true;
						printf("Non ci sono abbastanza cabine per 4 persone\n");
					}
					break;
				case 3:
					if (occupiedCabins[2] <= 10)
					{
						occupiedCabins[2]++;
						break;
					}
					else
					{
						_isCabinFull[2] = true;
						printf("Non ci sono abbastanza cabine per 3 persone\n");
					}
					break;
				case 2:
					if (occupiedCabins[1] <= 10)
					{
						occupiedCabins[1]++;
						break;
					}
					else
					{
						_isCabinFull[1] = true;
						printf("Non ci sono abbastanza cabine per 2 persone\n");
					}
					break;
				case 1:
					if (occupiedCabins[0] <= 10)
					{
						occupiedCabins[0]++;
						break;
					}
					else
					{
						_isCabinFull[0] = true;
						printf("Non ci sono abbastanza cabine per 1 persona\n");
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
	for (int i = 0; i < numPeople; i++)
	{
		moneySpent[i] = ((double)rand() / RAND_MAX) * 500;
	}
	state = 2;
}

void output()
{
	int counter = 0;
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
			printf("Soldi spesi: %.2f\n", moneySpent[counter]);
			counter++;
		}
	}



	/*
	for (int i = 0; i < numPeople; i++)
	{
		printf("\n\nPersona numero %d\n", i + 1);
		printf("Nome: %s\nCognome: %s\n", names[i], surnames[i]);
		printf("Giorno di nascita: %d\nMese di nascita: %d\nAnno di nascita: %d\n", birthdayDay[i], birthdayMonth[i], birthdayYear[i]);
		printf("Soldi spesi: %.2f", moneySpent[i]);
	}
	*/
	isRunning = false;
}

void clear()
{
	system("cls");
}