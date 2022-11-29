// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо 
// равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении 
//не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] GenerateArray(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент массива:");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

void PrintArray(string[] arrayToPrint, string name)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"------------{name} -----------");
    Console.ResetColor();
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write($"\"{arrayToPrint[i]}\"");      
        if(i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
    Console.WriteLine();
}

string[] GetResultArray(string[] array)
{		
	string[] result = new string[array.Length];
	int count = 0;	
	for (int i = 0; i < array.Length; i++)
	{
		if(array[i].Length <= 3)
		{
			result[count] = array[i];
			count++;
		}
	}
	Array.Resize(ref result, count);
	return result;
}

Console.WriteLine();
Console.Write("Введите количество элементов в массиве: ");
int lenght = Convert.ToInt32(Console.ReadLine());
if(lenght > 0)
{
    Console.WriteLine();
    string[] currentArray = GenerateArray(lenght);
    PrintArray(currentArray, "Исходный массив");
    string[] finalArray = GetResultArray(currentArray);
    PrintArray(finalArray , "Полученный массив");
}
else Console.WriteLine("Задача не имеет решения");