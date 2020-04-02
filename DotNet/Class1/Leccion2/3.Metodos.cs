using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Program nt = new Program();
            nt.Notas("Leccion1","Introduccion a C#");
            nt.Notas("Covid-19","Quedate en casa");
            nt.Calculadora("+",24,23);
        }

        public void Notas(string titulo, string mensaje)
        {
            Console.WriteLine($"El titulo es: {titulo}. El mensaje es: {mensaje}");
        }

        public void Calculadora(string operador, double num1, double num2)
        {
            double resultado;
            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                break;

                case "-":
                    resultado = num1 - num2;
                break; 
                
                default: Console.WriteLine("operacion no valida");
            }
        }
    }

}
