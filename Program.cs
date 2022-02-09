//Exercício 03 – Desenvolva uma calculadora, onde será necessário entrar com a operação, 
//primeiro e segundo valor, exiba o resultado na tela.

namespace exercicio03
{
    class Program
    {

        static void Main(string[] args)
        {

            double num1, num2, Result = 0;
            char Operation;

            Console.WriteLine("Por favor, entre com a operação desejada:");
            Console.WriteLine("use '+' para Adição");
            Console.WriteLine("use '-' para Subtração");
            Console.WriteLine("use '*' para Multiplicação");
            Console.WriteLine("use '/' para Divisão");
            Console.WriteLine("Por favor, digite apenas o símbolo, sem as apas simples(' ').");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();

            Console.Write("Isira a operação desejada: ");
            char.TryParse(Console.ReadLine(), out Operation);
            
            Console.WriteLine();
            Console.Write("Insira o primeiro valor: ");
            double.TryParse(Console.ReadLine(), out num1);

            Console.WriteLine();
            Console.Write("Agora insira o segundo valor: ");
            double.TryParse(Console.ReadLine(), out num2);

            Console.WriteLine();
            Console.WriteLine();

            switch(Operation)
            {
                case '+' :
                Result = Adicao(num1, num2);
                
                    break;

                case '-' :
                Result = Subtracao(num1, num2);
                    break;

                case '*' :
                Result = Multiplicacao(num1, num2);
                    break;

                case '/' :
                Result = Divisao(num1, num2);
                    break;
                
            }


        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"A operação de {Operation} dos números {num1} e {num2} dá o resultado de {Result}.");



        }

        private static Double Adicao(double num1, double num2)
        {
            return (num1 + num2);
        }

        private static Double Subtracao(double num1, double num2)
        {
            return (num1 - num2);
        }

        private static Double Multiplicacao(double num1, double num2)
        {
            return (num1 * num2);
        }

        private static Double Divisao(double num1, double num2)
        {
            return (num1 / num2);
        }


    }
}