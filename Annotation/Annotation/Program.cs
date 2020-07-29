using System;
using System.IO;

namespace Annotation
{
    class Program
    {
        static void Main(string[] args)
        {
            addRecords("143", "kunal", "24", "cake.csv");

        }
        public static void addRecords(string iD,string name ,string age,string filePath)
        {
            
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filePath, true))
                {
                    file.WriteLine(iD + "," + name + "," + age);
                }
            
           
        }
    }
}
