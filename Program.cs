using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Collections;

namespace Final_Project
{
    class Program
    {
        static void Main(string[] args)
        {
           // try
          //  {
                //accept and hacle command line args
                
                string fileName = "CrimeData.csv";
                StreamReader sr1 = new StreamReader(fileName);
            string rep = "report";
            StreamWriter sw1 = new StreamWriter(rep);

                List<CrimeStats> crimeStatsList = new List<CrimeStats>();
                string line1A = sr1.ReadLine();
                while (line1A != null)
                {
                    

                    string lineB = sr1.ReadLine();
                    
                    string[] array2 = lineB.Split(',');
                    
                    CrimeStats crimeStatObj = new CrimeStats();
                    crimeStatObj.Year = Convert.ToDouble(array2[0]);
                   
                    crimeStatObj.Pop = Convert.ToDouble(array2[1]);
                    
                    crimeStatObj.ViolentCrime = Convert.ToDouble(array2[2]);
                    
                    crimeStatObj.Murder = Convert.ToDouble(array2[3]);
                    
                    crimeStatObj.Rape = Convert.ToDouble(array2[4]);
                    
                    crimeStatObj.Robbery = Convert.ToDouble(array2[5]);
                    
                    crimeStatObj.AggAssault = Convert.ToDouble(array2[6]);
                    
                    crimeStatObj.PropCrime = Convert.ToDouble(array2[7]);
                    
                    crimeStatObj.Burglary = Convert.ToDouble(array2[8]);
                    
                    crimeStatObj.Theft = Convert.ToDouble(array2[9]);
                    
                    crimeStatObj.MotorTheft = Convert.ToDouble(array2[10]);
                    

                   
                    crimeStatsList.Add(crimeStatObj);



                    
                }
               

                //1.    range of years included
                var maxyears = from crimeStatObj in crimeStatsList where crimeStatObj.Year >= 2013 select (crimeStatObj.Year);
                var minyears = from crimeStatObj in crimeStatsList where crimeStatObj.Year <= 1994 select (crimeStatObj.Year);

            //2.    how many years of data are included
            var countyears = crimeStatsList.Count;
                

                //3.    What years is the number of murders per year less than 15000
                var yearsmurder15k = from crimeStatObj in crimeStatsList where crimeStatObj.Murder < 15000 select crimeStatObj.Year;

            //4.	What are the years and associated robberies per year for years where the number of robberies is greater than 500000
            var yearsrobbery500k, robbery500k = from crimeStatObj in crimeStatsList where crimeStatObj.Robbery > 500000 orderby crimeStatObj.Year, crimeStatObj.Robbery;

                //5.    What is the violent crime per capita rate for 2010? Per capita rate is the number of violent crimes in a year divided by the size of the population that year?
                var violentcrimepercapita = from crimeStatObj in crimeStatsList where crimeStatObj.Year == 2010 select crimeStatObj.ViolentCrime / crimeStatObj.Pop;

                //6.    What is the average number of murders per year across all years?
                var years = from crimeStatObj in crimeStatsList select (crimeStatObj.Murder) / 2;

                //7.	What is the average number of murders per year for 1994 to 1997?
                var avgmurder9497 = from crimeStatObj in crimeStatsList where crimeStatObj.Year >= 1994 && crimeStatObj.Year <= 1997 select (crimeStatObj.Murder) / 2;

                //8.	What is the average number of murders per year for 2010 to 2013?
                var avgmurder1013 = from crimeStatObj in crimeStatsList where crimeStatObj.Year >= 2010 && crimeStatObj.Year <= 2013 select (crimeStatObj.Murder) / 2;

                //9.	What is the minimum number of thefts per year for 1999 to 2004?
                var mintheft9904 = from crimeStatObj in crimeStatsList where crimeStatObj.Year >= 1999 && crimeStatObj.Year <= 2004 select min(crimeStatObj.Theft);

                //10.	What is the maximum number of thefts per year for 1999 to 2004?
                var maxtheft9904 = from crimeStatObj in crimeStatsList where crimeStatObj.Year >= 1999 && crimeStatObj.Year <= 2004 select max(crimeStatObj.Theft);

                //11.	What year had the highest number of motor vehicle thefts?
                var maxmotortheft = from crimeStatObj in crimeStatsList group by crimeStatObj.Year having max(crimeStatObj.motorTheft) select crimeStats.Year;
            //string[] dataFile = File.ReadAllLines(fileName); 
            using (StreamWriter write = File.CreateText(rep))
            {
                Console.WriteLine("Period: {1} - {2} ({3} years)", maxyears, minyears, countyears);
                Console.WriteLine("Years murders per year < 15000: {1}", yearsmurder15k);
                Console.WriteLine("Robberies per year > 500000: {1}", robbery500k);
                Console.WriteLine("Violent crime per capita rate (2010): {1}", violentcrimepercapita);
                Console.WriteLine("Average murder per year (all years): {1}", years);
                Console.WriteLine("Average murder per year (1994-1997): {1}", avgmurder9497);
                Console.WriteLine("Average murder per year (2010-2014): {1}", avgmurder1013);
                Console.WriteLine("Minimum thefts per year (1999-2004): {1}", mintheft9904);
                Console.WriteLine("Maximum thefts per year (1999-2004): {1}", maxtheft9904);
                Console.WriteLine("Year of highest number of motor vehicle thefts: {1}", maxmotortheft);

            }
            }

        

        //   catch (Exception E)
        //    {

        //        Console.WriteLine("error message",E);
        //    }



        
        }

        
    }
}
