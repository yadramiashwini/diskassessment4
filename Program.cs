namespace diskassessment4
{
    using System;

    public class Computer
    {
        public string Type { get; set; }
        public int Processor { get; set; }
        public int RamSize { get; set; }
        public int HardDiskSize { get; set; }
        public int GraphicCardSize { get; set; }
        public int DisplayOrMonitorSize { get; set; }
        public int PowerSupplyOrBatteryVolt { get; set; }

        // Method to calculate the price
        public double CalculatePrice()
        {
            double basePrice = 0;

            if (Type.Equals("Desktop", StringComparison.OrdinalIgnoreCase))
            {
                basePrice = 10000; // Base price for desktop
                basePrice += Processor * 2000;
                basePrice += RamSize * 1500;
                basePrice += HardDiskSize * 1000;
                basePrice += GraphicCardSize * 2500;
                basePrice += DisplayOrMonitorSize * 1000;
                basePrice += PowerSupplyOrBatteryVolt * 100;
            }
            else if (Type.Equals("Laptop", StringComparison.OrdinalIgnoreCase))
            {
                basePrice = 8000; // Base price for laptop
                basePrice += Processor * 1500;
                basePrice += RamSize * 1200;
                basePrice += HardDiskSize * 800;
                basePrice += GraphicCardSize * 2000;
                basePrice += DisplayOrMonitorSize * 800;
                basePrice += PowerSupplyOrBatteryVolt * 80;
            }

            return basePrice;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Display options to the user
            Console.WriteLine("1. Desktop");
            Console.WriteLine("2. Laptop");
            Console.Write("Choose the option: ");
            int option = int.Parse(Console.ReadLine());

            // Create a new Computer object
            Computer computer = new Computer();
            computer.Type = option == 1 ? "Desktop" : "Laptop";

            // Get specifications from the user
            Console.Write("Enter the processor (i3/i5/i7): ");
            computer.Processor = option == 1 ? 3 : 7; // Example mapping for simplicity

            Console.Write("Enter the RAM size (in GB): ");
            computer.RamSize = int.Parse(Console.ReadLine());

            Console.Write("Enter the hard disk size (in GB): ");
            computer.HardDiskSize = int.Parse(Console.ReadLine());

            Console.Write("Enter the graphic card size (in GB): ");
            computer.GraphicCardSize = int.Parse(Console.ReadLine());

            Console.Write("Enter the display/monitor size (in inches): ");
            computer.DisplayOrMonitorSize = int.Parse(Console.ReadLine());

            Console.Write("Enter the power supply/battery volt: ");
            computer.PowerSupplyOrBatteryVolt = int.Parse(Console.ReadLine());

            // Calculate and display the price
            double price = computer.CalculatePrice();
            Console.WriteLine($"{computer.Type} price is {price}");
        }
    }

}
