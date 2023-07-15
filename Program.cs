//display menu options
using PetStore;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Text.Json;


public class Program
{
    public static void Main(string[] args)
    {
        CatFood catFood = new CatFood();

        Console.WriteLine("Press 1 to add a product");
        Console.WriteLine("Type 'exit' to quit");
        string userInput = (Console.ReadLine() ?? "");

        // Warning Disabled to ensure we never have a null value
#pragma warning disable CS8602
        while (userInput.ToLower() != "exit")      
        {
#pragma warning restore CS8602 
            if (userInput != null)

                if (userInput.ToLower() == "exit")
                {
                    break;
                }
                else if (userInput == "1")
                {
                    Console.Write("Name:   ");
                    catFood.Name = Console.ReadLine();

                    Console.Write("Price:  ");
                    catFood.Price = decimal.Parse(Console.ReadLine() ?? "0");

                    Console.Write("Quantity:  ");
                    catFood.Quantity = int.Parse(Console.ReadLine() ?? "0");

                    Console.Write("Description:  ");
                    catFood.Description = Console.ReadLine();

                    Console.Write("Weight (lbs):  ");
                    catFood.WeightPounds = double.Parse(Console.ReadLine() ?? "0");

                    Console.Write("Kitten Food (true/false):  ");
                    catFood.KittenFood = bool.Parse(Console.ReadLine() ?? "false"); 

                    Console.WriteLine(JsonSerializer.Serialize(catFood));

                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Press 1 to add a product or type 'Exit' to quit");
                    continue;
                }

        }

    }
}















