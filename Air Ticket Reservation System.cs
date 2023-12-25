using System;
using System.Collections.Generic;
using System.Linq;

class Flight
{
    public string FlightNumber { get; set; }
    public string DepartureCity { get; set; }
    public string ArrivalCity { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public double TicketPrice { get; set; }
    public double FareDiscount { get; set; }
    public int TotalTicketQuantity { get; set; }
    public int RemainingTicketQuantity { get; set; }
    public List<Customer> Customers { get; set; } = new List<Customer>();

     public Flight(string flightNumber, string departureCity, string arrivalCity, DateTime departureTime, DateTime arrivalTime, double ticketPrice, double fareDiscount, int totalTicketQuantity)
    {
        flightNumber = flightNumber;
        departureCity = departureCity;
        arrivalCity = arrivalCity;
        DepartureTime = departureTime;
        ArrivalTime = arrivalTime;
        ticketPrice = ticketPrice;
        fareDiscount = fareDiscount;
        TotalTicketQuantity = totalTicketQuantity;
        RemainingTicketQuantity = totalTicketQuantity;
    }

    public Flight()
    {
    }
}

class Customer
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string IDCard { get; set; }
    public string Name { get; set; }
    public List<Booking> Bookings { get; set; } = new List<Booking>();

    public Customer(string username, string password, string idCard, string name)
    {
        Username = username;
        Password = password;
        IDCard = idCard;
        Name = name;
    }

    public Customer()
    {
    }
}

class Booking
{
    public Flight Flight { get; set; }
    public DateTime BookingTime { get; set; }
    public bool IsRefunded { get; set; }

}

class Program
{
    static List<Flight> flights = new List<Flight>();
    static List<Customer> customers = new List<Customer>();

    static void Main(string[] args)
    {
        
         int role = int.Parse(Console.ReadLine());

        while (true){
                Console.WriteLine("1");
                Console.WriteLine("2");
            while (true)
        {
            if (rule == 1)
            {
                Console.WriteLine("Administrator Menu:");
                Console.WriteLine("1. Add Flight");
                Console.WriteLine("2. Modify Flight");
                Console.WriteLine("3. Delete Flight");
                Console.WriteLine("4. Query Flight");
                Console.WriteLine("5. List Customers on a Flight");
                Console.WriteLine("6. Exit");
            }
            else if(rule == 2)
            {
                Console.WriteLine("Customer Menu:");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Book Flight");
                Console.WriteLine("3. Refund Ticket");
                Console.WriteLine("4. Query Personal Information");
                Console.WriteLine("5. Exit");
            }

            int choice = int.Parse(Console.ReadLine());

            if (choice)
            {
                switch (choice)
                {
                    case 1:
                        AddFlight();
                        break;
                    case 2:
                        ModifyFlight();
                        break;
                    case 3:
                        DeleteFlight();
                        break;
                    case 4:
                        QueryFlight();
                        break;
                    case 5:
                        ListCustomersOnFlight();
                        break;
                    case 6:
                        isAdmin = false;
                        break;
                }
            }
            else
            {
                switch (choice)
                {
                    case 1:
                        Register();
                        break;
                    case 2:
                        BookFlight();
                        break;
                    case 3:
                        RefundTicket();
                        break;
                    case 4:
                        QueryPersonalInformation();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        }
    }

    // Administrator Functions

    static void AddFlight()
    {
        // Implement flight addition logic here
    }

    static void ModifyFlight()
    {
        // Implement flight modification logic here
    }

    static void DeleteFlight()
    {
        // Implement flight deletion logic here
    }

    static void QueryFlight()
    {
        // Implement flight query logic here
    }

    static void ListCustomersOnFlight()
    {
        // Implement customer listing logic here
    }

    // Customer Functions

    static void Register()
    {
        // Implement customer registration logic here
    }

    static void BookFlight()
    {
        // Implement flight booking logic here
    }

    static void RefundTicket()
    {
        // Implement ticket refund logic here
    }

    static void QueryPersonalInformation()
    {
        // Implement personal information query logic here
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Flight> flights = new List<Flight>();
    static List<Customer> customers = new List<Customer>();

    static void Main(string[] args)
    {
        bool isAdmin = false;

        while (true)
        {
            if (isAdmin)
            {
                Console.WriteLine("Administrator Menu:");
                Console.WriteLine("1. Add Flight");
                Console.WriteLine("2. Modify Flight");
                Console.WriteLine("3. Delete Flight");
                Console.WriteLine("4. Query Flight");
                Console.WriteLine("5. List Customers on a Flight");
                Console.WriteLine("6. Exit");
            }
            else
            {
                Console.WriteLine("Customer Menu:");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Book Flight");
                Console.WriteLine("3. Refund Ticket");
                Console.WriteLine("4. Query Personal Information");
                Console.WriteLine("5. Exit");
            }

            int choice = int.Parse(Console.ReadLine());

            if (isAdmin)
            {
                switch (choice)
                {
                    case 1:
                        AddFlight();
                        break;
                    case 2:
                        ModifyFlight();
                        break;
                    case 3:
                        DeleteFlight();
                        break;
                    case 4:
                        QueryFlight();
                        break;
                    case 5:
                        ListCustomersOnFlight();
                        break;
                    case 6:
                        isAdmin = false;
                        break;
                }
            }
            else
            {
                switch (choice)
                {
                    case 1:
                        Register();
                        break;
                    case 2:
                        BookFlight();
                        break;
                    case 3:
                        RefundTicket();
                        break;
                    case 4:
                        QueryPersonalInformation();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }

    // Administrator Functions

    static void AddFlight()
    {
        // Implement flight addition logic here
    }

    static void ModifyFlight()
    {
        // Implement flight modification logic here
    }

    static void DeleteFlight()
    {
        // Implement flight deletion logic here
    }

    static void QueryFlight()
    {
        // Implement flight query logic here
    }

    static void ListCustomersOnFlight()
    {
        // Implement customer listing logic here
    }

    // Customer Functions

    static void Register()
    {
        // Implement customer registration logic here
    }

    static void BookFlight()
    {
        // Implement flight booking logic here
    }

    static void RefundTicket()
    {
        // Implement ticket refund logic here
    }

    static void QueryPersonalInformation()
    {
        // Implement personal information query logic here
    }
}
