#include <stdlib.h>
#include <stdio.h>
#include <math.h>

int main(){
    int valueA = 0;
    int valueB = 0;
    int valueC = 0;
    int delta = 0;
    int x1 = 0;
    int x2 = 0;

    printf("Inserisci il primo termine ");
    scanf("%d", &valueA);

    printf("Inserisci il secondo termine ");
    scanf("%d", &valueB);

    printf("Inserisci il terzo termine ");
    scanf("%d", &valueC);

    delta = pow(valueB, 2) - 4 * valueA * valueC;
    printf("Il delta e: %d\n", delta);

    if(delta > 0){
        x1 = (-valueB + sqrt(delta)) / (2 * valueA);
        x2 = (-valueB - sqrt(delta)) / (2 * valueA);
        printf("x1 = %d\n x2 = %d\n", x1, x2);
        system("pause");
    }

    else{
        printf("Il discriminante e negativo e i risultati non sono reali \n");
        system("pause");
    }
}