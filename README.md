# :book: Exercício C# :book:
## Exercício 3
## Desenvolva uma calculadora, onde será necessário entrar com a operação, primeiro e segundo valor. Exiba o resultado na tela.
```
namespace exercicio03
{
    class Program
    {

        static void Main(string[] args)
        {

            double num1, num2, Result = 0;
            char Operation;

            Console.WriteLine("Por favor, entre com a operação desejada:");
            Console.WriteLine("Digite '+' para Adição");
            Console.WriteLine("Digite '-' para Subtração");
            Console.WriteLine("Digite '/' para Divisão");
            Console.WriteLine("Digite '*' para Multiplicação");
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


        // Console.WriteLine($"A operação de {num1} {Operation} {num2}, dá o resultado de {Result}.");
        
        Console.WriteLine(string.Format("A operação de {0} {1} {2}, dá o resultado de {3}.", num1, Operation, num2, Result));



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
```