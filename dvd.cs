
public static class dvdAnimation
{
    private static int x = 1, y = 0;
    public static void margin(double length, double cells)
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
    public static void movingСharacter(string symbol, double length, double cells)
    {
        if (symbol.Length > 1) { symbol = symbol.Substring(1, symbol.Length - 1); }
        double diagonal = (cells + length - 3) / 2;
        if (length != cells)
        {
            Console.WriteLine("error. надо прямоугольник");
            {
                Console.ReadLine();
            }
        }
        while (true)
        {
            for (int i = 0; i <= diagonal; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(symbol);
                margin(length, cells);
                Console.SetCursorPosition(x++, y++);
                Console.Write(symbol);
                margin(length, cells);
            }

            for (; ; )
            {
                Console.SetCursorPosition(x--, y);
                Console.Write(symbol);
                margin(length, cells);
                if (x == 1) { break; }
            }

            for (int i = 0; i <= diagonal; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(symbol);
                margin(length, cells);
                Console.SetCursorPosition(x++, y--);
                Console.Write(symbol);
                margin(length, cells);
            }

            for (; ; )
            {
                Console.SetCursorPosition(x--, y);
                Console.Write(symbol);
                margin(length, cells);
                if (x == 1) { break; }
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        Console.Write("длина: ");
        double length = Convert.ToInt32(Console.ReadLine());
        Console.Write("кол - во ячеек: ");
        double cells = Convert.ToInt32(Console.ReadLine());
        Console.Write("символ: ");
        string symbol = Console.ReadLine();
        dvdAnimation.movingСharacter(symbol, length, cells);
    }
}
