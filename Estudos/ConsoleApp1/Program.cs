﻿using ConsoleApp1.Estudos;

namespace ConsoleApp1
{
    public static class Program
    {
        public static void Main()
        {
            var opcao = "";
            while (opcao != "0")
            {
                opcao = ExibirMenu();
                Processar(opcao);

                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();

            };
            Console.WriteLine("Foi bom ter você aqui, volte sempre. Adeus!");

            CalculaValorD.Processar();
            MaiorValor.Processar();
            CategoriaDeNadadores.Processar();
            IdadeEmDias.Processar();
            ConversaoHora.Processar();
            PesoIdeal.Processar();
            Multiplo.Processar();
            ConversaoIdade.Processar();
            MediaDeAprovacao.Processar();
            SistemasDeEquaçõesLineares.Processar();
            TrocoFacil.Processar();
            EquacaoDoSegundoGrau.Processar();
            Calculadora.Processar();
            DistanciaEntrePontos.Processar();
            Triangulo.Processar();
            Carro.Processar();
            Medias.Processar();
            MediaPeso.Processar();
            CaixaEletronico.Processar();
        }
        private static void Processar(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    CalculaValorD.Processar();
                    break;
                case "2":
                    MaiorValor.Processar();
                    break;
                case "3":
                    CategoriaDeNadadores.Processar();
                    break;
                case "4":
                    IdadeEmDias.Processar();
                    break;
                case "5":
                    ConversaoHora.Processar();
                    break;
                case "6":
                    PesoIdeal.Processar();
                    break;
                case "7":
                    Multiplo.Processar();
                    break;
                case "8":
                    ConversaoIdade.Processar();
                    break;
                case "9":
                    MediaDeAprovacao.Processar();
                    break;
                case "10":
                    SistemasDeEquaçõesLineares.Processar();
                    break;
                case "11":
                    TrocoFacil.Processar();
                    break;
                case "12":
                    EquacaoDoSegundoGrau.Processar();
                    break;
                case "13":
                    Calculadora.Processar();
                    break;
                case "14":
                    DistanciaEntrePontos.Processar();
                    break;
                case "15":
                    Triangulo.Processar();
                    break;
                case "16":
                    Carro.Processar();
                    break;
                case "17":
                    Medias.Processar();
                    break;
                case "18":
                    MediaPeso.Processar();
                    break;
                case "19":
                    CaixaEletronico.Processar();
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
        private static string ExibirMenu()
        {
            Console.WriteLine("Olá meu querido!");
            Console.WriteLine("Seja bem vindo ao melhor programa do mundo!");
            Console.WriteLine("Esses são os programas disponíveis.");
            Console.WriteLine("1 - CalculaValorD");
            Console.WriteLine("2 - MaiorValor");
            Console.WriteLine("3 - CategoriaDeNadadores");
            Console.WriteLine("4 - IdadeEmDias");
            Console.WriteLine("5 - ConversaoHora");
            Console.WriteLine("6 - PesoIdeal");
            Console.WriteLine("7 - Multiplo");
            Console.WriteLine("8 - ConversaoIdade");
            Console.WriteLine("9 - MediaDeAprovacao");
            Console.WriteLine("10 - SistemasDeEquaçõesLineares");
            Console.WriteLine("11 - TrocoFacil");
            Console.WriteLine("12 - EquacaoDoSegundoGrau");
            Console.WriteLine("13 - Calculadora");
            Console.WriteLine("14 - DistanciaEntrePontos");
            Console.WriteLine("15 - Triangulo");
            Console.WriteLine("16 - Carro");
            Console.WriteLine("16 - Medias");
            Console.WriteLine("18 - MediaPeso");
            Console.WriteLine("19 - CaixaEletrônico");
            Console.WriteLine("0 - Sair do programa");
            Console.WriteLine();
            Console.WriteLine("Qual programa deseja processar?");
            var opcao = Console.ReadLine();
            return opcao;
        }
    }
}