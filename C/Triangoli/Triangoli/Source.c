#include <stdio.h>
#include <stdlib.h>
#define N 3

int input();
int classification(int lati[]);
void clear();

int main()
{
    int lati[N];
    for (int i = 0; i < N; i++)
    {
        scanf("%d", &lati[i]);
    }

    switch (classification(lati))
    {
    case 0:
        printf("Scaleno");
        break;
    case 1:
        printf("Isoscele");
        break;
    case 2:
        printf("Equilatero");
        break;
    default:
        printf("Errore");
        exit(1);
        break;
    }
}

int classification(int lati[])
{
    if (lati[0] == lati[1] && lati[1] == lati[2])
        return 2;
    else if (lati[0] == lati[1] || lati[0] == lati[2] || lati[1] == lati[2])
        return 1;
    else
        return 0;
}

void clear()
{
    system("cls");
    return;
}
