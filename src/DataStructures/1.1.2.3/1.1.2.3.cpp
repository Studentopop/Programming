
#include <iostream>
#include <cstdlib>

using namespace std;
int main()
{
    int size = 8;
    char* mas = new char[size];
    cout << "Enter array of 8 chars: ";
    for (int i = 0; i < size; i++)
        cin >> mas[i];
    for (int i = 0; i < 8; i++)
    {
        cout << "m[" << i << "]= " << mas[i] << "\n";
    }
    cout << "Your array is: ";

    for (int n = 0; n < 8; n++)
    {
        cout << mas[n] << ' ';
    }
    cout << '\n';
    cout << "All letters in your array: ";
    for (int l = 0; l < 8; l++)
    {
        if (mas[l] >= 'a' and mas[l] <= 'z')
        {
            cout << mas[l] << ' ';
        }
    }
    return 0;
}