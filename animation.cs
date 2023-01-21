Console.CursorVisible = false;
Console.Write("длина: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("символ: ");
string symbol = Console.ReadLine();
int startEndRoad = 1;
bool toggle; 
if(symbol.Length >= 2)
{
    symbol.Substring(1);
}
void drawing()
{
    Console.Clear();
    Console.SetCursorPosition(0, 0);
    Console.Write("|");

    Console.SetCursorPosition(length + 1, 0);
    Console.Write("|");
}
while (true)
{
    drawing();
    Console.SetCursorPosition(startEndRoad++, 0);
    Console.Write(symbol);
    if(startEndRoad == length)
    {
        toggle = true;
        while (toggle)
        {
            drawing();
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