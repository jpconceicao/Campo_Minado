using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            // Realize sua codificação a partir deste ponto, boa sorte!
            int statusAtual = campoMinado.JogoStatus;

            while (statusAtual == 0)
            {
                Console.WriteLine("\n\nInsira o valor da linha e da coluna, respectivamente");
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                campoMinado.Abrir(x, y);
                statusAtual = campoMinado.JogoStatus;

                Console.WriteLine("\n" + campoMinado.Tabuleiro);
            }

            if (statusAtual == 1)
            {
                Console.WriteLine("\n\nParabéns! Você venceu o jogo do campo minado!!");
            }
            else
            {
                Console.WriteLine("\n\nQue pena! Não foi dessa vez que você venceu :/");
            }
        }
    }
}
