using System;
using tabuleiro;
using xadrez;
namespace xadrez_console {
    class Tela {
        public static void imprimirTabuleiro(Tabuleiro tab) {
            for (int i = 0; i < tab.linhas; i++) {
                int espacamento = 8 - i;
                Console.Write($"\t{espacamento}");
                Console.Write("|");
                for (int j = 0; j < tab.colunas; j++) {
                    imprimirPeca(tab.peca(i, j));
                    Console.Write("|");
                    }
                Console.WriteLine();
                }
            Console.WriteLine("\t  A B C D E F G H");
            }
        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis) {

            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;
            for (int i = 0; i < tab.linhas; i++) {
                int espacamento = 8 - i;
                Console.Write($"\t{espacamento}");
                Console.Write("|");
                for (int j = 0; j < tab.colunas; j++) {
                    if(posicoesPossiveis[i, j]) {
                        Console.BackgroundColor = fundoAlterado;                        
                        }
                    else {
                        Console.BackgroundColor = fundoOriginal;
                        }
                    imprimirPeca(tab.peca(i, j));
                    Console.Write("|");
                    Console.BackgroundColor = fundoOriginal;
                    }
                Console.WriteLine();
                }
            Console.WriteLine("\t  A B C D E F G H");
            Console.BackgroundColor = fundoOriginal;
            }

        public static PosicaoXadrez lerPosicaoXadrez() {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
            }

        public static void imprimirPeca(Peca peca) {
            if (peca == null) {
                Console.Write("_");
                }
            else {
                if (peca.cor == Cor.Branca) {
                    Console.Write(peca);
                    }
                else {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;


                    /*Ideia para futura implementação de cores no tabuleiro
                    ConsoleColor aux = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(peca);
                    Console.BackgroundColor = aux;
                    */
                    }
                }
            }

        }
    }

