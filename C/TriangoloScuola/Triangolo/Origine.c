#include <stdlib.h>
#include <stdio.h>
#include <stdbool.h>
#define N 3

int class(int lati[]);

int main()
{
	int lati[N];
	bool check = true;
	do
	{
		
		for (int i = 0; i < N; i++)
		{
			scanf("%d", &lati[i]);
		}
		if (lati[0] < lati[1] + lati[2] && lati[1] < lati[0] + lati[2] && lati[2] < lati[0] + lati[1])
			check = false;
		else
			printf("Hai inserito un triangolo non valido\n");
	} while (check);
	switch (class(lati))
	{
	case 0: printf("Equilatero");
		break;
	case 1: printf("Isoscele");
		break;
	case 2: printf("Scaleno");
	default:
		break;
	}
}


int class(int lati[])
{
	if (lati[0] == lati[1] && lati[0] == lati[2])
	{
		return 0;
	}
	else if (lati[0] == lati[1] || lati[0] == lati[2] || lati[1] == lati[2])
	{
		return 1;
	}
	else
	{
		return 2;
	}
}