#include <stdlib.h>
#include <stdio.h>
#include <stdbool.h>

int main() 
{
	int base;
	int altezza;
	
	int perimetro;
	int area;

	bool cond = true;

	printf("Inserisci la base ");
	scanf("%d", &base);
	printf("Inserisci l'altezza ");
	scanf("%d", &altezza);

	while (cond == true) 
	{
		
		if(base == 0 || altezza == 0)  
		{
			printf("La base o l'altezza non puo' essere 0. Riprova\n");
			printf("Inserisci la base ");
			scanf("%d", &base);
			printf("Inserisci l'altezza ");
			scanf("%d", &altezza);
			
		}
		else 
		{
			cond = false;
		}
		
	}
	perimetro = (base * 2) + (altezza * 2);
	area = base * altezza;
	printf("Il perimetro e' %d \n", perimetro);
	printf("L'area e' %d\n", area);
	system("pause");
}