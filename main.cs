using System;
class Program {
    static void Main(string[] args) {
        Console.Write("Enter something: ");

      // I used ToLower() just in case the user type the exit into a uppercase
      // it will automatically put the uppercase into a lowercase
        while (true) {
            string input = Console.ReadLine();
            if (input.ToLower() == "exit") {
                Console.WriteLine("\nClosing program...");
                break;
            }
            Console.WriteLine(input);
            Console.Write("Enter something: ");
        }
    }
}