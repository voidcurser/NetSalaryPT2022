using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSalaryPT
{

    /*
     * 
     * var salarioBruto = Console.ReadLine();
var subsidioAlimentaçao = string.Empty;
Console.WriteLine("tens subsidio de alimentaçao? Y/N");
var alimentaçao = Console.ReadLine();
if(alimentaçao != null)
{
    if(alimentaçao == "Y")
    {
        Console.WriteLine("digita 1 para pago em cartao refeirçao 2 para dinheiro");
        var alimMethod = Console.ReadLine();
        if(alimMethod != null)
        {
            if(alimMethod == "1")
            {
                Console.WriteLine("Insere o valor que recebebes");
                subsidioAlimentaçao = Console.ReadLine();
            }
        }
    }
}
var salarioBrutoD = Decimal.Parse(salarioBruto);
var ttd = new TabelaTrabalhoDependente();
var perc = ttd.PercetagemRetençaoNaFonte(salarioBrutoD, 0);
var retencao = salarioBrutoD * ((perc) / 100);
var ss = salarioBrutoD * (11m/100);
var res = salarioBrutoD - (int)retencao - ss;

Console.WriteLine(res);
     * */
    // depois posso por a fazer donwload de um excel com tabela a mostrar
    internal class TabelaTrabalhoDependente
    {

        public TabelaTrabalhoDependente() { }
        public decimal? PercetagemRetençaoNaFonte(decimal value, int nDependentes)
        {
            if (value <= 710)
            {
                return 0;
            }
            else if (value <= 720)
            {
                switch (nDependentes)
                {
                    case 0: return 1.8m;
                    case 1: return 0.2m;
                    case 2: return 0;
                    case 3: return 0;
                    case 4: return 0;
                    case 5: return 0;
                    default:
                        break;
                }
            }
            else if (value <= 740)
            {
                switch (nDependentes)
                {
                    case 0: return 4.5m;
                    case 1: return 0.6m;
                    case 2: return 0;
                    case 3: return 0;
                    case 4: return 0;
                    case 5: return 0;
                    default:
                        break;
                }
            }
            else if (value <= 754)
            {
                switch (nDependentes)
                {
                    case 0: return 6.3m;
                    case 1: return 0.8m;
                    case 2: return 0;
                    case 3: return 0;
                    case 4: return 0;
                    case 5: return 0;
                    default:
                        break;
                }
            }
            else if (value <= 814)
            {
                switch (nDependentes)
                {
                    case 0: return 7.9m;
                    case 1: return 4.5m;
                    case 2: return 1;
                    case 3: return 0;
                    case 4: return 0;
                    case 5: return 0;
                    default:
                        break;
                }
            }
            else if (value <= 922)
            {
                switch (nDependentes)
                {
                    case 0: return 10.1m;
                    case 1: return 6.7m;
                    case 2: return 3.5m;
                    case 3: return 0;
                    case 4: return 0;
                    case 5: return 0;
                    default:
                        break;
                }
            }
            else if (value <= 1005)
            {
                switch (nDependentes)
                {
                    case 0: return 11.3m;
                    case 1: return 7.9m;
                    case 2: return 5.7m;
                    case 3: return 1.4m;
                    case 4: return 0;
                    case 5: return 0;
                    default:
                        break;
                }
            }
            else if (value <= 1065)
            {
                switch (nDependentes)
                {
                    case 0: return 12.1m;
                    case 1: return 8.8m;
                    case 2: return 6.5m;
                    case 3: return 3.3m;
                    case 4: return 0;
                    case 5: return 0;
                    default:
                        break;
                }
            }
            else if (value <= 1143)
            {
                switch (nDependentes)
                {
                    case 0: return 13.1m;
                    case 1: return 10.7m;
                    case 2: return 8.3m;
                    case 3: return 5.1m;
                    case 4: return 2.7m;
                    case 5: return 0.2m;
                    default:
                        break;
                }
            }
            else if (value <= 1225)
            {
                switch (nDependentes)
                {
                    case 0: return 14.1m;
                    case 1: return 11.8m;
                    case 2: return 9.3m;
                    case 3: return 6.1m;
                    case 4: return 3.6m;
                    case 5: return 1.2m;
                    default:
                        break;
                }
            }
            else if (value <= 1321)
            {
                switch (nDependentes)
                {
                    case 0: return 15.2m;
                    case 1: return 12.8m;
                    case 2: return 10.5m;
                    case 3: return 7m;
                    case 4: return 4.6m;
                    case 5: return 2.2m;
                    default:
                        break;
                }
            }
            else if (value <= 1424)
            {
                switch (nDependentes)
                {
                    case 0: return 16.2m;
                    case 1: return 13.8m;
                    case 2: return 11.4m;
                    case 3: return 8m;
                    case 4: return 6.5m;
                    case 5: return 4m;
                    default:
                        break;
                }
            }
            else if (value <= 1562)
            {
                switch (nDependentes)
                {
                    case 0: return 17.2m;
                    case 1: return 14.8m;
                    case 2: return 12.3m;
                    case 3: return 10;
                    case 4: return 7.5m;
                    case 5: return 5;
                    default:
                        break;
                }
            }
            else if (value <= 1711)
            {
                switch (nDependentes)
                {
                    case 0: return 18.6m;
                    case 1: return 16.3m;
                    case 2: return 14.8m;
                    case 3: return 11.4m;
                    case 4: return 8.9m;
                    case 5: return 6.5m;
                    default:
                        break;
                }
            }
            else if (value <= 1870)
            {
                switch (nDependentes)
                {
                    case 0: return 19.9m;
                    case 1: return 18.2m;
                    case 2: return 17.3m;
                    case 3: return 14.5m;
                    case 4: return 12.5m;
                    case 5: return 11.7m;
                    default:
                        break;
                }
            }
            else if (value <= 1977)
            {
                switch (nDependentes)
                {
                    case 0: return 20.9m;
                    case 1: return 19.3m;
                    case 2: return 18.2m;
                    case 3: return 15.5m;
                    case 4: return 14.5m;
                    case 5: return 12.5m;
                    default:
                        break;
                }
            }
            else if (value <= 2090)
            {
                switch (nDependentes)
                {
                    case 0: return 21.9m;
                    case 1: return 20.2m;
                    case 2: return 19.2m;
                    case 3: return 16.4m;
                    case 4: return 15.5m;
                    case 5: return 13.5m;
                    default:
                        break;
                }
            }
            else if (value <= 2218)
            {
                switch (nDependentes)
                {
                    case 0: return 22.8m;
                    case 1: return 21.3m;
                    case 2: return 20.3m;
                    case 3: return 17.5m;
                    case 4: return 16.5m;
                    case 5: return 14.5m;
                    default:
                        break;
                }
            }
            else if (value <= 2367)
            {
                switch (nDependentes)
                {
                    case 0: return 23.8m;
                    case 1: return 22.2m;
                    case 2: return 21.3m;
                    case 3: return 18.5m;
                    case 4: return 17.6m;
                    case 5: return 15.5m;
                    default:
                        break;
                }
            }
            else if (value <= 2535)
            {
                switch (nDependentes)
                {
                    case 0: return 24.8m;
                    case 1: return 24.2m;
                    case 2: return 22.2m;
                    case 3: return 20.4m;
                    case 4: return 18.5m;
                    case 5: return 17.6m;
                    default:
                        break;
                }
            }
            else if (value <= 2767)
            {
                switch (nDependentes)
                {
                    case 0: return 25.8m;
                    case 1: return 25.1m;
                    case 2: return 23.3m;
                    case 3: return 21.4m;
                    case 4: return 19.4m;
                    case 5: return 18.5m;
                    default:
                        break;
                }
            }
            else if (value <= 3104)
            {
                switch (nDependentes)
                {
                    case 0: return 27m;
                    case 1: return 26.4m;
                    case 2: return 24.5m;
                    case 3: return 22.5m;
                    case 4: return 20.6m;
                    case 5: return 19.6m;
                    default:
                        break;
                }
            }
            else if (value <= 3534)
            {
                switch (nDependentes)
                {
                    case 0: return 28.6m;
                    case 1: return 28.3m;
                    case 2: return 26.8m;
                    case 3: return 25.2m;
                    case 4: return 24.6m;
                    case 5: return 23m;
                    default:
                        break;
                }
            }
            else if (value <= 4118)
            {
                switch (nDependentes)
                {
                    case 0: return 29.7m;
                    case 1: return 29.5m;
                    case 2: return 27.7m;
                    case 3: return 26.2m;
                    case 4: return 25.6m;
                    case 5: return 25m;
                    default:
                        break;
                }
            }
            else if (value <= 4650)
            {
                switch (nDependentes)
                {
                    case 0: return 31.4m;
                    case 1: return 31m;
                    case 2: return 29.4m;
                    case 3: return 27.6m;
                    case 4: return 27m;
                    case 5: return 26.5m;
                    default:
                        break;
                }
            }
            else if (value <= 5194)
            {
                switch (nDependentes)
                {
                    case 0: return 32.3m;
                    case 1: return 31.8m;
                    case 2: return 31.3m;
                    case 3: return 28.9m;
                    case 4: return 28m;
                    case 5: return 27.4m;
                    default:
                        break;
                }
            }
            else if (value <= 5880)
            {
                switch (nDependentes)
                {
                    case 0: return 33.3m;
                    case 1: return 32.8m;
                    case 2: return 32.2m;
                    case 3: return 29.8m;
                    case 4: return 29.2m;
                    case 5: return 28.4m;
                    default:
                        break;
                }
            }
            else if (value <= 6727)
            {
                switch (nDependentes)
                {
                    case 0: return 35.3m;
                    case 1: return 34.9m;
                    case 2: return 34.1m;
                    case 3: return 32.2m;
                    case 4: return 31.8m;
                    case 5: return 31.5m;
                    default:
                        break;
                }
            }
            else if (value <= 7939)
            {
                switch (nDependentes)
                {
                    case 0: return 36.3m;
                    case 1: return 35.9m;
                    case 2: return 35.5m;
                    case 3: return 34.2m;
                    case 4: return 32.8m;
                    case 5: return 32.4m;
                    default:
                        break;
                }
            }
            else if (value <= 9560)
            {
                switch (nDependentes)
                {
                    case 0: return 38.2m;
                    case 1: return 37.8m;
                    case 2: return 37.4m;
                    case 3: return 36.2m;
                    case 4: return 35.8m;
                    case 5: return 34.4m;
                    default:
                        break;
                }
            }
            else if (value <= 11282)
            {
                switch (nDependentes)
                {
                    case 0: return 39.2m;
                    case 1: return 38.8m;
                    case 2: return 38.4m;
                    case 3: return 37.5m;
                    case 4: return 36.7m;
                    case 5: return 35.4m;
                    default:
                        break;
                }
            }
            else if (value <= 18854)
            {
                switch (nDependentes)
                {
                    case 0: return 40.2m;
                    case 1: return 39.8m;
                    case 2: return 39.4m;
                    case 3: return 38.5m;
                    case 4: return 38.1m;
                    case 5: return 36.4m;
                    default:
                        break;
                }
            }
            else if (value <= 20221)
            {
                switch (nDependentes)
                {
                    case 0: return 41.2m;
                    case 1: return 40.8m;
                    case 2: return 40.4m;
                    case 3: return 39.5m;
                    case 4: return 39.1m;
                    case 5: return 37.3m;
                    default:
                        break;
                }
            }
            else if (value <= 22749)
            {
                switch (nDependentes)
                {
                    case 0: return 41.9m;
                    case 1: return 41.7m;
                    case 2: return 41.4m;
                    case 3: return 40.5m;
                    case 4: return 40.1m;
                    case 5: return 38.5m;
                    default:
                        break;
                }
            }
            else if (value <= 25276)
            {
                switch (nDependentes)
                {
                    case 0: return 42.9m;
                    case 1: return 42.7m;
                    case 2: return 42.3m;
                    case 3: return 41.4m;
                    case 4: return 41.1m;
                    case 5: return 39.7m;
                    default:
                        break;
                }
            }
            else if (value > 252756)
            {
                switch (nDependentes)
                {
                    case 0: return 43.8m;
                    case 1: return 43.6m;
                    case 2: return 43.3m;
                    case 3: return 42.4m;
                    case 4: return 42m;
                    case 5: return 40.7m;
                    default:
                        break;
                }
            }

            return null;
        }
    }
}
