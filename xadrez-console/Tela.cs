using System;
using tabuleiro;

namespace xadrez_console {
    class Tela {
        public static void imprimirTabuleiro(Tabuleiro tab) {
            for (int i = 0; i < tab.linhas; i++) {
                int espacamento = 8 - i;
                Console.Write($"\t{espacamento}");
                //Console.Write(8 - i + " "); caso necessite voltar para o modo anterior
                Console.Write("|");
                for (int j = 0; j < tab.colunas; j++) {
                    if (tab.peca(i, j) == null) {                      
                        Console.Write("_");
                        }
                    else {
                        imprimirPeca(tab.peca(i, j));
                        //Console.Write("");
                        }
                    Console.Write("|");
                    }
                Console.WriteLine();
                }
            Console.WriteLine("\t  A B C D E F G H");
            }

        public static void imprimirPeca(Peca peca) {
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

