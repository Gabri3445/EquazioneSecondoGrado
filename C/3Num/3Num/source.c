#include <stdlib.h>
#include <stdio.h>

void main()
{
	int num0, num1, num2;
	int numOrd0, numOrd1, numOrd2;
	printf("Inserisci il primo numero ");
	scanf("%d", &num0);
	printf("\nInserisci il secondo numero ");
	scanf("%d", &num1);
	printf("\nInserisci il terzo numero ");
	scanf("%d", &num2);

	if (num0 > num1 || num0 > num2)
	{
		numOrd2 = num0;
		if (num1 > num2)
		{
			numOrd1 = num1;
			numOrd0 = num2;
		}
		else
		{
			numOrd1 = num2;
			numOrd0 = num1;
		}
	}
	else //AAAAAAAAAAAA
	{
		numOrd0 = num0;
		if (num1 > num2)
		{
			numOrd1 = num2;
			numOrd2 = num1;
		}
		else
		{
			numOrd1 = num1;
			numOrd2 = num2;
		}
	}
	printf("\nPrimo numero: %d\n", numOrd0);
	printf("Secondo numero: %d\n", numOrd1);
	printf("Terzo numero: %d\n", numOrd2);
}