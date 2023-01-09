using System;

namespace Calculator
{

    class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Oque deseja fazer ?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Potenciação");
            Console.WriteLine("6 - Raiz Quadrada");
            Console.WriteLine("7 - Sair");

            Console.WriteLine("----------------------");
            Console.WriteLine("Escolha uma opção:");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicaçao(); break;
                case 5: Potenciaçao(); break;
                case 6: Raiz(); break;
                case 7: Sair(); break;
                default: Menu(); break;


            }

        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicaçao()
        {
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Potenciaçao()
        {
            Console.WriteLine("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            double resultado = Math.Pow(v1, v2);
            Console.WriteLine($"O resultado da Potênciação é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Raiz()
        {
            Console.WriteLine("Primeiro valor: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("");
            double resultado = Math.Sqrt(v1);
            Console.WriteLine($"O resultado da Raiz Quadrada é: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Sair()
        {
            Console.WriteLine("Obrigado, tenha um bom dia ");
            System.Environment.Exit(0);
        }
    }

}

