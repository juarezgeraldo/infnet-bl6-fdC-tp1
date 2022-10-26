namespace FuncaoSoma
{
    public class FuncaoSoma
    {
        public void somaNumeros()
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Aplicação para somar dois números");
            Console.WriteLine("=================================");

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

            int soma = num1 + num2;

            Console.WriteLine("A soma dos números é: " + soma);

            Console.ReadKey();
            Console.Clear();


        }

    }
}