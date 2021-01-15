using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o número da apólice");
            string apolice = Console.ReadLine();

            Console.WriteLine("Insira o codigo da seguradora");
            int codSeguradora = Convert.ToInt32(Console.ReadLine());

            if (codSeguradora == (int)BookApolices.Seguradoras.AIG)
            {

                Console.WriteLine("Valor original: " + apolice);

                string apoliceAIG = "";

                if (apolice.Length == 21)
                {
                    apoliceAIG = apolice.Substring(apolice.Length - 11);
                }
                else if (apolice.Length == 10)
                {
                    apoliceAIG = apolice;
                }
                else
                {
                    Console.WriteLine("Número da apólice pode estar incorreto para esta seguradora. Confira os dados.");
                }

                Console.WriteLine("Valor correto: " + apoliceAIG);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.ALFA)
            {
                Console.WriteLine("Valor original: " + apolice);

                string apoliceAlfa = apolice.Replace("/", "");

                Console.WriteLine("Valor correto: " + apoliceAlfa);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Allianz)
            {
                Console.WriteLine("Valor original: " + apolice);

                Console.WriteLine("Valor correto: " + apolice);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.AmericanLife)
            {
                Console.WriteLine("Valor original: " + apolice);

                if (apolice.Length == 24)
                {
                    var ultimos = apolice.Substring(apolice.Length - 7);

                    var ram = apolice.Substring(apolice.Length - 9).Substring(0, 2);

                    string apoliceAmericanLife = "100" + ram + "0" + ultimos;

                    Console.WriteLine("Valor correto: " + apoliceAmericanLife);
                }
                else if (apolice.Length == 13)
                {
                    Console.WriteLine("Valor correto: " + apolice);
                }
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Amil) //////////////// VOLTAR AQUI
            {
                Console.WriteLine("Valor original: " + apolice);

                string apoliceAmil = apolice;

                Console.WriteLine("Valor correto: " + apoliceAmil);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Argo)
            {
                Console.WriteLine("Valor original: " + apolice);

                string apoliceArgo = apolice.Replace("/", "");

                apoliceArgo = apolice.Replace(".", "");

                Console.WriteLine("Valor correto: " + apoliceArgo);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Austral)
            {
                Console.WriteLine("Valor original: " + apolice);

                string apoliceAustral = apolice.Substring(apolice.Length - 12);

                Console.WriteLine("Valor correto: " + apoliceAustral);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.AXA)
            {
                Console.WriteLine("Valor original: " + apolice);

                var apoliceAXA = apolice.Split(".").Last().Replace("0", "");

                Console.WriteLine("Valor correto: " + apoliceAXA);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.AXACorporate)
            {

                Console.WriteLine("Valor original: " + apolice);

                Console.WriteLine("Valor correto: " + apolice);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.AzulSeguros)
            {
                Console.WriteLine("Valor original: " + apolice);

                string apoliceAzulSeguros = apolice.Replace("/", "").Replace(".", "");

                Console.WriteLine("Valor correto: " + apoliceAzulSeguros);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Berkley) ////////////////////// CONFERIR SE O DIGITO DO RAMO É SEMPRE NESSA POSICAO OU VAI SER INPUTADO
            {
                Console.WriteLine("Valor original: " + apolice);

                var ultimos7 = apolice.Substring(apolice.Length - 7);

                var ramo = apolice.Substring(apolice.Length - 9).Substring(0, 2);

                string apoliceBerkley = "100" + ramo + "0" + ultimos7;

                Console.WriteLine("Valor correto: " + apoliceBerkley);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.BMG) ///////////////////// CONFERIR SE É SEMPRE A PARTIR DO 107 OU É PELA QTDADE DE NUMEROS
            {

                Console.WriteLine("Valor original: " + apolice);

                string apoliceBMG = "107" + apolice.Split("107")[1];

                Console.WriteLine("Valor correto: " + apoliceBMG);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Bradesco)
            {

                Console.WriteLine("Valor original: " + apolice);

                string apoliceBradesco = apolice.Substring(3, apolice.Length - 3);

                Console.WriteLine("Valor correto: " + apoliceBradesco);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Caixa)
            {

                Console.WriteLine("Valor original: " + apolice);

                Console.WriteLine("Valor correto: " + apolice);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.CapemisaElementares)
            {

                Console.WriteLine("Valor original: " + apolice);

                string apoliceCapemisaElementares = apolice.Substring(apolice.Length - 12);

                Console.WriteLine("Valor correto: " + apoliceCapemisaElementares);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.CapemisaElementares)
            {

                Console.WriteLine("Valor original: " + apolice);

                string apoliceCapemisaElementares = apolice.Substring(apolice.Length - 12);

                Console.WriteLine("Valor correto: " + apoliceCapemisaElementares);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.CapemisaSaude)
            {
                Console.WriteLine("Valor original: " + apolice);

                Console.WriteLine("Valor correto: " + apolice);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Cesce)
            {
                Console.WriteLine("Valor original: " + apolice);

                string apoliceCesce = apolice.Substring(apolice.Length - 12);

                Console.WriteLine("Valor correto: " + apoliceCesce);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.CHUBB)
            {
                Console.WriteLine("Valor original: " + apolice);

                string apoliceCHUBB = apolice.Replace(".", "").Replace("/", "").Replace("-", "");

                Console.WriteLine("Valor correto: " + apoliceCHUBB);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Coface)
            {
                Console.WriteLine("Valor original: " + apolice);

                Console.WriteLine("Valor correto: " + apolice);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Essor)
            {
                Console.WriteLine("Valor original: " + apolice);

                Console.WriteLine("Valor correto: " + apolice);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Excelsior)
            {
                Console.WriteLine("Valor original: " + apolice);

                string apoliceExcelsior = apolice.TrimStart('0');

                Console.WriteLine("Valor correto: " + apoliceExcelsior);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Ezze)
            {
                Console.WriteLine("Valor original: " + apolice);

                if (apolice.Length == 24)
                {
                    var ultimos = apolice.Substring(apolice.Length - 6);

                    string apoliceEzze = "1007507" + ultimos;

                    Console.WriteLine("Valor correto: " + apoliceEzze);
                }
                else if (apolice.Length == 13)
                {
                    Console.WriteLine("Valor correto: " + apolice);
                }
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Fairfax)
            {
                if (apolice.Length == 25)
                {
                    var ultimos = apolice.Substring(apolice.Length - 13);

                    string apoliceFairfax = ultimos;

                    Console.WriteLine("Valor correto: " + apoliceFairfax);
                }
                else if (apolice.Length == 13)
                {
                    Console.WriteLine("Valor correto: " + apolice);
                }
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Fator)
            {
                if (apolice.Length == 24)
                {
                    var ultimos = apolice.Substring(apolice.Length - 12);

                    string apoliceFairfax = ultimos;

                    Console.WriteLine("Valor correto: " + apoliceFairfax);
                }
                else if (apolice.Length == 13)
                {
                    Console.WriteLine("Valor correto: " + apolice);
                }
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Generali)
            {
                Console.WriteLine("Valor original: " + apolice);

                string apoliceGenerali = apolice.Replace(".", "").Replace("/", "").Replace("-", "");

                Console.WriteLine("Valor correto: " + apoliceGenerali);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.HDI)
            {
                Console.WriteLine("Valor original: " + apolice);

                string apoliceHDI = apolice.Split(".")[3].TrimStart('0');

                Console.WriteLine("Valor correto: " + apoliceHDI);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.InvestPrev)
            {
                Console.WriteLine("Valor original: " + apolice);

                string apoliceInvestPrev = apolice.Split(".")[1];

                Console.WriteLine("Valor correto: " + apoliceInvestPrev);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.ItauSeguros)
            {
                Console.WriteLine("Valor original: " + apolice);

                string apoliceItauSeguros = apolice.Split(".")[1];

                Console.WriteLine("Valor correto: " + apoliceItauSeguros);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.JNS)
            {
                Console.WriteLine("Valor original: " + apolice);

                Console.WriteLine("Valor correto: " + apolice);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Junto)
            {
                Console.WriteLine("Valor original: " + apolice);

                Console.WriteLine("Valor correto: " + apolice);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Liberty)
            {
                Console.WriteLine("Valor original: " + apolice);

                string apoliceLiberty = apolice.Replace(".", "").Replace("/", "").Replace("-", "");

                Console.WriteLine("Valor correto: " + apoliceLiberty);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.MapfreSaude)
            {
                Console.WriteLine("Valor original: " + apolice);

                Console.WriteLine("Valor correto: " + apolice);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Mapfre)
            {
                Console.WriteLine("Valor original: " + apolice);

                string apoliceMapfre = apolice.Replace(".", "").Replace("/", "").Replace("-", "");

                Console.WriteLine("Valor correto: " + apoliceMapfre);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Newe)
            {
                Console.WriteLine("Valor original: " + apolice);

                Console.WriteLine("Valor correto: " + apolice);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.MetLife)
            {
                Console.WriteLine("Valor original: " + apolice);

                string apoliceMetLife = apolice.Substring(0, 5);

                Console.WriteLine("Valor correto: " + apoliceMetLife);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Mitsui)
            {
                Console.WriteLine("Valor original: " + apolice);

                string apoliceMitsui = apolice.TrimStart('0');

                Console.WriteLine("Valor correto: " + apoliceMitsui);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Mongeral) ///////////////////// CONFERIR ESTA REGRA
            {
                Console.WriteLine("Valor original: " + apolice);

                Console.WriteLine("Valor correto: " + apolice);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Nobre)
            {
                Console.WriteLine("Valor original: " + apolice);

                string apoliceNobre = apolice.Split("/")[2].TrimStart('0');

                Console.WriteLine("Valor correto: " + apoliceNobre);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.PortoSeguro) //////////////////// CONFERIR ESTA REGRA
            {
                Console.WriteLine("Valor original: " + apolice);

                Console.WriteLine("Valor correto: " + apolice);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Pottencial)
            {
                Console.WriteLine("Valor original: " + apolice);

                string apolicePottencial = "";

                if(apolice.Length == 25)
                {
                    if (apolice.Contains("775"))
                    {
                        apolicePottencial = apolice.Split("775").Last().Substring(0, 7);
                    }
                    else if (apolice.Contains("776"))
                    {
                        apolicePottencial = apolice.Split("776").Last().Substring(0, 7);
                    }
                    else if (apolice.Contains("746"))
                    {
                        apolicePottencial = apolice.Split("746").Last().Substring(0, 7);
                    }
                }
                else
                {
                    apolicePottencial = apolice.Split("-").Last();
                }

                Console.WriteLine("Valor correto: " + apolicePottencial);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Sancor)
            {
                Console.WriteLine("Valor original: " + apolice);

                Console.WriteLine("Valor correto: " + apolice);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Sompo)
            {
                Console.WriteLine("Valor original: " + apolice);

                Console.WriteLine("Valor correto: " + apolice);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Starr)
            {
                Console.WriteLine("Valor original: " + apolice);

                Console.WriteLine("Valor correto: " + apolice);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Suhai)
            {
                Console.WriteLine("Valor original: " + apolice);

                Console.WriteLine("Valor correto: " + apolice);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.SulAmerica)
            {
                Console.WriteLine("Valor original: " + apolice);

                if(apolice.Length < 7)
                {
                    Console.WriteLine("Valor correto: " + apolice);
                }
                else
                {
                    string apoliceSulamerica = apolice.Substring(apolice.Length - 7);
                    Console.WriteLine("Valor correto: " + apoliceSulamerica);
                }
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Sura)
            {
                Console.WriteLine("Valor original: " + apolice);

                Console.WriteLine("Valor correto: " + apolice);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.SwissRe)
            {
                Console.WriteLine("Valor original: " + apolice);

                Console.WriteLine("Valor correto: " + apolice);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.TokioMarine) ////////////////////// CONFERIR ESTA REGRA
            {
                Console.WriteLine("Valor original: " + apolice);

                Console.WriteLine("Valor correto: " + apolice);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Too)
            {
                Console.WriteLine("Valor original: " + apolice);

                if(apolice.Length == 24)
                {
                    string apoliceToo = apolice.Substring(apolice.Length - 12);
                    Console.WriteLine("Valor correto: " + apoliceToo);
                }
                else
                {
                    Console.WriteLine("Valor correto: " + apolice);
                }
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.SwissRe)
            {
                Console.WriteLine("Valor original: " + apolice);

                Console.WriteLine("Valor correto: " + apolice);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Travelers)
            {
                Console.WriteLine("Valor original: " + apolice);

                Console.WriteLine("Valor correto: " + apolice);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.XL)
            {
                Console.WriteLine("Valor original: " + apolice);

                string apoliceXL = apolice.Replace(".", "").Replace("/", "").Replace("-", "").TrimStart('0');

                Console.WriteLine("Valor correto: " + apoliceXL);
            }
            else if (codSeguradora == (int)BookApolices.Seguradoras.Zurich)
            {
                Console.WriteLine("Valor original: " + apolice);
                
                if(apolice.Length == 7)
                {
                    Console.WriteLine("Valor correto: " + apolice);
                }
                else if (apolice.Contains("."))
                {
                    string apoliceZurich = apolice.Split(".").Last().TrimStart('0');

                    Console.WriteLine("Valor correto: " + apoliceZurich);
                }
                else
                {
                    string apoliceZurich = apolice.Split(".").Last().TrimStart('0');

                    Console.WriteLine("Valor correto: " + apoliceZurich);
                }

            }
        }
    }
}
