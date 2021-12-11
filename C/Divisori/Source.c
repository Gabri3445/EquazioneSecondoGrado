#include <stdlib.h>
#include <stdio.h>
#include <stdbool.h>

void main()
{
	int num = 1;
	do
	{
		printf("Scrivi un numero maggiore a zero ");
		scanf("%d", &num);
		divisori(num);
	} while (num > 0);
	printf("Hai inserito zero o un numero minore a zero\n");
	system("pause");
}

int divisori(int num)
{
	int numDiv, numCount;
	numDiv = num;
	while (numDiv > 0)
		{
			numCount = num % numDiv;
			if (numCount == 0)
			{
				printf("\n%d\n", numDiv);
			}
			numDiv--;
		}
	printf("\n");
	return 0;
}