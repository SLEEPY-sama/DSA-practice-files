using System;

public class Stockprediction
{
    public static void Stock()
    {
        int[] stockprice = { 7, 1, 5, 3, 6, 4 };

        int lowestprice = stockprice[0];
        int maxprofit = 0;

        for (int i = 0; i < stockprice.Length; i++)
        {
            if (stockprice[i] < lowestprice)
            {
                lowestprice = stockprice[i];
            }

            int profit = stockprice[i] - lowestprice;

            if (profit > maxprofit)
            {
                maxprofit = profit;
            }
           

        }

        Console.WriteLine(maxprofit);
    }
}
