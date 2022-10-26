namespace FuncaoSubtracao
{
    public class FuncaoSubtracao
    {
        public void subtracaoNumeros()
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Aplicação para subtrair dois números");
            Console.WriteLine("====================================");

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

            int subtracao = num1 - num2;

            Console.WriteLine("A subtração dos números é: " + subtracao);

            Console.ReadKey();
            Console.Clear();


        }
    }
}