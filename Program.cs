using System;

class CinemaTicket
{
    static void Main()
    {
        
        Console.Write("Enter Movie Title: ");
        string movieTitle = Console.ReadLine();

       
        Console.Write("Enter Number of Tickets: ");
        int numberOfTickets = Convert.ToInt32(Console.ReadLine());

        
        Console.Write("Enter Price per Ticket: ");
        double pricePerTicket = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Enter Movie Duration (hours): ");
        double duration = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Enter Screen Number: ");
        int screenNumber = Convert.ToInt32(Console.ReadLine());

        
        Console.Write("Enter First Letter of Seat Row: ");
        char seatRow = Convert.ToChar(Console.ReadLine());

        
        Console.Write("Is it a 3D Movie? (true/false): ");
        bool is3D = Convert.ToBoolean(Console.ReadLine());

        

        
        double totalCost = numberOfTickets * pricePerTicket;

        
        double costPerHour = totalCost / duration;

        
        int costPerHourInt = (int)costPerHour;

        
        Console.WriteLine("\n--- Cinema Ticket Information ---");
        Console.WriteLine("Movie Title: " + movieTitle);
        Console.WriteLine("Number of Tickets: " + numberOfTickets);
        Console.WriteLine("Price per Ticket: " + pricePerTicket);
        Console.WriteLine("Movie Duration: " + duration + " hours");
        Console.WriteLine("Screen Number: " + screenNumber);
        Console.WriteLine("Seat Row Letter: " + seatRow);
        Console.WriteLine("3D Movie: " + is3D);

        
        Console.WriteLine("\n--- Cost Information ---");
        Console.WriteLine("Total Ticket Cost: " + totalCost);
        Console.WriteLine("Cost per Hour: " + costPerHour);
        Console.WriteLine("Cost per Hour (integer after casting): " + costPerHourInt);

        
        Console.WriteLine("\n--- Data Types ---");
        Console.WriteLine("Movie Title Type: " + movieTitle.GetType());
        Console.WriteLine("Number Of Tickets Type: " + numberOfTickets.GetType());
        Console.WriteLine("Is 3D Type: " + is3D.GetType());

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
