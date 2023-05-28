using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to  Clinic Reservation System");

        while (true)
        {
            Console.WriteLine("1. Book an Appointment");
            Console.WriteLine("2. Update an Appointment");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice (1-3): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BookAppointment();
                    break;
                case "2":
                    UpdateAppointment();
                    break;
                case "3":
                    Console.WriteLine("Exiting the system...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void BookAppointment()
    {
        Console.WriteLine("Booking an Appointment");

        while (true)
        {
            Console.WriteLine("Choose the day for the appointment (1-7):");
            Console.WriteLine("1. Sunday");
            Console.WriteLine("2. Monday ");
            Console.WriteLine("3. Tuesday");
            Console.WriteLine("4.Wednesday");
            Console.WriteLine("5. Thursday");
            Console.WriteLine("6. friday");
            Console.WriteLine("7. saturday");

            int dayChoice;
            if (int.TryParse(Console.ReadLine(), out dayChoice))
            {
                if (dayChoice >= 1 && dayChoice <= 4 )
                {
                    

                   
                    Console.WriteLine("Please enter your information:");
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Age: ");
                    int age;
                    if (!int.TryParse(Console.ReadLine(), out age) || age < 0)
                    {
                        Console.WriteLine("Invalid age. Please try again.");
                        continue;
                    }

                    Console.Write("Relationship Status: ");
                    string relationshipStatus = Console.ReadLine();

                    Console.Write("First visit to the clinic? (yes/no): ");
                    string isFirstVisit = Console.ReadLine();



                    Console.WriteLine("Appointment booked successfully!");
                    Console.WriteLine("Confirmation Reservation Details:");
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Age: {age}");
                    Console.WriteLine($"Relationship Status: {relationshipStatus}");
                    Console.WriteLine($"First Visit: {isFirstVisit}");
                    return;
                }
                else
                {
                   
                    Console.WriteLine("Invalid day. Please choose another day.");
                }
            }
            else
            {
                if (dayChoice >= 6 && dayChoice <= 7)
                    Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }

    static void UpdateAppointment()
    {
        Console.WriteLine("Updating an Appointment");
       
    }

   
}


