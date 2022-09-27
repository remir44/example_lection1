// int Method() // вывести нынешний год
// {
//     return DateTime.Now.Year;
// }
// int year = Method();
// Console.WriteLine(year);

// string Method2(int count, string text) // вывести несколько склеенных слов/строк
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result+=text;
//     }
//     return result;
// }
// string res = Method2(4,"qwerty");
// Console.WriteLine(res);

// for (int i = 2; i <= 9; i++) // вывести таблицу умножения
// {
//     for (int j = 2; j <= 9; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// Работа с текстом.
// Дан текст, в котором нужно заменить все пробелы черточками,
// маленькие "к" заменить большими "К",
// а маленькие "с" заменить большими "С".

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде, "
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result += $"{newValue}";
//         else result += $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);

// Console.WriteLine();

// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);

// Console.WriteLine();

// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);

// Работа с сортировкой массива

int[] arr = { 3, 4, 7, 6, 13, 8, 9, 1, -5, 4, 4 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPos = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPos]) minPos = j;
        }
        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);