/* Программу, которая из имеющегося массива строк формирует новый массив из строк, 
 длина которых меньше, либо равна 3 символам.

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

Console.WriteLine("Hello, World!");

string[] array = {"Hello", "2", "world"};

int n = 0;

for (int m=0; m < array.Length; m++)
{
    string[] result;
    
    //LastIndexOf: находит индекс последнего вхождения символа или подстроки в строке
    
    if (array[m].Length <= 3)
    {
        result[n] = array[m];
        n = n + 1;
    }
}

