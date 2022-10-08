//1.1.3.1
#include <iostream>
#include <ctime>
using namespace std;


double GetPower(double base, int exponent) {
	return pow(base, exponent);

}

int main()
{
	setlocale(LC_ALL, "RUS");

	double base;
	int exponent;
	cout << "¬ведите значение base" << endl;
	cin >> base;
	cout << "¬ведите значение exponent" << endl;
	cin >> exponent;


	cout << GetPower(base, exponent);
}