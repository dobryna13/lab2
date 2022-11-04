using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class Converter
    {
        private double usd;
        private double eur;
        private double rub;
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        public double ConvertUsd(double sum)=>sum * usd;
        public double ConvertEur(double sum)=>sum * eur;
        public double ConvertRub(double sum)=>sum * rub;
        public double ConvertToUsd(double sum)=>sum / usd;
        public double ConvertToEur(double sum)=>sum / eur;
        public double ConvertToRub(double sum)=>sum / rub;
    }
}
