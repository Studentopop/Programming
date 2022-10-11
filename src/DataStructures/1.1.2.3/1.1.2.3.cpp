
#include <iostream>
#include <cstdlib>

using namespace std;
int main()
{
    int size = 8;
    char* array = new char[size];
    cout << "Enter array of 8 chars: ";
    //TODO: code style+
    for (int i = 0; i < size; i++)
    {
        cin >> array[i];
    }

    for (int i = 0; i < 8; i++)
    {
        cout << "m[" << i << "]= " << array[i] << "\n";
    }
    cout << "Your array is: ";

    for (int n = 0; n < 8; n++)
    {
        cout << array[n] << ' ';
    }
    cout << '\n';
    cout << "All letters in your array: ";
    //TODO: через переменную+
    for (int l = 0; l < size; l++)
    {
        if (array[l] >= 'a' and array[l] <= 'z')
        {
            cout << array[l] << ' ';
        }
    }
    return 0;
}