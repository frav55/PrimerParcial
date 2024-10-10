#include <math.h>
#include <stdio.h>
#include <stdlib.h>
int niter = 0,i=0;
double pi_leibniz(double pi) {
	///printf("%d\n", i);
	if (i < niter) {
		pi = pi+(pow((-1.0), i)/((2*i)+1));
		i++;
		//printf("%f\n", pi);
		return pi_leibniz(pi);
	}else{
		return pi*4;
	}
}
void main() {
	double pi = 0.0,res=0;
	printf("Ingresa el n%cmero de iteraciones ", 163);
	scanf_s("%d", &niter);
	res=pi_leibniz(pi);
	printf("El valor de pi calculado es = %f \n", res);
}