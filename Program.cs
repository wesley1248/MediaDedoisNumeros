using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MediaDeDoisValores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis.
            #region
            //Declaraçao das variaveis.
            double numeroUm;
            double numerodois;
            double resultado;
            string exibicao;
            #endregion

            //Interaçao.
            Console.WriteLine("Ola, digite a baixo dois valores para saber a sua media!.");

            //Captaçao dos dados.
            Console.WriteLine("Digite a primeira nota!");
            numeroUm = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota!");
            numerodois = double.Parse(Console.ReadLine());

            //Calculo
            resultado = (numeroUm * 3.5 + numerodois * 7.5) / (3.5 + 7.5);

            exibicao = resultado.ToString("F5");

            //Exibiçao do resultado.
            Console.WriteLine("Media = " + exibicao, CultureInfo.InvariantCulture);

            Console.ReadKey();
        }
    }
}
