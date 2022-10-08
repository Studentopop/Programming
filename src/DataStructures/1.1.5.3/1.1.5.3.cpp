#include<iostream>
using namespace std;

void main()
{
	setlocale(LC_ALL, "RUS");

	int n;
	cout << "¬ведите положительное число ";
	cin >> n;
	char* Array = new char[n];
	for (int i = 0; i < n; i++)
	{
		cin >> Array[i];
		cout << '\n';
	}
	for (int i = 0; i < n; i++)
	{
		cout << Array[i];
		cout << "; ";
	}
	delete[] Array;
}