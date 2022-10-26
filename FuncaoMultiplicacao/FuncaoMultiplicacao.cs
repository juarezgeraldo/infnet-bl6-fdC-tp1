namespace FuncaoMultiplicacao
{
    public class FuncaoMultiplicacao
    {
        public void multiplicaNumeros()
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Aplicação para Multiplicar dois números");
            Console.WriteLine("=======================================");

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

            int multiplicacao = num1 * num2;

            Console.WriteLine("A multiplicação dos números é: " + multiplicacao);

            Console.ReadKey();
            Console.Clear();


        }
    }
}