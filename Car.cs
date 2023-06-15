using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMatkonet15June23Solution
{
    public partial class Car
    {

    }

    public partial class CarGo
    {
        public void AddCar(Car car)
        {
            for (int i = 0; i < cars.Length; i++)
                if (cars[i] == null)
                {
                    cars[i] = car;
                    break;
                }
        }
        public Car LowCar()
        {
            int lowInd = 0;
            for (int i = 0; i < cars.Length; i++)
                if (cars[i] != null && cars[i].GetKm() <= cars[lowInd].GetKm())
                    lowInd = i;

            Car best = cars[lowInd];
            cars[lowInd] = null;
            return best;
        }

        public bool HaveCars(int num)
        {
            int count = 0;
            for (int i = 0; i < cars.Length; i++)
                if (cars[i] != null)
                    count++;

            return count >= num;    
        }

        public Car[] TakeCars(int num)
        {
            if (HaveCars(num))
            {
                Car[] cc = new Car[num];
                for (int i = 0; i < num; i++)
                    cc[i] = LowCar();
                return cc;
            }
            return new Car[0];  
        }
    }
}
