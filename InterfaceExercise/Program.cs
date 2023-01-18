using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany - DONE

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle - DONE

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany - DONE

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes - DONE

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var vehicles = new List<IVehicle>();
            var sedan = new Car()
            {
                Name = "Bentley FlyingSpur",
                CorpName = "BrandX",
                Motto = "Best Brand X Ever!",
                HowManyWheels = 4,
                HasLeatherSeats = true,
                HasSteeringWheel = true,
                HasStereo = true,
                HasSunRoof = true,
                HasTrunk = true
            };
            vehicles.Add(sedan);

            var pickup = new Truck()
            {
                Name = "Ford F-150",
                CorpName = "Landscapers Inc",
                Motto = "Trimmin Trees",
                HasSteeringWheel = true,
                HasStereo = false,
                HasSunRoof = false,
                HasTruckBed = true,
                HowManyWheels = 4,
                HasTowHook = true
            };
            vehicles.Add(pickup);

            var suv1 = new SUV()
            {
                Name = "LandRover Range Rover",
                CorpName = "Range Inc",
                Motto = "Range Freely!",
                FourWheelDrive = true,
                HasCargo = true,
                HasStereo = true,
                HasSteeringWheel = true,
                HasSunRoof = true,
                HowManyWheels = 4
            };

            vehicles.Add(suv1);

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"Vehicle {veh.Name.ToString().ToLower()} has {veh.HowManyWheels} wheels. It is {veh.HasSteeringWheel.ToString().ToLower()} it has a steering wheel. It is {veh.HasStereo.ToString().ToLower()}  it has a stereo. It is also  {veh.HasSunRoof.ToString().ToLower()} that it has a sunroof.");

                Console.WriteLine();
            }


        }
    }
}
