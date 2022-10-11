#include <iostream>
using namespace std;

int main()
{
    //TODO: размер в переменную+
    int size = 10;
    int* array = new int[size]{ 1, 15, -8, -3, 12, 38, 0, 4, 16, 4 };
    cout << "Array:" << endl;
    for (int i = 0; i < size; i++)
    {
        cout << array[i] << " ";
    }
    cout << endl;
    int searchValue;
    int valueIndex = -1;
    cout << "Enter searching value: ";
    cin >> searchValue;
    cout << endl;
    for (int i = 0; i < size; i++)
    {
        if (array[i] == searchValue)
        {
            valueIndex = i;
        }
    }
    if (valueIndex != -1)
    {
        cout << "Index of searching value " << searchValue << " is: " << valueIndex;
    }
    delete[] array;
}
