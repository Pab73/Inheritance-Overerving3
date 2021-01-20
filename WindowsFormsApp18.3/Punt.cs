using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp18._3
{
    class Punt
    {
        private double _x;
        private double _y;

        public double X
        {
            get => _x;
            set => _x = value;
        }
        public double Y
        {
            get => _y;
            set => _y = value;
        }
        public Punt()
        {
            X = _x;
            Y = _y;
        }
        public Punt(double x, double y)
        {
            X = x;
            Y = y;
        }
        public string Gegevens()
        {
            return $"({X}, {Y}) ";
        }
    }
    class Cirkel : Punt
    {
        private double _r;
        public double R
        {
            get => _r;
            set => _r = value;
        }
        public Cirkel()
        {
            R = _r;
        }
        public Cirkel(double x, double y, double r) : base(x, y)
        {
            R = r;
        }
        public double Omtrek()
        {
            return 2 * Math.PI * R;
        }
        public double Oppervlakte()
        {
            return Math.PI * Math.Pow(R, 2);
        }
        public new string Gegevens()
        {
            return base.Gegevens() + $"straal {R} ";
        }
        //public override string ToString()
        //{
        //    return base.ToString() + $"straal {Gegevens()} ";
        //}
    }
    class Cilinder : Cirkel
    {
        private double _h;
        public double H
        {
            get => _h;
            set => _h = value;
        }
        public Cilinder()
        {
            H = _h;
        }
        public Cilinder(double x, double y, double r, double h) : base(x, y, r)
        {
            H = h;
        }
        public double Volume()
        {
            return Math.PI * Math.Pow(R, 2) * H;
        }
        public double Oppervlakte()
        {
            return (2 * Math.PI * Math.Pow(R, 2)) + (2 * Math.PI * R * H);
        }
        public new string Gegevens()
        {
            return base.Gegevens() + Environment.NewLine + $"hoogte = {H} \n" +
                $"oppervlakte = {Oppervlakte():0.00} \n" +
                $"volume = {Volume():0.00} ";
        }
    }
}
