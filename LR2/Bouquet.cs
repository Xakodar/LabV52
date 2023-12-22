using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    public class Bouquet
    {
        List<Flower> flowerList;

        public Bouquet()
        {
            flowerList = new List<Flower>();
        }

        public void addFlower(Flower flower) => flowerList.Add(flower);
        public void delFlower(int id)
        {
            if (id >= flowerList.Count) { throw new ArgumentException("В букете нет цветка с таким номером"); }
            flowerList.RemoveAt(id);
        }
        public void print() 
        {
            foreach (Flower flower in flowerList) { Console.WriteLine($"{flower.name} {flower.color} {!flower.isWilted()}"); }
        }
        public void setInWater()
        {
            foreach (Flower flower in flowerList) { flower.setInWater(); }
        }
        public void setOutWater()
        {
            foreach (Flower flower in flowerList) { flower.setOutWater(); }
        }
        public double price()
        {
            double price = 0;
            foreach (Flower flower in flowerList) { price += flower.price; }
            return price;
        }
        public double realPrice()
        {
            double price = 0;
            foreach (Flower flower in flowerList) { price += flower.realPrice(); }
            return price;
        }
        public double state()
        {
            double state = 0;  
            foreach (Flower flower in flowerList) { state += flower.State; }
            return state / flowerList.Count;
        }
        public int flowersCount() => flowerList.Count();
        public int wiltedCount() => flowerList.Count(flower => flower.isWilted());
        public void diffTime(double t)
        {
            foreach (Flower flower in flowerList) { flower.diffTime(t);}
        }
    }
}
