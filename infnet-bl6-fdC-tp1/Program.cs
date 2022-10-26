using FuncaoSoma;
using FuncaoSubtracao;
using FuncaoMultiplicacao;

namespace AplicacaoPrincipal

{
    public class Programa
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            while (opcao != 9)
            {
                Console.WriteLine("Informe qual operação quer realizar:");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine();
                Console.WriteLine("9 - Finalizar");

                while (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Valor informado está inválido");
                };

                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        FuncaoSoma.FuncaoSoma soma = new FuncaoSoma.FuncaoSoma();
                        soma.somaNumeros();
                        break;
                    case 2:
                        FuncaoSubtracao.FuncaoSubtracao subtrai = new FuncaoSubtracao.FuncaoSubtracao();
                        subtrai.subtracaoNumeros();
                        break;
                    case 3:
                        FuncaoMultiplicacao.FuncaoMultiplicacao multiplica = new FuncaoMultiplicacao.FuncaoMultiplicacao();
                        multiplica.multiplicaNumeros();
                        break;
                    case 4:
                        FuncaoDivisao.FuncaoDivisao divide = new FuncaoDivisao.FuncaoDivisao();
                        divide.divideNumeros();
                        break;
                }
                Console.Clear();
            }

        }
    }
}