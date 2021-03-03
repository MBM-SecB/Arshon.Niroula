using System;
class IterationStatement 
{
    static void Main()
    {
        IterationStatement s = new IterationStatement();
        s.LearnWhileLoops();

    }
    void LearnForLoops()
    {
        int i;
        for(i=0;i<10;i++)
        {
        Console.WriteLine("Be Something Wonderful");
        }

        byte[] personAges = {20,23,45,2,46};
        foreach( byte age in personAges)
        {
            if(age %2 == 0)
            {
                Console.WriteLine(age + "is even");
            }
            else{
                Console.WriteLine(age + "is odd");
            }
        }
    }
    void LearnWhileLoops()
    {
        char confirm ='Y';
        while(confirm =='Y')
        {
            Console.WriteLine("I am Loop");
            Console.Write("enter Y to continue");
            confirm=Console.ReadKey().KeyChar;
        }
        Console.WriteLine("I am not loop");
    }
}
 