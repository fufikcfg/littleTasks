Console.CursorVisible = false;

int x = 1, y = 0;

Console.Write("длина: ");
double length = Convert.ToInt32(Console.ReadLine());
Console.Write("кол - во ячеек: ");
double cells = Convert.ToInt32(Console.ReadLine());
Console.Write("символ: ");
string symbol = Console.ReadLine();
symbol = symbol.Substring(1, symbol.Length - 1);
double d = Math.Round(Math.Sqrt(Math.Pow(length, 2) + Math.Pow(cells, 2)));
d = d / 2;
if(d % 2 == 0)
{
    Console.WriteLine("error. диагональ прямоугольника должна быть четной");
    {
        Console.ReadLine();
    }
}
void margin()
{
    System.Threading.Thread.Sleep(200);
    Console.Clear();
    Console.SetCursorPosition(0, 0);
    for (int j = 1; j <= cells; j++)
    {
        Console.Write("|");
        for (int i = 1; i <= length; i++)
        {
            Console.Write(" ");
        }
        Console.Write("|\n");
    }
    if (x == 0) { x = 1; }
}
void movingСharacter()
{
    while (true)
    {
        for (int i = 0; i <= d; i++)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
            margin();
            Console.SetCursorPosition(x++, y++);
            Console.Write(symbol);
            margin();
        }

        for (; ; )
        {
            Console.SetCursorPosition(x--, y);
            Console.Write(symbol);
            margin();
            if (x == 1) { break; }
        }

        for (int i = 0; i <= d; i++)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
            margin();
            Console.SetCursorPosition(x++, y--);
            Console.Write(symbol);
            margin();
        }

        for (; ; )
        {
            Console.SetCursorPosition(x--, y);
            Console.Write(symbol);
            margin();
            if (x == 1) { break; }
        }
    }
}

margin();
movingСharacter();