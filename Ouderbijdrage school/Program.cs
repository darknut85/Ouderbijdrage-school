using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouderbijdrage_school
{
    class Program
    {
        static void Main(string[] args)
        {
            //startbedrag
            double Basic = 50;
            double TotalCost = 0;

            //jonger dan 10 jaar
            double young = 25;
            double maxY = 3;

            //10 jaar en ouder
            double old = 37;
            double maxO = 2;

            //maximale ouderbijdrage;
            double maxContribution = 150;

            //korting voor éénoudergezinnen in percentage
            double discount = 25;

            //datum van kind
            DateTime child;

            //datum van invullen
            DateTime form;

            //rest
            bool more = true;
            double CurrentY = 0;
            double CurrentO = 0;
            double TC;
            bool own;

            //////////////////////////////////////////////////////////////////////////////
            
            //invullen van gegevens
            Console.WriteLine("Date of filling in form");
            form = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Do you live on your own?(true or false)");

            own = Convert.ToBoolean(Console.ReadLine());
            TotalCost += Basic;
            while (more == true)
            {
                Console.WriteLine("birth date");
                child = Convert.ToDateTime(Console.ReadLine());
                //math
                double VF = (form - child).TotalDays;
                Console.WriteLine("Your child is currently " + VF + " Days old.");
                if (VF > 3652 && CurrentO < maxO)
                {
                    TotalCost += old;
                    CurrentO++;
                }
                else if(VF <= 3652 && CurrentY < maxY)
                {
                    TotalCost += young;
                    CurrentY++;
                }
                ///////////////////////////////////////////////////////////////////////////
                Console.WriteLine("Do you have another child?(true or false)");
                more = Convert.ToBoolean(Console.ReadLine());
            }
            if (TotalCost > maxContribution)
            {
                TotalCost = 150;
            }

            if (own == true)
            {
                TC = TotalCost - (TotalCost / 100 * discount);
            }
            else
            {
                TC = TotalCost;
            }
            Console.WriteLine(TC);
            Console.ReadLine();
        }
    }
}
// basisbedrag 50 euro
// kind jonger dan 10 jaar 25 euro (voor max 3 kinderen)
// kind van 10 jaar en ouder 37 euro (voor max 2 kinderen)
// max ouderbijdrage = 150 euro
// voor 1 ouder gezin totale kosten -25% (na toepassen van maximum)
// leeftijd van elk kind (aan de hand van geboortedatum en peildatum)
