using System;
using System.Runtime.CompilerServices;

public class Application
{
    public static void Main(string[] args)
    {
        Console.WriteLine("4USD in UAH: " + Converter.usdToUah(4));
        Console.WriteLine("37EUR in UAH: " + Converter.eurToUah(37));
        Console.WriteLine("3PLN in UAH: " + Converter.plnToUah(3));
        Console.WriteLine("300UAH in USD: " + Converter.uahToUsd(300));
        Console.WriteLine("5000UAH in EUR: " + Converter.uahToEur(5000));
        Console.WriteLine("115UAH in PLN: " + Converter.uahToPln(115));
        Console.ReadLine();
    }
}

public class Converter
{
    private static double usdRate = 36.97;
    private static double eurRate = 38.75;
    private static double plnRate = 8.4;


    public static double usdToUah(double usd)
    {
        return usd * usdRate;
    }

    public static double eurToUah(double eur)
    {
        return eur * eurRate;
    }

    public static double plnToUah(double pln)
    {
        return pln * plnRate;
    }

    public static double uahToUsd(double uah)
    {
        return uah / usdRate;
    }

    public static double uahToEur(double uah)
    {
        return uah / eurRate;
    }

    public static double uahToPln(double uah)
    {
        return uah / plnRate;
    }
}