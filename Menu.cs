using System;
using System.Linq.Expressions;

namespace EditorHTML
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkCyan;        //Cor de fundo
            Console.ForegroundColor = ConsoleColor.Black;       //Cor da letra

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        static void LinhaTabela()   //Função que cria a linha superior e inferior da tabela
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        public static void DrawScreen()     //Função para desenhar a tela
        {
            LinhaTabela();

            for (int linha = 0; linha <= 10; linha++)
            {
                Console.Write("|");

                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }

            LinhaTabela();
        }

        public static void WriteOptions()       //Função para escrever as opções na tela
        {
            Console.SetCursorPosition(3, 2);    //Escreve na posição especifica da tela (dentro da tabela)
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma posição abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("9 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option)      //Função para manipular
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("Visualizar"); break;
                case 9:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}