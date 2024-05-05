using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSphere.Games
{
    public class MathGame
    {
        public void InputValidation(bool input, string errorMessage)
        {
            //This checks if a user inputs an invalid character as a response 
            string operationSelectionInput;
            int operationSelection;

            while (input != true)
            {
                Console.WriteLine(errorMessage);
                operationSelectionInput = Console.ReadLine();
                input = int.TryParse(operationSelectionInput, out operationSelection);
            }
        }

        public void NumberValidation(int input)
        {
            //This checks if a user has input a number that isn't between 1-4.
            string operationSelectionInput;
            bool operationSelectionBool;
            while (input < 1 || input > 4)
            {
                Console.WriteLine("Error! Your input does not correspond to an option. Please select a value between 1-4.");
                operationSelectionInput = Console.ReadLine();
                operationSelectionBool = int.TryParse(operationSelectionInput, out input);
            }

            if (input <= 4 || input >= 1)
            {
                Console.WriteLine($"You have selected option {input}");
            }
        }

        public void MathFunction()
        {
            Console.WriteLine("MATH GAME!\n\nAre you good at math?! Put your skills to the test!\n\nPlease select an operation by " +
                "typing a number 1-4.\n\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
            string operationSelectionInput = Console.ReadLine();
            int operationSelection;
            bool operationSelectionBool = int.TryParse(operationSelectionInput, out operationSelection );

            InputValidation(operationSelectionBool, "Error! Invalid selection. Please input a value between 1-4.");
            NumberValidation(operationSelection);

            Console.WriteLine("Please select a difficulty: \n\n1.Easy\n2.Medium\n3.Hard");
            string difficultySelectionInput = Console.ReadLine();
            int difficultySelection;
            bool difficultySelectionBool = int.TryParse(difficultySelectionInput, out difficultySelection);



        }
    }
}
