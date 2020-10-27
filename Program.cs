using System;

namespace PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            double alturaUsuario, pesoIdeal;
            string generoUsuario, alturaUsuarioTexto;
            bool alturaValida;
            

            Console.Clear();
            Console.WriteLine("--- Peso Ideal");

            Console.Write("Digite sua altura em metros.....:");
            alturaUsuarioTexto = Console.ReadLine();

            Console.Write("Sexo [M]asculino / [F]eminino...:");
            generoUsuario = Console.ReadLine().ToUpper();

            alturaValida = double.TryParse(alturaUsuarioTexto, out alturaUsuario);

            if (!alturaValida)
            {
               Console.WriteLine("Valor inválido");
            }
            else if (generoUsuario != "M" && generoUsuario != "F")
            {
               Console.WriteLine("valor inválido");
            }
            else if (generoUsuario == "M")
            {
               pesoIdeal = alturaUsuario *  72.7 - 58.0;
               Console.WriteLine($"Seu peso ideal é {pesoIdeal.ToString("F")}KG.");
            }
            else if (generoUsuario == "F")
            {
               pesoIdeal = alturaUsuario * 62.1 - 44.7;
               Console.WriteLine($"Seu peso ideal é {pesoIdeal.ToString("F")}KG.");
            }
        }
    }
}
