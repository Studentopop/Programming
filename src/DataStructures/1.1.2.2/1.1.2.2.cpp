//1.1.2.2
#include <iostream>
#include <ctime>
using namespace std;

int main()
{

	float randomDigits[12] = { 12.0, 21.5, 119.2, -80.7, 300.0, 75.5, 81.2, 8.1, 47.3, 31.2,85.3, 100.1 };
	float searchingValue;
	int value = 0;
	cout << "Enter searching value: ";
	cin >> searchingValue;

	cout << "Source array is:" << endl;
	for (int i = 0; i < 12; i++)
	{
		cout << randomDigits[i] << endl;
	}

	for (int i = 0; i < 12; i++)
	{
		if (searchingValue <= randomDigits[i])
		{
			value++;
			cout << endl;
		}
	}
	cout << "Elements of array more than " << searchingValue << " is: " << value;


	return 0;
}