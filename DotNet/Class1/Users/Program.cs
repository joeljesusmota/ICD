using System;
using System.IO;

namespace Users
{
    class Program
    {
        static void Main(string[] args)
        {
        }


        StreamReader reader = new StreamReander("archivo.txt");
        string read = reader.ReadLine();  
        while(read!=null){             
            Console.WriteLine(read);   
            read = reader.ReadLine();  

            reader.Close();  
 ]
}

}
