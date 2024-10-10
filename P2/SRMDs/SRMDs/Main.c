#include <stdio.h>
#include <stdlib.h>

int suma(int a, int b) {
	return a + b;
}
int resta(int a, int b) {
	return a - b;
}
int multip(int a, int b) {
	return a * b;
}
float divis(int a, int b) {
	return a / b;
}
void main(){
	int numa = 0, numb = 0;
	float div = .0;
	printf("Ingresa un n%cmero ",163);
	scanf_s("%d", &numa);
	printf("Ingresa un segundo n%cmero ",163);
	scanf_s("%d", &numb);
	printf("La suma de estos n%cmeros es = %d \n",163, suma(numa, numb));
	printf("La resta del primero con el segundo es = %d \n", resta(numa, numb));
	printf("La multiplicaci%cn de estos n%cmeros es = %d \n",162, 163, multip(numa, numb));
	printf("La divisi%cn del primero entre el segundo es = %f \n",162, divis(numa, numb));
}