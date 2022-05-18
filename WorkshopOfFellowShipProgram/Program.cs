using System;
using WorkshopOfFellowShipProgram;
public class Program
{
    public static void Main(String[] args)
    {
        TablePowerOfTwo result = new TablePowerOfTwo();
        Console.WriteLine("Enter a number to To display the Power of Two");
        int num = Convert.ToInt32(Console.ReadLine());
        result.Table(num);
    }
}