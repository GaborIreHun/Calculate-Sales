using System;

class CalculateSales
{
    static void Main()
    {
        decimal totalSales = 0;
        decimal aTotal = 0;
        decimal bTotal = 0;
        decimal cTotal = 0;
        int aCount = 0;
        int bCount = 0;
        int cCount = 0;

        Console.WriteLine("\nPrices as follows: product 1: $2.98; product 2: $4.50; product 3: $9.98;\n");
        Console.Write("Enter the price of your choosen product and 0 when finished: \n\n");

        double input = double.Parse(Console.ReadLine());

        while (input != 0)
        {
            double price = input;
            totalSales += (decimal)price;

            switch (input)
            {
                case 2.98:
                    ++aCount;
                    aTotal += (decimal)2.98;
                    break;
                case 4.50:
                    ++bCount;
                    bTotal += (decimal)4.50;
                    break;
                case 9.98:
                    ++cCount;
                    cTotal += (decimal)9.98;
                    break;
            }

            input = double.Parse(Console.ReadLine());

        }

        if (totalSales != 0)
        {
            Console.WriteLine("Product number    Quantity Sold   Total cost\n");
            Console.WriteLine($"  product 1    {aCount, 10}    {aTotal, 10}");
            Console.WriteLine($"  product 2    {bCount, 10}    {bTotal, 10}");
            Console.WriteLine($"  product 3    {cCount, 10}    {cTotal, 10}");
            Console.WriteLine($"\n{aTotal + bTotal + cTotal, 39}");
        }
        else
        {
            Console.WriteLine("No item was entered");
        }
    }
        
}

