using System;
using System.IO;
using System.Collections.Generic;
using ExemploPOO.Models;
using ExemploPOO.Interfaces;
using ExemploPOO.Helper;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            var caminho = "C:/Users/Yasmim/Desktop/TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho,"Pasta Teste 30","SubPastaTeste3");
            var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");
            
            //var listaString = new List<string> ("Linha 1", "Linha 2", "Linha 3 ");
            //var listaStringContinuacao = new List<string> ("Linha 4", "Lnha 5", "Linha 6");
            
            FileHelper helper = new FileHelper();
            // helper.ListaDiretorios(caminho);
            // helper.ListaArquivosDiretorios(caminho);
            // helper.CriarDiretorio(caminhoPathCombine);
            // helper.ApagarDiretorio(caminhoPathCombine, true);
            // helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo.");
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            //helper.LerArquivoStream(caminhoArquivo);
            // helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            // helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeleteArquivo(caminhoArquivoTeste);


            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(10,20));

            // //Classe object

            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());

            // //Classe Abstrata

            // Corrente c = new Corrente();
            // c.Creditar(100);

            // c.ExibirSaldo();

            // // Polimorfismo
            // Aluno p1 = new Aluno();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Nota = 7;

            // p1.Apresentar;


            // //Herança
            // Aluno p1 = new Aluno();
            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar


            // //Encapsulamento
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30,30);

            // System.Console.WriteLine($"Área: {r.ObterArea()}");
            
            // Abstração
            //Pessoa p1 = new Pessoa();
            //p1.Nome = "Bob";
            //p1.Idade = 20;

            //p1.Apresentar();
        }
    }
}