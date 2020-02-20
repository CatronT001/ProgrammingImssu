using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthMonitor
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Declare your variables here

            //Display a menu
            Console.WriteLine("Welcome to Health Monitor!");
            Console.WriteLine("");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Check your BMI");
            Console.WriteLine("2. Check if you have a healthy blood pressure");
            Console.WriteLine("3. Check if you're getting enough exercise");
            Console.WriteLine("");
            Console.WriteLine("Enter either 1, 2, or 3:");

            //Select between different choices
            string input = Console.ReadLine();
            double choice = Convert.ToDouble(input);

            //BMI
            if (choice == 1)
            {
                Console.WriteLine("BMI CALCULATOR");
                Console.WriteLine("");
                Console.WriteLine("What is your weight (in kilograms)?");
                string weightInput = Console.ReadLine();
                double weight = Convert.ToDouble(weightInput);
                Console.WriteLine("What is your height (in meters)?");
                string heightInput = Console.ReadLine();
                double height = Convert.ToDouble(heightInput);

                double BMI = weight / (height * height);
                Console.WriteLine("Your BMI is {0:.00}.", BMI);
            }

            //BLOOD PRESSURE

            if (choice == 2)
            {
                Console.WriteLine("BP CHECK");
                Console.WriteLine("");
                Console.WriteLine("What is your systolic blood pressure (the top number)?");
                string syBPinput = Console.ReadLine();
                double sy = Convert.ToDouble(syBPinput);
                Console.WriteLine("What is your diastolic blood pressure (the bottom number)?");
                string diaBPinput = Console.ReadLine();
                double dia = Convert.ToDouble(diaBPinput);

                if (sy / dia > 140 / 90)
                    Console.WriteLine("You have high blood pressure.");
                else
                if (sy / dia > 120 / 80 && sy / dia <= 140 / 90)
                    Console.WriteLine("You have pre-high blood pressure.");
                else
                if (sy / dia >= 90 / 60 && sy / dia <= 120 / 80)
                    Console.WriteLine("You have normal blood pressure.");
                else
                if (sy / dia < 90 / 60)
                    Console.WriteLine("You have low blood pressure.");
            }
            //EXERCISE

            if (choice == 3)
            {
                Console.WriteLine("EXERCISE CHECK");
                Console.WriteLine("");
                Console.WriteLine("How many minutes of moderate intensity exercise did you get this week?");
                string modInput = Console.ReadLine();
                double mod = Convert.ToDouble(modInput);
                Console.WriteLine("How many minutes of vigorous intensity exercise did you get this week?");
                string vigInput = Console.ReadLine();
                double vig = Convert.ToDouble(vigInput);

                if (mod + (vig * 2) >= 150)
                    Console.WriteLine("You got enough exercise.");
                else
                    Console.WriteLine("You need more exercise.");
            }
            //ERROR

            if (choice != 1 & choice != 2 && choice != 3)
            {
                Console.WriteLine("Please try again.");
            }
            //Choice 1: BMI
            //Choice 2: Blood Pressure Check
            //Choice 3: Exercise Check
            //Error Message:
            Console.ReadKey();
        }
    }
}