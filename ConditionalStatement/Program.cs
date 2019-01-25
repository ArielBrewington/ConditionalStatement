using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect to get in ISM 4300?");

            try
            {

                String Grade = Console.ReadLine();
                int Score = int.Parse(Grade);

                if (Score < 59)
                {

                    Console.WriteLine("You received an F");
                    Console.WriteLine("Press any key to  exit the program");
                    Console.ReadKey(true);
                    
                }

                else if ((Score >= 60) && (Score <= 61))
                {
                    Console.WriteLine("You received a D-");
                    Console.WriteLine("Press any key to  exit the program");
                    Console.ReadKey(true);
                    
                }
                else if ((Score >= 62) && (Score <= 67))
                {
                    Console.WriteLine("You received a D");
                    Console.WriteLine("Press any key to  exit the program");
                    Console.ReadKey(true);
                }
                else if ((Score >= 70) && (Score <= 71))
                {
                    Console.WriteLine("You received a C-");
                    Console.WriteLine("Press any key to  exit the program");
                    Console.ReadKey(true);
                }
                else if ((Score >= 72) && (Score <= 77))
                {
                    Console.WriteLine("You received a C");
                    Console.WriteLine("Press any key to  exit the program");
                    Console.ReadKey(true);
                }
                else if ((Score >= 78) && (Score <= 79))
                {
                    Console.WriteLine("You received a C+");
                    Console.WriteLine("Press any key to  exit the program");
                    Console.ReadKey(true);
                }
                else if ((Score >= 80) && (Score <= 81))
                {
                    Console.WriteLine("You received a B-");
                    Console.WriteLine("Press any key to  exit the program");
                    Console.ReadKey(true);
                }
                else if ((Score >= 82) && (Score <= 87))
                {
                    Console.WriteLine("You received a B");
                    Console.WriteLine("Press any key to  exit the program");
                    Console.ReadKey(true);
                }

                else if ((Score >= 88) && (Score <= 89))
                {
                    Console.WriteLine("You received a B+");
                    Console.WriteLine("Press any key to  exit the program");
                    Console.ReadKey(true);
                }
                else if ((Score >= 90) && (Score <= 91))
                {
                    Console.WriteLine("You received an A-");
                    Console.WriteLine("Press any key to  exit the program");
                    Console.ReadKey(true);
                }
                else if ((Score >= 92) && (Score <= 97))
                {
                    Console.WriteLine("You received an A");
                    Console.WriteLine("Press any key to  exit the program");
                    Console.ReadKey(true);
                }

                else if ((Score >= 98) && (Score <= 100))
                {
                    Console.WriteLine("You receieved an A+");
                    Console.WriteLine("Press any key to  exit the program");
                    Console.ReadKey(true);
                }
            }// end of if

            catch
            {
                Console.WriteLine("Please enter a integer data type");
                Console.WriteLine("Press any key to exit the program and try again");
            }
                               
            

            {            

            }//end of catch
        }//static void

    }//class      
   
}//namespace


