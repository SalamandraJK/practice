//ControlWork

// Метод, для приема данных
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Вводим метод, который будет выводить одномерный массив, содержащий строки
void Print1DArry(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"[{array[i]}]\t");
    }

}

// Вводим метод, который находит в массиве строки,
// длина которых не больше введенного значения,
// возвращает массив из полученных строк
string [] GetNewArray(string [] arry, int count)
{   
    string [] result = new string [0];
    for (int i = 0; i < arry.Length; i++)
    {
        if (arry[i].Length<=count)
        {
            result = result.Concat(new string[] { arry[i] }).ToArray();
        }
    }
    return result;    
}

string [] Main(int NumLenght)
{
    // Объявляем массив с заданной длинной строк
    string[] strs = new string[NumLenght];

    for (int i = 0; i < NumLenght; i++)
        {
             //Заполняем массив
            Console.Write("Введите строку №{0}:\r\n    ", i + 1);
            strs[i] = Console.ReadLine();
        }

        Console.WriteLine("Вы ввели следующие строки:");

        for (int i = 0; i < NumLenght; i++)
        {
            Console.WriteLine(strs[i]);
        }
    return strs;
}

