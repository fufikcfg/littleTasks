

Console.Write("Кол - во значений:\t");
int elementList = Convert.ToInt32(Console.ReadLine());
List<int> listNumbers = new List<int>(elementList);

for (int i = 0; i < elementList; i++)
{
    Console.Write($"Значение {i + 1}:\t");
    listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
}
void sortingOutput(List<int> listNumbers)
{
    for (int i = 0; i < listNumbers.Count; i++)
    {
        for (int j = 1; j <= listNumbers[i]; j++)
        {
            Console.Write("#");
        }
        Console.WriteLine();
    }
}

Console.Write("1 = Уменьшение\n2 = Возрастание\n3 = Не менять\nВариант: ");


switch (Console.ReadLine())
{
    case "1":
        listNumbers.Sort();
        listNumbers.Reverse();
        sortingOutput(listNumbers);
        break;
    case "2":
        listNumbers.Sort();
        sortingOutput(listNumbers);
        break;
    case "3":
        sortingOutput(listNumbers);
        break;
    default:
        break;
}