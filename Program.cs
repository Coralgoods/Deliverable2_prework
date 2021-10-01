using System;

namespace Deliverable2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Data declarations 
            bool valid = false;
            string input = null;
            string previous_response = null;
            string output = null;
            string second_response = null;
            bool same = false; 

            while (!valid)
            {
                //Ask what's up//////////
                Console.Write(second_response +" So what do you have to say? : ");

                input = Console.ReadLine().ToLower();

                //reset same repsonce indicator 
                same = false; 

                if (previous_response == input) {

                output = "I'm sorry but you have already said that. ";
                    same = true; 
                    
                } else
                {

                    if (input == "hello")
                    {
                        output = "Hi good to see you";
                    }
                    else if (input == "sup")
                    {
                        output = "I am good";
                    }
                    else if (input == "hello there")
                    {
                        output = "General Kenobi";
                    }
                    else if (input == "bye")
                    {
                        output = "Good bye!";
                        valid = true;
                    }
                    else
                    {
                        output = "That does not compute. Danger, Danger!";
                     }

                }

                // A little extra response when interacting more than just
                // once. 
                if (same == true)
                {
                    second_response = "Try saying something different...";
                } else
                {
                    second_response = "Back for more!";
                }

                //Store last response. 
                previous_response = input;

                //Respond to user //////////////
                Console.WriteLine(output);

                }

            }
        }
    }

