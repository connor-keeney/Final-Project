using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class CrimeStats
    {
        double year = 0;
        double pop = 0;
        double violentCrime = 0;
        double murder = 0;
        double rape = 0;
        double robbery = 0;
        double aggAssault = 0;
        double propCrime = 0;
        double burglary = 0;
        double theft = 0;
        double motorTheft = 0;

        public CrimeStats()
        {
        }

        public CrimeStats(double year, double pop, double violentCrime, double murder, double rape, double robbery, double aggAssault, double propCrime, double burglary, double theft, double motorTheft)
        {
            this.year = year;
            this.pop = pop;
            this.violentCrime = violentCrime;
            this.murder = murder;
            this.rape = rape;
            this.robbery = robbery;
            this.aggAssault = aggAssault;
            this.propCrime = propCrime;
            this.burglary = burglary;
            this.theft = theft;
            this.motorTheft = motorTheft;
        }

        public double Year { get => year; set => year = value; }
        public double Pop { get => pop; set => pop = value; }
        public double ViolentCrime { get => violentCrime; set => violentCrime = value; }
        public double Murder { get => murder; set => murder = value; }
        public double Rape { get => rape; set => rape = value; }
        public double Robbery { get => robbery; set => robbery = value; }
        public double AggAssault { get => aggAssault; set => aggAssault = value; }
        public double PropCrime { get => propCrime; set => propCrime = value; }
        public double Burglary { get => burglary; set => burglary = value; }
        public double Theft { get => theft; set => theft = value; }
        public double MotorTheft { get => motorTheft; set => motorTheft = value; }

        private bool CheckForGenerics()
        {
            bool retVal = false;
            if (IsNumber(this.Year) && IsNumber(this.Pop) && IsNumber(this.ViolentCrime) && IsNumber(this.Murder) && IsNumber(this.Rape) && IsNumber(this.Robbery) && IsNumber(this.AggAssault) && IsNumber(this.PropCrime) && IsNumber(this.Burglary) && IsNumber(this.Theft) && IsNumber(this.MotorTheft))
            {
                retVal = true;
            }
            return retVal;
        }

        private bool IsNumber(double year)
        {
            throw new NotImplementedException();
        }
    }
}
