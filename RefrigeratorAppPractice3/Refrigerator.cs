using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    public class Refrigerator
    {
        private double capacity;
        private double currentUsedCapacity;
        private double remainingCapacity;

        public Refrigerator( double capacity)
        {
            this.capacity = capacity;
            this.remainingCapacity = capacity;
        }
        public bool store(double items, double weight)
        {
            bool flag = false;
            double totalStoringAmount = items * weight;
            if (remainingCapacity >= totalStoringAmount)
            {
                currentUsedCapacity += totalStoringAmount;
                remainingCapacity -= totalStoringAmount;

                flag = true;
            }
            return flag;
        }
        public double getCurrentUsedCapacity()
        {
            return currentUsedCapacity;
        }
        public double getRemainingCapacity()
        {
            return remainingCapacity;
        }
    }
}
