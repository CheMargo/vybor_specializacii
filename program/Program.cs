/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello", “2", “world", “:-)"] → [“2", “:-)"]
[“1234", “1567", “-2", “computer science"] → [“-2"]
[“Russia", “Denmark", “Kazan"] → []
*/

string[] inputArray = { "Hello", "2", "world", ":-)" };

string[] taskFunction(string[] inputArray)
{
    int stringNumber = 0;
    foreach (string element in inputArray)
    {
        if (element.Length < 4)
        {
            stringNumber++;
        }
    }
    string[] result = new string[stringNumber];
    int counter = 0;
    foreach (string element in inputArray)
    {
        if (element.Length < 4)
        {
            result[counter] = element;
            counter++;
        }
    }
    return result;
}

string[] answer = taskFunction(inputArray);
Console.WriteLine($"{answer.Length}");
foreach (string element in answer)
{
    Console.WriteLine($"\"{element}\"");
}