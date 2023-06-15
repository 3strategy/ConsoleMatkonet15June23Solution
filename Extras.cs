using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMatkonet15June23Solution
{
    // כאן כתובים חלקים של מחלקות שנתונים לכם ולא צריכים לכתוב אותם בבחינה זו
    public partial class Accident
    {
        public int GetAccidentType()
        {
            return accidentType;
        }
        public void SetAccidentType(int value)
        {
            accidentType = value;
        }

        public bool GetIsYoungDriver()
        {
            return isYoungDriver;
        }
        public void SetIsYoungDriver(bool value)
        {
            isYoungDriver = value;
        }
        public string GetCauseOfAccident()
        {
            return causeOfAccident;
        }
        public void SetCauseOfAccident(string value)
        {
            causeOfAccident = value;
        }
    }
    public partial class Road
    {
        public int GetRoadNum()
        {
            return roadNum;
        }
        public void SetRoadNum(int value)
        {
            roadNum = value;
        }
    }

    public partial class Car
    {

        private int idNum;

        private int year;

        private double km;

        public Car(int idNum, int year, double km)
        {
            this.idNum = idNum;
            this.year = year;
            this.km = km;
        }

        public double GetKm()
        {
            return km;
        }
        public void SetKm(double value)
        {
            km = value;
        }
        public int GetYear()
        {
            return year;
        }
        public void SetYear(int value)
        {
            year = value;
        }
        public int GetIdNum()
        {
            return idNum;
        }
        public void SetIdNum(int value)
        {
            idNum = value;
        }
    }
    public partial class CarGo
    {

        private string street;
        Car[] cars;
        public CarGo(string street, int max)
        {
            this.street = street;
            cars = new Car[max];
        }

        public string GetStreet()
        {
            return street;
        }
        public void SetStreet(string value)
        {
            street = value;
        }
    }
}

