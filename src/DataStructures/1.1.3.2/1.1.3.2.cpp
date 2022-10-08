#include <iostream>
#include <ctime>
using namespace std;

int result;


double GetPower(double base, int exponent) {
	result = pow(base, exponent);
	return result;

}

int main()
{
	setlocale(LC_ALL, "RUS");

	int numberOfCalls;
	cout << "¬ведите сколько хотите получить значений" << endl;
	cin >> numberOfCalls;



	for (int i = 0; i < numberOfCalls; i++)
	{
		double base;
		cout << "¬ведите значение base" << endl;
		cin >> base;

		int exponent;
		cout << "¬ведите значение exponent" << endl;
		cin >> exponent;

		GetPower(base, exponent);

		cout << base << " ^ " << exponent << " = " << result << endl;
	}


}