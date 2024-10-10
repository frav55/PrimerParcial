#include <stdio.h>
#include <stdlib.h>

int main(void)
{
	int x=0, y=1, z=0, cont;

	printf("Ingrese el n%cmero de elementos para la serie Fibonacci\n", 163);
	int n = 0;
	scanf_s("%d", &n);
	while (n > 47) {
		printf("Ingrese un n%cmero menor a 47\n", 163);
		scanf_s("%d", &n);
	}
	if (n == 47) {
		printf(":O\n");
		printf("\n");
	}
	else
		printf("Se muestran los primeros %d valores de la serie Fibonacci:\n", n);
	printf("0\n1\n", z);

	for (cont = 1; cont <= (n-2); cont = cont + 1)
	{
		z = x + y;
		printf("%d\n", z);
		x = y;
		y = z;
	}

	return 0;
}