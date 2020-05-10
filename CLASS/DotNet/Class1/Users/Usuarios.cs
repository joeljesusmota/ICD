using System;

namespace Users
{
    public class usuarios
    {
        string _name,
        _permisos,
        _funcion;

        int _codigo;

        static string getAcces(string funcion)
        {
            this.funcion = _funcio n; 
            Console.WriteLine("");
            string getAcces;
            Num = Console.ReadLine();


            return _funcion;
        }
        static void acces(string funcion)
        {
            switch (funcion)
            {
                case "admin":
                    Console.WriteLine("Case 1");
                    break;
                case "gerente":
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}
