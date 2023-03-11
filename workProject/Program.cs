/* Программа, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести 
с клавиатуры, либо задать на старте выполнения алгоритма.
*/

Console.Clear();

Console.Write("Введите элементы массива любой длины через пробел: ");

string[] GetArrayFromString(string enteredString)
{
    string[] arrayStrings = enteredString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return arrayStrings;
}

string[] fullCharStrArr = GetArrayFromString(Console.ReadLine());
// string[] fullCharStrArr = new string[] { "333", "_goof_", "mir", "0?)", "__", "+trainer", "444" };


string[] FullToThreeCharStrArr(string[] fullChar)
{
    int size = 0;
    for (int i = 0; i < fullChar.Length; i++)
    {
        if (fullChar[i].Length <= 3)
        {
            size += 1;
        }
    }
    string[] threeChar = new string[size];
    int j = 0;
    for (int i = 0; i < fullChar.Length; i++)
    {
        if (fullChar[i].Length <= 3)
        {
            threeChar[j] = fullChar[i];
            j++;
        }
    }
    return threeChar;
}

string[] threeCharStrArr = FullToThreeCharStrArr(fullCharStrArr);

void writeArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\"");
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

writeArray(fullCharStrArr);
Console.Write(" -> ");
writeArray(threeCharStrArr);
