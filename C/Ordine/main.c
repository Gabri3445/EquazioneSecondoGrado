#include <stdio.h>

int main()
{
    int num0;
    int num1;
    scanf("%d", &num0);
    printf("\n");
    scanf("%d", &num1);
    
    if(num0 > num1)
    {
        printf("\n%d,%d", num1, num0);
    }
    else
    {
        printf("\n%d,%d", num0, num1);
    }
}
