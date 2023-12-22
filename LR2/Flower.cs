using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LR2
{
    public enum colors { white, red, purple, blue}
    public class Flower
    {
        public string name { get;}
        public colors color { get; }
        private double state;
        public double State { get { return state; } set { state = value; if (state < 0) state = 0; } }
        private double _rateWitheringInWater;
        public double rateWitheringInWater { get { return _rateWitheringInWater; } set { _rateWitheringInWater = value; if (_rateWitheringInWater < 0) _rateWitheringInWater = 0; } }
        private double _rateWitheringWithoutWater;
        public double rateWitheringWithoutWater { get { return _rateWitheringWithoutWater; } set { _rateWitheringWithoutWater = value; if (_rateWitheringWithoutWater < 0) _rateWitheringWithoutWater = 0; } }
        public bool inWater { get; private set; }
        private double _price;
        public double price { get { return price; } set { _price = value; if (_price < 0) _price = 0; } }

        public Flower(string name, colors color, double rateWitheringInWater, double rateWitheringWithoutWater, double price)
        {
            this.name = name; 
            this.color = color;
            this.rateWitheringInWater = rateWitheringInWater;
            this.rateWitheringWithoutWater = rateWitheringWithoutWater;
            this.price = price;
            this.state = 1;
            this.inWater = false;
        }

        public bool isWilted() => state == 0;
        public void setInWater() => inWater = true;
        public void setOutWater() => inWater = false;
        public double realPrice() => price * state;
        public void diffTime(double t)
        {
            if (inWater)
                this.State -= t * rateWitheringInWater;
            else
                this.State -= t * rateWitheringWithoutWater;
        }
    }
}
