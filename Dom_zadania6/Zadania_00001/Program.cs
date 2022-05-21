// Задача 1
// Составить частотный словарь элементов двумерного массива

// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// Пример:
// Есть набор данных

// { 1, 9, 9, 0, 2, 8, 0, 9 }
// частотный массив может быть представлен так:

// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза



Console.Write("Ведите символы через пробел:");
// Console.Write("string: ");
string str = Console.ReadLine();

char[] delim = { ' ', ',', '.', ':', ';', '!', '?' };
string[] tokens = str.Split(delim, StringSplitOptions.RemoveEmptyEntries);

Dictionary<string, int> dictionary = new Dictionary<string, int>();
foreach (string token in tokens)
{
    if (dictionary.ContainsKey(token))
        ++dictionary[token];
    else
        dictionary[token] = 1;
}

foreach (KeyValuePair<string, int> pair in dictionary)
    Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
