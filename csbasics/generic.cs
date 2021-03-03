using System;
using System.Collections.Generic;
namespace LearningClasses
{
    public class Generic
    {
        //using list
        void LearningList()
        {
            List<string> names  = new List<string>();
            names.Add("Arshon");

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}