
namespace Calculadora
{
    public class Calculadora
    {

        public static void Soma()
        {
            System.Console.Write("Digite o primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());
             System.Console.Write("Digite o segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Resultado da Adição: {valor1 + valor2}\n");

        }

        public static void Subtrair() {
            System.Console.Write("Digite o primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());
             System.Console.Write("Digite o segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Resultado da Subtração: {valor1 - valor2}\n");
        }

        public static void Multiplicar() {
            System.Console.Write("Digite o primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());
             System.Console.Write("Digite o segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Resultado da Multiplicação: {valor1 * valor2}\n");
        }

     public static void Dividir() {
            System.Console.Write("Digite o primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());
             System.Console.Write("Digite o segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Resultado da Divisão: {valor1 / valor2}\n");
        }
    }
}
