namespace ArraysFuncoesAtividade
{
    internal class Program
    {   //Passos da atividade 
        //1 - Receber 10 valores inteiros. (x)
        //2 - Encontrar o valor maior. (x)
        //3 - Encontrar o menor valor. (x)
        //4 - Encontrar o valor médio. (x)
        //5 - Encontrar os três maiores valores da sequência. (x)
        //6 - Excluir um número da sequência. (x)
        //7 - Mostrar na tela todos os valores na sequência. (x)

        static int[] valoresRecebidos = new int[10] { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1 }; //Declaração de valores fixos na array;
        static int maiorValor, menorValor, valorMedio, segundoMaiorValor, terceiroMaiorValor, valorExcluido, opcao;
        static bool EhContinuar = true;
        static void Main(string[] args)
        {
            while (EhContinuar == true)
            {
                Console.Clear();
                MostrarMenu();
                switch (opcao)
                {
                    case 1: EscreverValorMaior(); break;
                    case 2: EscreverValorMenor(); break;
                    case 3: EscreverValorMedio(); break;
                    case 4: EscreverTresMaioresValores(); break;
                    case 5: ExcluirNumeros(); break;
                    case 6: EscreverNumerosArray(); break;
                    case 7: EscreverValoresNegativos(); break;
                    case 8: EhContinuar = false; break;
                    default: break;
                }
                Console.ReadLine();
            }
        }
        static void MostrarMenu()
        {
            Console.WriteLine(" **     Números disponíveis em Array    *** ");
            Console.WriteLine();
            Console.WriteLine(" **     Os números diponíveis são:      ***");
            Console.WriteLine();
            Console.WriteLine(" ****************************************** ");
            EscreverNumerosArray();
            Console.WriteLine();
            Console.WriteLine(" ****************************************** ");
            Console.WriteLine(" **    Escolha uma das opções abaixo     ** ");
            Console.WriteLine(" ** [1] - Mostrar o valor maior. ");
            Console.WriteLine(" ** [2] - Mostrar o valor menor. ");
            Console.WriteLine(" ** [3] - Mostrar o valor médio. ");
            Console.WriteLine(" ** [4] - Mostrar os três maiores valores. ");
            Console.WriteLine(" ** [5] - Excluir um dos números da Array. ");
            Console.WriteLine(" ** [6] - Mostrar na tela os números da Array. ");
            Console.WriteLine(" ** [7] - Mostrar na tela os valores negativos. ");
            Console.WriteLine(" ** [8] - Sair. ");
            opcao = Convert.ToInt32(Console.ReadLine());
        }
        static int EscreverValorMaior()
        {
            maiorValor = 0;
            foreach (int valor in valoresRecebidos)
            {

                if (valor > maiorValor)
                {
                    maiorValor = valor;
                }
            }
            Console.WriteLine("O valor maior é " + maiorValor);
            return maiorValor;
        }
        static void EscreverValorMenor()
        {
            foreach (int valor in valoresRecebidos)
            {
                if (valor < menorValor)
                {
                    menorValor = valor;
                }
            }
            Console.WriteLine("O menor valor é " + menorValor + ".");
        }
        static void EscreverValorMedio()
        {
            foreach (int valor in valoresRecebidos)
            {
                valorMedio = (valorMedio + valor);
            }
            valorMedio = valorMedio / valoresRecebidos.Length;
            Console.WriteLine("O valor médio é " + valorMedio + ".");
        }
        static void EscreverTresMaioresValores()
        {
            maiorValor = 0;
            foreach (int valor in valoresRecebidos)
            {

                if (valor > maiorValor)
                {
                    maiorValor = valor;
                }
            }
            foreach (int valor in valoresRecebidos)
            {
                if (valor > segundoMaiorValor && valor < maiorValor)
                {
                    segundoMaiorValor = valor;
                }

            }
            foreach (int valor in valoresRecebidos)
            {
                if (valor > terceiroMaiorValor && valor < maiorValor && valor < segundoMaiorValor)
                {
                    terceiroMaiorValor = valor;
                }
            }
            Console.WriteLine("O primeior maior valor é " + maiorValor + ".");
            Console.WriteLine("O segundo maior valor é " + segundoMaiorValor + ".");
            Console.WriteLine("O terceiro maior valor é " + terceiroMaiorValor + ".");
        }
        static void ExcluirNumeros()
        {
            Console.WriteLine("Digite um número que gostaria de excluir: ");
            Console.WriteLine("Os números disponíveis são:");
            foreach (int valor in valoresRecebidos)
            {
                Console.Write(valor + " ");
            }
            Console.WriteLine();
            valorExcluido = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < valoresRecebidos.Length; i++)
            {
                if (valorExcluido == valoresRecebidos[i])
                {
                    valoresRecebidos[i] = 0;
                }
            }
            Console.WriteLine("Os números disponíveis agora são:");
            foreach (int valor in valoresRecebidos)
            {
                Console.Write(valor + " ");
            }
        }
        static void EscreverNumerosArray()
        {

            foreach (int valor in valoresRecebidos)
            {
                Console.Write(valor + "   ");
            }
        }
        static void EscreverValoresNegativos()
        {
            foreach (int valor in valoresRecebidos)
            {
                if (valor < 0)
                {
                    Console.WriteLine("Os valores negativos são: " + valor);
                }
            }
        }
    }
}