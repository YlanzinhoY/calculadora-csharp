using Calculadora;

Console.OutputEncoding = System.Text.Encoding.UTF8;

bool exibirMenu = true;

while(exibirMenu) {
Console.WriteLine("digite qual operação escolher: ");
Console.WriteLine("1 - Adição");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
Console.WriteLine("5 - Encerrar o Programa");

     switch (Console.ReadLine())
    {
        case "1":
            Calculadora.Calculadora.Soma();
            break;

        case "2":
            Calculadora.Calculadora.Subtrair();
            break;

        case "3":
            Calculadora.Calculadora.Multiplicar();
            break;

        case "4":
            Calculadora.Calculadora.Dividir();
            break;

        case "5":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}

Console.WriteLine("Calculadora fechada");
