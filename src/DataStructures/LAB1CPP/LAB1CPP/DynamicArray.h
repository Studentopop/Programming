struct Arr
{
	int capacity;
	int length;
	int* array;
};

void initMassiv(Arr* arr);
void showMassiv(Arr* arr);
void Add(Arr* arr);
void addEnd(Arr* arr);
void addBegin(Arr* arr);
void afterIndex(Arr* arr);
void bubbleSort(Arr* arr);
void linearSearch(Arr* arr);
void BinarySearch(Arr* arr);
void DelByIndex(Arr* arr);