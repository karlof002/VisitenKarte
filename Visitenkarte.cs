/**************************************************
 * Übungsnr:        01                                     
 * Programmname:    Visitenkarte                                  
 * Autor:           Max Mustermann  
 * Klasse:          1BHIF
 * Datum:           DD.MM.YYYY                               
 * ------------------------------------------------ 
 * Kurzbeschreibung:      
 * Es wird Name und Wohnort eingelesen und dann eine
 * Visitenkarte ausgegeben
 * 
 * ************************************************
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitenkarte
{
    class Visitenkarte
    {
        static void Main(string[] args)
        {
            // Variablen definieren
            string name;
            string city;

            //Eingabe
            Console.Write("Geben Sie Ihren Namen ein:");
            name = Console.ReadLine();

            Console.Write("Geben Sie Ihren Wohnort ein:");
            city = Console.ReadLine();

            //Ausgabe
            Console.WriteLine("*************************************");
            Console.WriteLine("*   " + name);
            Console.WriteLine("*************************************");
            Console.WriteLine("*   " + city);
            Console.WriteLine("*************************************");

            Console.Write("Zum Beenden bitte Eingabetaste drücken ...");
            Console.ReadLine();
        }
    }
}



