using System.Text;

public class Program
{
    public static int CountDigitsInString(string pInputValue)
    {
        if(string.IsNullOrEmpty(pInputValue))
        {
            return 0;
        }

        int count = 0;

        foreach (char character in pInputValue)
        {
            if (char.IsDigit(character))
            {
                count++;
            }
        }

        return count;
    }
    public static void Main(string[] args)
    {
   

    }
}
