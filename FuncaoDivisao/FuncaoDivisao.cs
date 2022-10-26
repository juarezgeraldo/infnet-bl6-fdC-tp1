namespace FuncaoDivisao
{
    public class FuncaoDivisao
    {
        public void divideNumeros()
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Aplicação para Dividir dois números");
            Console.WriteLine("===================================");

            Console.WriteLine("Informe o primeiro número");

            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Valor informado está inválido");
            };


            Console.WriteLine("Informe o segundo número");

            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Valor informado está inválido");
            };

            double divisao = (double)num1 / (double)num2;

            Console.WriteLine("A multiplicação dos números é: " + divisao);

            Console.ReadKey();

        }
    }
    }