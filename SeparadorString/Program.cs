using System;
using System.Collections.Generic;

namespace SeparadorString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var valores = "PROCESSO: 0000011-61.2016.8.19.0067  Parcela: 1 de 6  VALOR: 255,07\r\nESCRIVÃES: 42,13; CITAÇÃO: 5,20; CAARJ: 4,76; DISTRIBUIDORES-REG/B: 23,75; 20% (FETJ): 4,75; TAXA JUDICIÁRIA: 64,99; FUNDPERJ: 3,55; FUNPERJ: 3,55; 2%(DISTRIB)L6370/12: 0,50; TRIBUTOS: 25,00; HON. ADV.: 75,00; FUNARPEN: 1,89\r\n\r\nPROCESSO: 0000037-59.2016.8.19.0067  Parcela: 1 de 4  VALOR: 332,56\r\nESCRIVÃES: 63,16; CITAÇÃO: 7,79; CAARJ: 7,09; DISTRIBUIDORES-REG/B: 35,64; 20% (FETJ): 7,14; TAXA JUDICIÁRIA: 97,49; FUNDPERJ: 5,34; FUNPERJ: 5,34; 2%(DISTRIB)L6370/12: 0,72; TRIBUTOS: 55,00; HON. ADV.: 45,00; FUNARPEN: 2,85\r\n\r\nPROCESSO: 0000038-44.2016.8.19.0067  Parcela: 1 de 3  VALOR: 409,95\r\nESCRIVÃES: 84,20; CITAÇÃO: 10,38; CAARJ: 9,46; DISTRIBUIDORES-REG/B: 47,50; 20% (FETJ): 9,50; TAXA JUDICIÁRIA: 129,98; FUNDPERJ: 7,10; FUNPERJ: 7,10; 2%(DISTRIB)L6370/12: 0,95; TRIBUTOS: 60,00; HON. ADV.: 40,00; FUNARPEN: 3,78\r\n\r\nPROCESSO: 0000040-14.2016.8.19.0067  Parcela: 1 de 10  VALOR: 193,18\r\nESCRIVÃES: 25,33; CITAÇÃO: 3,11; CAARJ: 2,89; DISTRIBUIDORES-REG/B: 14,25; 20% (FETJ): 2,85; TAXA JUDICIÁRIA: 38,99; FUNDPERJ: 2,13; FUNPERJ: 2,13; 2%(DISTRIB)L6370/12: 0,33; TRIBUTOS: 15,00; HON. ADV.: 85,00; FUNARPEN: 1,17\r\n\r\nPROCESSO: 0000041-96.2016.8.19.0067  Parcela: 1 de 2  VALOR: 564,90\r\nESCRIVÃES: 126,29; CITAÇÃO: 15,55; CAARJ: 14,18; DISTRIBUIDORES-REG/B: 71,25; 20% (FETJ): 14,25; TAXA JUDICIÁRIA: 194,98; FUNDPERJ: 10,65; FUNPERJ: 10,65; 2%(DISTRIB)L6370/12: 1,43; TRIBUTOS: 85,00; HON. ADV.: 15,00; FUNARPEN: 5,67\r\n\r\nPROCESSO: 0000059-20.2016.8.19.0067  Parcela: 1 de 6  VALOR: 255,07\r\nESCRIVÃES: 42,13; CITAÇÃO: 5,20; CAARJ: 4,76; DISTRIBUIDORES-REG/B: 23,75; 20% (FETJ): 4,75; TAXA JUDICIÁRIA: 64,99; FUNDPERJ: 3,55; FUNPERJ: 3,55; 2%(DISTRIB)L6370/12: 0,50; TRIBUTOS: 55,00; HON. ADV.: 45,00; FUNARPEN: 1,89\r\n\r\nPROCESSO: 0000060-05.2016.8.19.0067  Parcela: 1 de 8  VALOR: 216,49\r\nESCRIVÃES: 31,59; CITAÇÃO: 3,94; CAARJ: 3,58; DISTRIBUIDORES-REG/B: 17,83; 20% (FETJ): 3,58; TAXA JUDICIÁRIA: 48,74; FUNDPERJ: 2,68; FUNPERJ: 2,68; 2%(DISTRIB)L6370/12: 0,40; TRIBUTOS: 25,00; HON. ADV.: 75,00; FUNARPEN: 1,47\r\n\r\nPROCESSO: 0000010-76.2016.8.19.0067  Parcela: 1 de 4  VALOR: 332,56\r\nESCRIVÃES: 63,16; CITAÇÃO: 7,79; CAARJ: 7,09; DISTRIBUIDORES-REG/B: 35,64; 20% (FETJ): 7,14; TAXA JUDICIÁRIA: 97,49; FUNDPERJ: 5,34; FUNPERJ: 5,34; 2%(DISTRIB)L6370/12: 0,72; TRIBUTOS: 50,00; HON. ADV.: 50,00; FUNARPEN: 2,85\r\n\r\nPROCESSO: 0000062-72.2016.8.19.0067  Parcela: 1 de 3  VALOR: 409,95\r\nESCRIVÃES: 84,20; CITAÇÃO: 10,38; CAARJ: 9,46; DISTRIBUIDORES-REG/B: 47,50; 20% (FETJ): 9,50; TAXA JUDICIÁRIA: 129,98; FUNDPERJ: 7,10; FUNPERJ: 7,10; 2%(DISTRIB)L6370/12: 0,95; TRIBUTOS: 15,00; HON. ADV.: 85,00; FUNARPEN: 3,78\r\n\r\nPROCESSO: 0000063-57.2016.8.19.0067  Parcela: 1 de 7  VALOR: 232,99\r\nESCRIVÃES: 36,10; CITAÇÃO: 4,46; CAARJ: 4,06; DISTRIBUIDORES-REG/B: 20,40; 20% (FETJ): 4,08; TAXA JUDICIÁRIA: 55,70; FUNDPERJ: 3,06; FUNPERJ: 3,06; 2%(DISTRIB)L6370/12: 0,45; TRIBUTOS: 10,00; HON. ADV.: 90,00; FUNARPEN: 1,62\r\n\r\nVALORES NÃO AJUIZADOS - TRIBUTOS: 50,00; HONORÁRIOS: 50,00\r\n\r\n\r\n";

            string[] processos = valores.Split(new string[] { "PROCESSO: " }, StringSplitOptions.RemoveEmptyEntries);

            List<string> listaProcesso = new List<string>();

            //Console.WriteLine("Valores: " + processos[0]);
            foreach (string processo in processos)
            {
                int indiceParcela = processo.IndexOf("Parcela:");

                if (indiceParcela != -1)
                {
                    string valor = processo.Substring(0, processo.IndexOf("Parcela")).Trim();
                    listaProcesso.Add(valor);
                    //Console.WriteLine(valor);
                }
                //Console.WriteLine("PROCESSO: " + processo.Trim());
            }

            foreach (var item in listaProcesso)
            {
                Console.WriteLine(item);
            }
        }
    }
}
