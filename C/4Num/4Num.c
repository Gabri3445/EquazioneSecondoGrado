#include <stdio.h>

int
main ()
{
  int a, b, c, d;

  scanf ("%d", &a);
  scanf ("%d", &b);
  scanf ("%d", &c);
  scanf ("%d", &d);

  if (a > b)
    swap (&a, &b);
  if (c > d)
    swap (&c, &d);
  if (a > c)
    swap (&a, &c);
  if (b > d)
    swap (&b, &d);
  if (b > c)
    swap (&b, &c);

  printf ("\n%d", a);
  printf ("\n%d", b);
  printf ("\n%d", c);
  printf ("\n%d", d);
}

int
swap (int *x, int *y)
{
  int temp;
  temp = *x;
  *x = *y;
  *y = temp;

}
