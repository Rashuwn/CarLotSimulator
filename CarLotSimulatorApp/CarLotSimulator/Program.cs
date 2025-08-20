using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLotOne = new CarLot();
            
            
            var carOne = new Car();
            carOne.Year = 2022;
            carOne.Make = "Ram";
            carOne.Model = "1500 TRX";

            carOne.MakeEngineNoise("Vroom");
            carOne.MakeHonkNoise("Honk");
            carOne.IsDriveable = true;
            
            carLotOne.ParkingLot.Add(carOne);
            

            var carTwo = new Car()
            {
                Year = 1996,
                Make = "Chevy",
                Model = "Impala SS",
                IsDriveable = true



            };

            carTwo.MakeEngineNoise("Roar");
            carTwo.MakeHonkNoise("Honk Honk");
            
            carLotOne.ParkingLot.Add(carTwo);
            


            var carThree = new Car("Lexus", "GX 550", 2024, true);
            
            carThree.MakeEngineNoise("Vroom, Vroom");
            carThree.MakeHonkNoise("Beep");
            
            carLotOne.ParkingLot.Add(carThree);
            
            carLotOne.CheckCars();
            
            var carFour = new Car(make: "Chevy", model: "C10", year: 1980, isDriveable: true);
            carFour.MakeEngineNoise("Roar Roar");
            
            carLotOne.ParkingLot.Add(carFour);
            carLotOne.CheckCars();

            var carFive = new Car(make: "Chevy", model: "Malibu", year: 1998, isDriveable: false);
            carFive.MakeEngineNoise("click click click");
            
            carLotOne.ParkingLot.Add(carFive);
            carLotOne.CheckCars();
            
            Console.WriteLine($"Number of Cars in the lot is: {carLotOne.ParkingLot.Count}");








            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
