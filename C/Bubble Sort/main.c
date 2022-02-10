#include <stdlib.h>
#include <stdio.h>
#define N 5

void printArr(int arr[], int size);
void bubbleSort(int arr[], int size);
void swap(int* x, int* y);

int main()
{
	int arr[N] = { 64, 34, 25, 12, 22 };
	bubbleSort(arr, N);
	system("pause");
}

void printArr(int arr[], int size)
{
	for (int i = 0; i < size; i++)
	{
		printf("%d\t", arr[i]);
	}
	printf("\n");
}
void bubbleSort(int arr[], int size)
{
	int i, j;

	for (i = 0; i < size - 1; i++)
	{
		for (j = 0; j < size - i - 1; j++)
		{
			if (arr[j] > arr[j + 1])
			{
				swap(&arr[j], &arr[j + 1]);
				printArr(arr, N);
			}
		}
		printf("\n");
	}
}
void swap(int* x, int* y)
{
	int temp;
	temp = *x;
	*x = *y;
	*y = temp;
}
