#include <stdlib.h>
#include <stdio.h>
#include <stdbool.h>
#include <time.h>

void clear();

#define MAX_LENGTH 100
#define SQUAD_NAMES_NUM 8

char squadNames[SQUAD_NAMES_NUM][MAX_LENGTH] =
{
	{"Inter"},
	{"Milan"},
	{"Juventus"},
	{"Napoli"},
	{"Roma"},
	{"Lazio"},
	{"Fiorentina"},
	{"Bologna"},
};

int bracket[SQUAD_NAMES_NUM] = {0, 1, 2, 3, 4, 5, 6, 7};

int squadSkill[SQUAD_NAMES_NUM];

int squadsRemaining = SQUAD_NAMES_NUM;

bool isRunning = true;

void pause()
{
	system("pause");
}

void clear()
{
	system("cls");
}

void swap(int* a, int* b) {
	int temp = *a;
	*a = *b;
	*b = temp;
}

void randomize(int arr[], int n) {
	srand(time(NULL));
	int i;
	for (i = n - 1; i > 0; i--) {
		int j = rand() % (i + 1);
		swap(&arr[i], &arr[j]);
	}
}

int match(int numSquad)
{
	int skill[2];
	skill[0] = squadSkill[numSquad];
	skill[1] = squadSkill[numSquad + 1];
	int winner = skill[0] > skill[1] ? numSquad : numSquad + 1;
	return winner;
}

int main()
{
	time_t t;
	srand((unsigned)time(&t));
	int numSquad;
	do
	{
		for (int i = 0; i < SQUAD_NAMES_NUM; i++)
		{
			squadSkill[i] = rand() % 100;
		}
		printf("Abilita` delle squadre\n");
		for (int i = 0; i < SQUAD_NAMES_NUM; i++)
		{
			printf("%s = %d\n", squadNames[i], squadSkill[i]);
		}
		pause();
		clear();
		randomize(bracket, SQUAD_NAMES_NUM);
		for (int i = 0; i < squadsRemaining ; i++)
		{
			for (int j = 0; j < squadsRemaining - 1; j++)
			{
				printf("%s VS %s\n", squadNames[bracket[j]], squadNames[bracket[j + 1]]);
			}
			pause();
			clear();
			for (int j = 0; j < squadsRemaining - 1; j++)
			{
				bracket[j] = match(bracket[j]);
			}
			
			squadsRemaining = squadsRemaining / 2;
		}
	} while (isRunning);
}