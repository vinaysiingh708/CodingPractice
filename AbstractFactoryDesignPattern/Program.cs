using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    // What is Abstract Factory ?
    //A super-factory that creates other factories, each responsible for creating families of related objects.
    public interface ICar 
    {
        void Manufacture();
    };

    public interface IBike 
    {
        void Manufacture();
    };

    public class TataCar : ICar
    {
        public void Manufacture() { }
    }

    public class TataBike : IBike
    {
        public void Manufacture() { }
    }

    public class TeslaCar : ICar
    {
        public void Manufacture() { }
    }

    public class TeslaBike : IBike
    {
        public void Manufacture() { }
    }

    // This is abstract factory which will return factory of similar objects 
    // example Tata, Tesla, Maruti
    public abstract class VehicleCompanyFactory
    {
        public abstract ICar GetCar();
        public abstract IBike GetBike();
    }

    // This is a factory of similar object which will actually create the objects
    public class TeslaCompany : VehicleCompanyFactory
    {
        public override IBike GetBike()
        {
            return new TeslaBike();
        }

        public override ICar GetCar()
        {
            return new TeslaCar();
        }
    }

    public class TataCompany : VehicleCompanyFactory
    {
        public override IBike GetBike()
        {
            return new TataBike();
        }

        public override ICar GetCar()
        {
            return new TataCar();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            VehicleCompanyFactory teslaCarCompany = new TeslaCompany();
            ICar teslaCar = teslaCarCompany.GetCar();
            IBike teslaBike = teslaCarCompany.GetBike();

            VehicleCompanyFactory tataCarCompany = new TeslaCompany();
            ICar tataCar = tataCarCompany.GetCar();
            IBike tataBike = tataCarCompany.GetBike();
        }
    }
}
