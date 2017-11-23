using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN_Forms
{
    public enum CarType { Personal, Truck, Bike }

    public class Car
    {
        public int ID { get; set; }
        public String Brand { get; set; }
        public int MaxVelocity { get; set; }
        public int ProdYear { get; set; }
        public CarType Type { get; set; }

        public override String ToString()
        {
            return Brand + ", " + ProdYear;
        }

        public Car(int ID, String Brand, int MaxVelocity, int ProdYear, CarType Type)
        {
            this.ID = ID;
            this.Brand = Brand;
            this.MaxVelocity = MaxVelocity;
            this.ProdYear = ProdYear;
            this.Type = Type;
        }
    }
}
