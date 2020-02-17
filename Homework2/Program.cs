using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA
{
    class Program
    {
        static void Main(string[] args)

        {//Shaun Poweshiek

            //App intro and constant declarations
            Console.WriteLine("GPA Calculator");
            const double perclassCREDITS = 3.0;
            const int numberofCLASSES = 4;


            //User Grade Percentage (per class) inputs:
            Console.WriteLine("Please enter your ACCOUNTING grade percentage: ");
            double percentageACCT = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your MARKETING grade percentage: ");
            double percentageMKT = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your ECONOMICS grade percentage: ");
            double percentageECON = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your MIS grade percentage: ");
            double percentageMIS = double.Parse(Console.ReadLine());


            //Assigning a 'Letter Grade' to user's grade percentage input:
            char lettergradeACCT;
            if (percentageACCT >= 90)
                lettergradeACCT = 'A';
            else if (percentageACCT >= 80 && percentageACCT < 90)
                lettergradeACCT = 'B';
            else if (percentageACCT >= 70 && percentageACCT < 80)
                lettergradeACCT = 'C';
            else if (percentageACCT >= 60 && percentageACCT < 70)
                lettergradeACCT = 'D';
            else
                lettergradeACCT = 'F';

            char lettergradeMKT;
            if (percentageMKT >= 90)
                lettergradeMKT = 'A';
            else if (percentageMKT >= 80 && percentageMKT < 90)
                lettergradeMKT = 'B';
            else if (percentageMKT >= 70 && percentageMKT < 80)
                lettergradeMKT = 'C';
            else if (percentageMKT >= 60 && percentageMKT < 70)
                lettergradeMKT = 'D';
            else
                lettergradeMKT = 'F';

            char lettergradeECON;
            if (percentageECON >= 90)
                lettergradeECON = 'A';
            else if (percentageECON >= 80 && percentageECON < 90)
                lettergradeECON = 'B';
            else if (percentageECON >= 70 && percentageECON < 80)
                lettergradeECON = 'C';
            else if (percentageECON >= 60 && percentageECON < 70)
                lettergradeECON = 'D';
            else
                lettergradeECON = 'F';

            char lettergradeMIS;
            if (percentageMIS >= 90)
                lettergradeMIS = 'A';
            else if (percentageMIS >= 80 && percentageMIS < 90)
                lettergradeMIS = 'B';
            else if (percentageMIS >= 70 && percentageMIS < 80)
                lettergradeMIS = 'C';
            else if (percentageMIS >= 60 && percentageMIS < 70)
                lettergradeMIS = 'D';
            else
                lettergradeMIS = 'F';


            //Assigning 'Credit Points' to user's grade percentage input:
            double creditpointsACCT;
            if (percentageACCT >= 90)
                creditpointsACCT = 4;
            else if (percentageACCT >= 80 && percentageACCT < 90)
                creditpointsACCT = 3;
            else if (percentageACCT >= 70 && percentageACCT < 80)
                creditpointsACCT = 2;
            else if (percentageACCT >= 60 && percentageACCT < 70)
                creditpointsACCT = 1;
            else
                creditpointsACCT = 0;

            double creditpointsMKT;
            if (percentageMKT >= 90)
                creditpointsMKT = 4;
            else if (percentageMKT >= 80 && percentageMKT < 90)
                creditpointsMKT = 3;
            else if (percentageMKT >= 70 && percentageMKT < 80)
                creditpointsMKT = 2;
            else if (percentageMKT >= 60 && percentageMKT < 70)
                creditpointsMKT = 1;
            else
                creditpointsMKT = 0;

            double creditpointsECON;
            if (percentageECON >= 90)
                creditpointsECON = 4;
            else if (percentageECON >= 80 && percentageECON < 90)
                creditpointsECON = 3;
            else if (percentageECON >= 70 && percentageECON < 80)
                creditpointsECON = 2;
            else if (percentageECON >= 60 && percentageECON < 70)
                creditpointsECON = 1;
            else
                creditpointsECON = 0;

            double creditpointsMIS;
            if (percentageMIS >= 90)
                creditpointsMIS = 4;
            else if (percentageMIS >= 80 && percentageMIS < 90)
                creditpointsMIS = 3;
            else if (percentageMIS >= 70 && percentageMIS < 80)
                creditpointsMIS = 2;
            else if (percentageMIS >= 60 && percentageMIS < 70)
                creditpointsMIS = 1;
            else
                creditpointsMIS = 0;


            //Calculating the total points EARNED:
            double totalPointsEarned = creditpointsACCT * perclassCREDITS +
                creditpointsECON * perclassCREDITS +
                creditpointsMIS * perclassCREDITS +
                creditpointsMKT * perclassCREDITS;

            //Calculating the total points POSSIBLE:
            double totalPointsPossible = perclassCREDITS * numberofCLASSES;

            //Caculating the overall GPA:
            double GPA = totalPointsEarned / totalPointsPossible;


            //Printing the LETTER GRADE of each class:
            Console.WriteLine("The letter grades for your classes are - ");
            Console.WriteLine("Accounting:   " + lettergradeACCT);
            Console.WriteLine("Marketing:   " + lettergradeMKT);
            Console.WriteLine("Economics:   " + lettergradeECON);
            Console.WriteLine("MIS:   " + lettergradeMIS);


            //Printing total GPA:
            Console.WriteLine("GPA:   " + GPA);
            Console.ReadKey();
        }
    }
}
