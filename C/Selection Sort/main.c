#include <stdlib.h>
#include <stdio.h>
#define ARRLENGTH 5

void printArr(int arr[]);
void selecSort();
void swap(int* x, int* y);

int arr[ARRLENGTH] = { 6, 60, 2, 40, 1 };

int main ()
{
  printArr(arr);
  selecSort();
  printArr(arr);
}

void printArr(int arr[])
{
  for (int i = 0; i < ARRLENGTH; i++)
  {
    printf("%d", arr[i]);
  }
}

void selecSort()
{
  int minNum = INT_MAX;
  for (int i = 0; i < ARRLENGTH - 1; i++)
  {
    for (int j = 0; j < ARRLENGTH - 1 - 1; j++)
    {
      if (arr[j] < minNum)
      {
        minNum = j;
      }
    }
    
  }
}

void swap(int* x, int* y)
{
  temp = *x;
  *x = *y;
  *y = temp;
}
