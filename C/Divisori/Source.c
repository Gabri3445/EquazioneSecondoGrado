#include <stdlib.h>
#include <stdio.h>
#include <stdbool.h>

void main()
{
	int num, numDiv, numCount;
	bool cond = true;
	do
	{
		printf("Scrivi un numero maggiore a zero ");
		scanf("%d", &num);
		if (num > 0)
		{
			numDiv = num;
				while (numDiv > 0)
				{
					numCount = num % numDiv;
					if (numCount == 0)
					{
						printf("\n%d\n", numDiv);
					}
					numDiv = numDiv--;
				}
		}		
		else cond = false;
		printf("\n");
	} while (cond == true);
	printf("Hai inserito un numero uguale o minore a zero\n");
	system("pause");
}