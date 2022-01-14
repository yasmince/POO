using System.IO;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListaDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho,"*",SearchOption.TopDirectoryOnly);

            foreach(var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void LIstaArquivosDiretorio(string caminho)
        {
            var retornaArquivos = Directory.GetFiles(caminho,"*.txt",SearchOption.AllDirectories);

            foreach(var retorno in retornaArquivos)
            {
                System.Console.WriteLine(retorno);
            }

        }

        public void CriarDiretorio(string caminho)
            {
                var retorno = Directory.CreateDirectory(caminho);
                System.Console.WriteLine(retorno.FullName);
            }
        
        public void ApagarDiretorio(string caminho, bool apagarArquivos)
        {
            Directory.Delete(caminho, apagarArquivos);

        }

        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            if (File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            }
            
        }

        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.CreateText(caminho))
            {
                foreach(var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }

        public void AdicionarTextto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }
        public void AdicionarTextoStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.AppendText(caminho))
            {
                foreach(var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }

        public void LerArquivo(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);

            foreach(var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }

        public void LerArquivoStream(string caminho)
        {
            string linha = string.Empty;

            using(var stream = File.OpenText(caminho))
            {
                while((linha = stream.ReadLine()) != null)
                {
                    System.Console.WriteLine(linha);
                }
            }
        }

        public void MoverArquivo(string caminho, string novoCaminho, bool sobreescrever)
        {
            File.Move(caminho, novoCaminho, sobreescrever);
        }

        public void CopiarArquivo(string caminho, string novoCaminho, bool sobreescrever)
        {
            File.Copy(caminho, novoCaminho, sobreescrever);
        }

        public void DeleteArquivo(string caminho)
        {
            File.Delete(caminho);
        }
    }
}