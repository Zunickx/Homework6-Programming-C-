// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.WriteLine("Введите числа через запятую: ");

int[] numArray = Array.ConvertAll(Console.ReadLine()!.Split(','), int.Parse); // строку положили в массив, 
// разбили строку на подстроки при помощи метода Split (каждый символ в строке стал подстрокой, при этом запятая стала разделителем на подстроки), 
// заменили строчные значения на числовые при помощи int.Parse
Console.WriteLine(numArray);

void Enumeration()
{
    int count = 0;

    for(int i = 0; i < numArray.Length; i++)
    {
        if(numArray[i] > 0)
        count++;
    }

    Console.WriteLine($"Количество элементов больше 0: {count}");
}

Enumeration();