using System;
using TextTransformations.Library;

namespace TextTransformations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a text:");
            string answer = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(answer))
            {
                answer = "Playing around with factory pattern and abstract factory pattern!";
            }

            TypesOfTransformation type = GivenAnswer();

            Application.InitializeApplication(answer, type);

            switch (type)
            {
                case TypesOfTransformation.None:
                case TypesOfTransformation.UpperCase:
                    {
                        string result = Application.ApplyTransformation(type);
                        Console.WriteLine(result);
                    }
                    break;

                case TypesOfTransformation.LowerCase:
                    {
                        string result = Application.ApplyTransformation(type);
                        Console.WriteLine(result);
                    }
                    break;

                case TypesOfTransformation.InsertSubStringAtCertainPosition:
                    {
                        int position = RequestPosition();
                        string textToBeInserted = RequestText("inserted.");
                        string result = Application.ApplyTransformation(type, position, textToBeInserted: textToBeInserted);
                        Console.WriteLine(result);
                    }
                    break;

                case TypesOfTransformation.ReplacesubStringWithAnother:
                    {
                        {
                            string textToBeReplaced = RequestText("replaced.");
                            string textToReplaceWith = RequestText("replaced with.");
                            string result = Application.ApplyTransformation(type, textToReplaceWith: textToReplaceWith, textToBeRemoved: textToBeReplaced);
                            Console.WriteLine(result);
                        }
                    }
                    break;

                case TypesOfTransformation.RemoveAllInstancesOfSubString:
                    {
                        string textToBeRemoved = RequestText("removed");
                        string result = Application.ApplyTransformation(type, textToBeRemoved: textToBeRemoved);
                        Console.WriteLine(result);
                    }
                    break;
            }




        }

        private static TypesOfTransformation GivenAnswer()
        {
            bool answerProvided = false;
            while (!answerProvided)
            {
                Console.WriteLine("Please enter a number corresponsing to the type of transformation you would like to be performed:");
                Console.WriteLine("1) Uppercaseing of all small letters in the text");
                Console.WriteLine("2) Lowercaseing of all small letters in the text");
                Console.WriteLine("3) Inserting a sub-string at a certain position in the text");
                Console.WriteLine("4) Replace a sub-string with another in the text");
                Console.WriteLine("5) Remove all instances of a sub-string in the text");

                string input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    switch (result)
                    {
                        case 1:
                            return TypesOfTransformation.UpperCase;

                        case 2:
                            return TypesOfTransformation.LowerCase;

                        case 3:
                            return TypesOfTransformation.InsertSubStringAtCertainPosition;

                        case 4:
                            return TypesOfTransformation.ReplacesubStringWithAnother;

                        case 5:
                            return TypesOfTransformation.RemoveAllInstancesOfSubString;
                    }

                    answerProvided = true;
                }
                else
                {
                    Console.WriteLine("The answer provided was not in a correct format. Please try again!");
                    answerProvided = false;
                }
            }

            return TypesOfTransformation.None;
        }

        private static int RequestPosition()
        {
            Console.WriteLine("Please enter the position at witch you would like the insertion to take place:");
            if (int.TryParse(Console.ReadLine(), out int position))
            {
                return position;
            }
            else
            {
                return 0;
            }
        }

        private static string RequestText(string label)
        {
            Console.WriteLine($"Please enter the text to be {label}:");
            return Console.ReadLine();
        }
    }
}
