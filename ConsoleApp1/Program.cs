// See https://aka.ms/new-console-template for more information

public class TicketOffice
{
    public static int PriceSetter(int age, string place)
    {
        if (age <= 11)
        {
            return (place == "Seated") ? 25 : 110;
        }
        else if (age >= 12 && age <= 64)
        {
            return (place == "Seated") ? 50 : 170;
        }
        else // age >= 65
        {
            return (place == "Seated") ? 60 : 100;
        }
    }


    public static decimal TaxCalculator(int price)
    {
        decimal tax = (decimal)(1 - 1.0 / 1.06) * price;
        return Math.Round(tax, 2);
    }
    public static int TicketNumberGenerator()
    {
        Random rand = new Random();
        return rand.Next(1, 8001);
    }



    public static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());



        Console.Write("Enter 'Seated' or 'Standing' for your ticket: ");
        string place = Console.ReadLine();



        int ticketPrice = PriceSetter(age, place);
        decimal tax = TaxCalculator(ticketPrice);
        int ticketNumber = TicketNumberGenerator();



        Console.WriteLine("\nTicket Details:");
        Console.WriteLine($"Ticket Type: {place}");
        Console.WriteLine($"Ticket Price (SEK): {ticketPrice}");
        Console.WriteLine($"Tax (6%): {tax} SEK");
        Console.WriteLine($"Ticket Number: {ticketNumber}");
    }
}