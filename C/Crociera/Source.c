#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <stdbool.h>

//Function prototype
void registration();
void travelling();
void output();
void clear();

//Constants
#define _TOT_PEOPLE 100
#define _NUM_CABINE 10


//Main input vars
int numFamily[_TOT_PEOPLE];
char names[_TOT_PEOPLE];
char surnames[_TOT_PEOPLE];
int birthday[_TOT_PEOPLE][_TOT_PEOPLE][_TOT_PEOPLE]; //day, month, year


//Work vars
int occupiedCabine4[_NUM_CABINE];
int occupiedCabine3[_NUM_CABINE];
int occupiedCabine2[_NUM_CABINE];
int occupiedCabine1[_NUM_CABINE];
int state = 0; //0 = registration 1 = travelling 2 = output

int main()
{
	
	switch (state)
	{
	case 0:
		//Registration
		registration();
		break;
	case 1:
		//Travelling
		travelling();
		break;
	case 2:
		//Output
		output();
		break;
	default:
		return EXIT_FAILURE;
		break;
	}
	return EXIT_SUCCESS;
}

void registration()
{
	
}

void travelling()
{
	
}

void output()
{
	
}

void clear()
{
	system("clear");
}