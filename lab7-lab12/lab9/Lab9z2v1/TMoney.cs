using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9z2v1
{
    class TMoney
    {
        private double sumdol_;
        private double kursdol_;
        
        public double sumdol
        {
            get { return sumdol_; }
            set
            {
                sumdol_ = value;
            }
        }
        public double kursdol
        {
            get { return kursdol_; }
            set
            {
                if (value > 0) kursdol_ = value;
            }
        }
        public TMoney (double sumdol, double kursdol)
        {
            this.sumdol = sumdol;
            this.kursdol = kursdol;
        }

        public string grndoldod(double grndod)
        {
            sumdol += grndod / kursdol;
            return $"Грошова сума = {sumdol}$";
        }

        public string grndolvid(double grnvid)
        {
            sumdol -= grnvid / kursdol;
            return $"Грошова сума = {sumdol}$";
        }

        public string strkursdol()
        {
            return $"Курс долара = {kursdol}";
        }

        public string str()
        {
            return $"Грошова сума = {sumdol}$";        
        }
    }
}
