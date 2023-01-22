
public static class animation
{

    private static int startEndRoad = 1, length;
    private static bool toggle;

    private static void drawing(int length)
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);
        Console.Write("|");

        Console.SetCursorPosition(length + 1, 0);
        Console.Write("|");
    }
    public static void outputDrawing(string symbol, int length)
    {
        if (symbol == null) { symbol = "#"; }
        if (symbol.Length >= 2) { symbol.Substring(1); }
        while (true)
        {
            drawing(length);
            Console.SetCursorPosition(startEndRoad++, 0);
            Console.Write(symbol);
            if (startEndRoad == length)
            {
                toggle = true;
                while (toggle)
                {
                    drawing(length);
                    Console.SetCursorPosition(startEndRoad--, 0);
                    Console.Write(symbol);
                    System.Threading.Thread.Sleep(200);
                    if (startEndRoad == 1)
                    {
                        toggle = false;
                        break;
                    }
                }
            }
            System.Threading.Thread.Sleep(200);
        }
    }

}
class Program
{
    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        Console.Write("длина: ");
        int length = Convert.ToInt32(Console.ReadLine());
        Console.Write("символ: ");
        string symbol = Console.ReadLine();
        animation.outputDrawing(symbol, length);
    }
}
