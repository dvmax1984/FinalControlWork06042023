public static class Methods
{
    /// <summary>
    /// Метод PrintArray печать массива
    /// </summary>
    /// <param name="result">Аргументы метода PrintArray</param>
    public static string PrintArray(string[] result)
    {
        string res = string.Empty;

        for (int i = 0; i < result.Length; i++)
        {
            res = res + result[i] + "\n";
            //Console.WriteLine(result[i]);
        }
        return res;
    }

    /// <summary>
    /// Метод GetFromArray возвращает строки длинной до 3 символов вкл.
    /// </summary>
    /// <param name="array">Аргументы метода GetFromArray</param>
    public static string[] GetFromArray(string[] array)
    {
        string[] result = new string[array.Length];

        for (int m = 0, n = 0; m < array.Length; m++)
        {
            if (array[m].Length <= 3)
            {
                result[n] = array[m].ToString();
                n++;
            }

            if (m == array.Length - 1) Array.Resize(ref result, n);
            /*  Второй вариант:
                подсчитать число n = кол-во строк с длиной до 3х символов.
                и создать массив result длинной n, а затем заполнить его */
        }
        return result;
    }
}
