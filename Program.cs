using System.Globalization;
namespace EstruturaSwitchCase
{
    class program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            string dia;

            //switch case e uma forma alternativa do if-else, invês de você utilizar varias chaves de if-else, você usa apenas o Switch case, conforme no padrão abaixo encerrando com Default que seria a mesma coisa que o else no final.

            switch (x)
            {
                case 1:
                    dia = "domingo";
                    break;
                case 2:
                    dia = "segunda";
                    break;
                case 3:
                    dia = "terça";
                    break;
                case 4:
                    dia = "quarta";
                    break;
                case 5:
                    dia = "quinta";
                    break;
                case 6:
                    dia = "sexta";
                    break;
                case 7:
                    dia = "sabado";
                    break;
                default:
                    dia = "valor invalido";
                    break;
            }

            Console.WriteLine("Dia da semana " + dia);
            Console.ReadLine();

        }
    }
}