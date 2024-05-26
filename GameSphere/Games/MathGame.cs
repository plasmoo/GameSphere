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

        public void NumberValidation(int input, int numOfOptions)
        {
            //This checks if a user has input a number that isn't between 1-4.
            string operationSelectionInput;
            bool operationSelectionBool;
            while (input < 1 || input > numOfOptions)
            {
                Console.WriteLine("Error! Your input does not correspond to an option. Please select a value between 1-4.");
                operationSelectionInput = Console.ReadLine();
                operationSelectionBool = int.TryParse(operationSelectionInput, out input);
            }

            if (input <= numOfOptions || input >= 1)
            {
                Console.WriteLine($"You have selected option {input}");
            }
        }

        public int NumberGenerator(int difficulty)
        {
            Random random = new Random();
            int randomNum1;
            switch (difficulty)
            {
                case 1:
                    randomNum1 = random.Next(0,10);
                    break;
                case 2:
                    randomNum1 = random.Next(9,100);
                    break;
                case 3:
                    randomNum1 = random.Next(99, 1000);
                    break;
                default:
                    Console.WriteLine("Invalid selection!");
                    randomNum1 = 0;
                    break;
            }

            return randomNum1;
        }

        public void ArithmeticGame( int operation, int numOfQuestions, int difficulty)
        {
            int numOne;
            int numTwo;
            int playerAnswer;

             

            for (int i = 0; i < numOfQuestions; i++)
            {
                numOne = NumberGenerator(difficulty);
                numTwo = NumberGenerator(difficulty);
                int correctAnswerAdd = numOne + numTwo;
                int correctAnswerSub = 1;
                int correctAnswerMulti = 1;
                int correctAnswerDiv = 1; 
                switch (operation)
                {
                    case 1:
                        Console.WriteLine($"Question #{i}: What is {numOne} + {numTwo}?");
                        playerAnswer = int.Parse(Console.ReadLine());
                        if (playerAnswer == correctAnswerAdd)
                        {
                            Console.WriteLine("Congrats! You got the answer correct!"); 

                        }
                        else
                        {
                            Console.WriteLine($"Sorry! Your answer is incorrect. The correct answer is {correctAnswerAdd}.");
                        }
                        break;
                    case 2:
                        Console.WriteLine($"Question #{i}: What is {numOne} - {numTwo}?");
                        playerAnswer = int.Parse(Console.ReadLine());
                        if (playerAnswer == correctAnswerSub)
                        {
                            Console.WriteLine("Congrats! You got the answer correct!");
                        }
                        else
                        {
                            Console.WriteLine($"Sorry! Your answer is incorrect. The correct answer is {correctAnswerSub}.");
                        }
                        break;
                    case 3:
                        Console.WriteLine($"Question #{i}: What is {numOne} * {numTwo}?");
                        playerAnswer = int.Parse(Console.ReadLine());
                        if (playerAnswer == correctAnswerMulti)
                        {
                            Console.WriteLine("Congrats! You got the answer correct!");
                        }
                        else
                        {
                            Console.WriteLine($"Sorry! Your answer is incorrect. The correct answer is {correctAnswerMulti}.");
                        }
                        break;
                    case 4:
                        Console.WriteLine($"Question #{i}: What is {numOne} / {numTwo}?");
                        playerAnswer = int.Parse(Console.ReadLine());
                        if (playerAnswer == correctAnswerDiv)
                        {
                            Console.WriteLine("Congrats! You got the answer correct!");
                        }
                        else
                        {
                            Console.WriteLine($"Sorry! Your answer is incorrect. The correct answer is {correctAnswerDiv}.");
                        }
                        break;
                }
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
            NumberValidation(operationSelection, 4);

            Console.WriteLine("Please select a difficulty: \n\n1.Easy\n2.Medium\n3.Hard");
            string difficultySelectionInput = Console.ReadLine();
            int difficultySelection;
            bool difficultySelectionBool = int.TryParse(difficultySelectionInput, out difficultySelection);

            InputValidation(difficultySelectionBool, "Error! Invalid selection! Please input a value between 1-3.");
            NumberValidation(difficultySelection, 3);

            Console.WriteLine("How many questions would you like to answer?");
            string numOfQuestionsInput = Console.ReadLine();
            int numOfQuestionsInt;
            bool numOfQuestionsBool = int.TryParse(numOfQuestionsInput, out numOfQuestionsInt);

            InputValidation(numOfQuestionsBool, "Error! Invalid selection! Please input a value between 1-3.");

            ArithmeticGame( operationSelection, numOfQuestionsInt, difficultySelection);

        }
    }
}
