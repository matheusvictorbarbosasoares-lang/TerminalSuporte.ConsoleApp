using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.Title = "Terminal de Suporte - Diagnostico de Rede";

        while (true)
        {
            MostrarMenu();

            Console.Write("\nDigite um comando: ");
            string comando = Console.ReadLine()?.ToLower() ?? "";

            if (comando == "1")
            {
                PingIP();
            }
            else if (comando == "2")
            {
                ReiniciarServidor();
            }
            else if (comando == "3")
            {
                FormatarUnidade();
            }
            else if (comando == "help" || comando == "?")
            {
                MostrarAjuda();
            }
            else if (comando == "0")
            {
                Console.WriteLine("Encerrando terminal...");
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Comando invalido! Digite 'help' para ajuda.");
                Console.ResetColor();
            }

            Console.WriteLine("\nPressione ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
    }

    static void MostrarMenu()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("====================================");
        Console.WriteLine(" TERMINAL DE SUPORTE - DIAGNOSTICO ");
        Console.WriteLine("====================================");
        Console.ResetColor();

        Console.WriteLine("[1] Ping em IP");
        Console.WriteLine("[2] Reiniciar Servidor");
        Console.WriteLine("[3] Formatar Unidade");
        Console.WriteLine("[help] Ajuda");
        Console.WriteLine("[0] Sair");
    }

    static void PingIP()
    {
        Console.Write("Digite o IP para ping: ");
        string ip = Console.ReadLine() ?? "";

        if (!ip.Contains("."))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("IP invalido! Use o formato: xxx.xxx.xxx.xxx");
            Console.ResetColor();
            return;
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Ping enviado com sucesso para " + ip);
        Console.ResetColor();
    }

    static void ReiniciarServidor()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Tem certeza que deseja reiniciar o servidor? (s/n): ");
        Console.ResetColor();

        string confirm = Console.ReadLine()?.ToLower() ?? "";

        if (confirm == "s")
        {
            Console.WriteLine("Reiniciando servidor...");
            Thread.Sleep(2000);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Servidor reiniciado com sucesso!");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Operacao cancelada.");
        }
    }

    static void FormatarUnidade()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ATENCAO! FORMATAR IRA APAGAR TODOS OS DADOS!");
        Console.ResetColor();

        Console.Write("Digite CONFIRMAR para continuar: ");
        string confirm = Console.ReadLine() ?? "";

        if (confirm == "CONFIRMAR")
        {
            Console.WriteLine("Formatando unidade...");
            Thread.Sleep(2000);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Formatacao concluida.");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Formatacao cancelada.");
        }
    }

    static void MostrarAjuda()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n=== AJUDA DO TERMINAL ===");
        Console.ResetColor();

        Console.WriteLine("1 - Envia ping para um endereco IP.");
        Console.WriteLine("2 - Reinicia o servidor com confirmacao.");
        Console.WriteLine("3 - Formata uma unidade (acao critica).");
        Console.WriteLine("help ou ? - Mostra esta tela de ajuda.");
        Console.WriteLine("0 - Fecha o terminal.");
    }
}