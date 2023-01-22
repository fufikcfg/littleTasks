public static class Palindrom
{
    public static void generatePalindrom(int num_letters, char[] letters, string word = "")
    {
        Random rand = new Random();
        int num_letters2 = num_letters / 2 + 1;
        int num_letters3 = num_letters / 2;

        if (num_letters < 2) { Console.Write("Количество букв < 2"); }

        for (int j = 1; j <= num_letters; j++)
        {
            int letter_num = rand.Next(0, letters.Length - 1);
            word += letters[letter_num];
        }
        word = word.Remove(num_letters2);
        for (int k = num_letters3 - 1; k >= 0; k--)
        {
            word += word[k];
        }
        Console.WriteLine(word);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Количество слов: ");
        int num_words = Convert.ToInt32(Console.ReadLine());

        Console.Write("Количество букв: ");
        int num_letters = Convert.ToInt32(Console.ReadLine());

        char[] letters = "abcdefghijklmnopqrstubwxyz".ToCharArray();
        for (int i = 1; i <= num_words; i++)
        {
            Palindrom.generatePalindrom(num_letters, letters);
        }
    }
}
