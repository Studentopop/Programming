#include <iostream>

using namespace std;
void Breakpoints()
{
	double add = 1.0;
	double sum = 0.0;
	for (int i = 0; i < 10; i++)
	{
		sum += add * i;
		add *= 1.1;
	}
	cout << "Total sum is " << sum << endl;
}
int main()
{
	Breakpoints();
	//<summary>
	// sum ��������� �������� ���:
	// i = 0	sum = 0.0000000000000000
	// i = 1	sum = 0.0000000000000000 
	// i = 2	sum = 1.1000000000000001 
	// i = 3	sum = 3.5200000000000005 
	// i = 4	sum = 7.5130000000000017 
	// i = 5	sum = 13.369400000000004 
	// i = 6	sum = 21.421950000000010 
	// i = 7	sum = 32.051316000000014
	// i = 8	sum = 45.692335700000022 
	// i = 9	sum = 62.841046180000035 
	//<summary>
}
