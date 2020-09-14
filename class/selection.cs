using System;
class SelectionStatement
{
    static void Main3()
        {
            SelectionStatement s = new SelectionStatement();
            s.LearnSwitchStatements();
        }
    void IsEven()
    {
        Console.WriteLine("Enter Number:");
        string input= Console.ReadLine();

        int number = int.Parse(input);

        if(number %2 == 0)
        {
            Console.WriteLine("The entered number is even number .");
        }
        else{
           Console.WriteLine("The entered number is Odd number ."); 
        }
    }
    void LearnSwitchStatements()
            {
                
                Console.WriteLine("Enter your hobby:");
                string input= Console.ReadLine();

                switch(input)
                {
                    case "books":
                    Console.WriteLine("Books are great .");
                    break;
                    case "Basketball":
                    Console.WriteLine("Fly high kid !!");
                    break;
                    case "Swim":
                    Console.WriteLine("Dive like a Dolphin.");
                    break;
                    default:
                    Console.WriteLine("Have some.");
                    break;
                }
            }


}