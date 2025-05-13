using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab072
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double VEngine { get; set; }
        public string TypeFuel { get; set; }
        public int Probig { get; set; }
        public double SerednyaVitrataFuel { get; set; }
        public double Price { get; set; }
        public double FuelPrice { get; set; }
        public double GetFuelPricePer100Km()
        {
            return SerednyaVitrataFuel * FuelPrice;
        }
        public Car()
        {

        }
        public Car(string brand, string model, int year, double vEngine, string typeFuel, int probig, double serednyaVitrataFuel, double price, double fuelPrice)
        {
            Brand = brand;
            Model = model;
            Year = year;
            VEngine = vEngine;
            TypeFuel = typeFuel;
            Probig = probig;
            SerednyaVitrataFuel = serednyaVitrataFuel;
            Price = price;
            FuelPrice = fuelPrice;
        }
    }
}
