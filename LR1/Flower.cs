using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LR1
{
    public enum colors { white, red, purple, blue }
    public class Flower
    {
        public string name { get; }
        public colors color { get; }
        private double state;
        public double State { get { return state; } set { state = value; if (state < 0) state = 0; } }
        public double rateWitheringInWater { get; }
        public double rateWitheringWithoutWater { get; }
        public bool inWater { get; private set; }
        public double price { get; }

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
