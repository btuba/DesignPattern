using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Builder.Lib.v3
{
    // immutable değişmeyen nesne
    public class Car
    {
        string _brand; // string immutable bir sınıf += kullanma ram'de yeni yer açmak zorunda!
        string _model;

        //public string Brand { get { return _brand; } private set { _brand = value; } }
        //public string Model { get { return _model; } private set { _model = value; } }

        protected Car(string brand, string model)
        {
            _brand = brand;
            _model = model;
        }

        public static ICarBuilder GetCarBuilder()
        {
            return new CarBuilder();
        }

        class CarBuilder : ICarBuilder // nested type , ListBox -> ListItem
        {
            public Car BuildCar(string brand, string model)
            {
                return new Car(brand, model);
            }
        }
    }
}
