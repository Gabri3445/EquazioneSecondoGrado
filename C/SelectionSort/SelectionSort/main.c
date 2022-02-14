#include <stdlib.h>
#include <stdio.h>
#define ARRLENGTH 5

void printArr();
void selecSort();
void swap(int* x, int* y);

int arr[ARRLENGTH] = { 6, 60, 2, 40, 1 };

int main ()
{
  printArr();
  selecSort();
  printArr();
}

void printArr()
{
  for (int i = 0; i < ARRLENGTH; i++)
  {
    printf("%d\t", arr[i]);
  }
  printf("\n");
}

void selecSort()
{
  int min;
  for (int i = 0; i < ARRLENGTH - 1; i++)
  {
      min = i;
    for (int j = i + 1; j < ARRLENGTH; j++)
    {
      if (arr[j] < arr[min])
      {
          min = j;
      }
    }
    swap(&arr[min], &arr[i]);
  }
}

void swap(int* x, int* y)
{
  int temp = *x;
  *x = *y;
  *y = temp;
}
