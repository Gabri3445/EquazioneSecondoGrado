#include <stdio.h>

int main()
{
    int temp;
    printf("Inserisci la temperatura ");
    scanf("%d", &temp);
    if(temp >= 30)
    {
        printf("Fa molto caldo");
    }
    else if(temp >= 20)
    {
        printf("Fa caldo");
    }
    else if(temp >= 10)
    {
        printf("Fa freddo");
    }
    else 
    {
        printf("Fa molto freddo");
    }
}
