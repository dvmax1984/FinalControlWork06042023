/* Программа из имеющегося массива строк формирует новый массив из строк, 
 длина которых меньше, либо равна 3 символам.

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

using static Methods;
using static MethodsInput;

initStartApp();

int arrSize = GetNumber("Введите количество строк: ");
string[] array = new string[arrSize];

array = GetString(array);

Console.WriteLine("---[ Исходный массив ]---");
Console.WriteLine(PrintArray(array));

string[] result = GetFromArray(array);

Console.WriteLine("---[  Результат ]---");
Console.WriteLine(PrintArray(result));

