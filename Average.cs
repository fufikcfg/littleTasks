
string[] b = new string[5] { "Вася m", "Петя xxl", "Аня Шишкина", "Даша Пупкина", "Вася Пупкин" };

Dictionary<string, List<int>> AuthorDict = new Dictionary<string, List<int>>()
{
    [b[0]] = new List<int> { 2, 3, 3, 4, 5 },
    [b[1]] = new List<int> { 5, 3, 5, 4 },
    [b[2]] = new List<int> { 3, 3, 4, 3, 4 },
    [b[3]] = new List<int> { 2, 3, 4, 3 },
    [b[4]] = new List<int> { 5, 3, 4 }
};
foreach (var item in AuthorDict)
    Console.WriteLine($"{item.Key}: {String.Join(", ", item.Value)}" + $" Среднее значение: {item.Value.Average()}");

int skipper = 0;

foreach (List<int> item in AuthorDict.Values)
{
    Console.WriteLine(String.Join(" ", b[skipper]));
    foreach (int evaluations in item)
    {
        Console.WriteLine(evaluations + " - " + item.Where(x => x == evaluations).Count() + " раз");
    }
    skipper++;
    Console.WriteLine();
}

