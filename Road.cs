using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMatkonet15June23Solution
{

    //Q4 א
    public partial class Accident
    {
        private int accidentType;
        private bool isYoungDriver;
        private string causeOfAccident;

        public Accident(int accidentTyp, bool isYoung, string cause)
        {
            accidentType = accidentTyp;
            isYoungDriver = isYoung;
            causeOfAccident = cause;
        }
    }

    //Q4 ב
    public partial class Road //partial נא להתעלם מה 
    {

        private int roadNum;
        Accident[] arr = new Accident[1000];
        int current = 0;

        public Road(int roadNm)
        {
            roadNum = roadNm;
            //arr = new Accident[1000]; אפשר כאן ואפשר למעלה
        }

        public int YoungAccidents()
        {
            int count = 0;
            for (int i = 0; i < current; i++)
                if (arr[i].GetIsYoungDriver())
                    count++;

            return count;
        }


    }
}
