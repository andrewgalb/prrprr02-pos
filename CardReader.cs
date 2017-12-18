using System;

public class CardReader
{
    public static string ReadCard()
    {
        StringBuilder stringBuilder = new StringBuilder();

        System.Threading.Thread.Sleep(100);
        Random random = new Random();

        for (int i = 0; i < 4; i++)
        {
            int numberToCat;

            if (random.Next(40) != 1)
            {
                numberToCat = GenerateFourDigitNumber(random);
            }
            else
            {
                numberToCat = GenerateFaultyNumber(random);
            }
            stringBuilder.Append(numberToCat.ToString());
        }
        return stringBuilder.ToString();
    }

    private static int GenerateFourDigitNumber(Random random)
    {
        return random.Next(1000, 10000);
    }

    private static int GenerateFaultyNumber(Random random)
    {
        return random.Next(0, 100000);
    }

}
