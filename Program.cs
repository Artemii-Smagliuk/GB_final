// Написать программу, которая из имещегося массива строк формирует массив из строк, 
// длина которых меньше либо равна трём символам. 

int EnterData(string text) 
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

string[] FillArray(int n) 
{
    string[] array = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите {i+1}-й элемент : ");
            array[i] = Console.ReadLine();
        }
    return array;
}

int CountStringArray(string[] array) 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<4) count++;
    }
    return count;
}

string[] ThreeSymbbolsArray(int size, string[] array)
{
    string[] finalArray = new string[size];
    int j=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<4) 
        {
            finalArray[j]=array[i];
            j++;
        }
    }
    return finalArray;
}

int arrSize = EnterData("Введите размер массива: ");
string[] array = FillArray(arrSize);
int numOfThreeSymbols = CountStringArray(array);
string[] resultArray = ThreeSymbbolsArray(numOfThreeSymbols, array);
Console.WriteLine();
for (int i = 0; i < numOfThreeSymbols; i++)
{
    Console.WriteLine(resultArray[i]);    
}