using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var lot = new CarLot();

            


            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var myfriendscar = new Car();
        
            myfriendscar.Make = "Jeep";
            myfriendscar.Model = "Wrangler";
            myfriendscar.Year = 2023;
            myfriendscar.EngineNoise = "vroom vroom";
            myfriendscar.HonkNoise = "beep";
            myfriendscar.IsDrivable = true;

            lot.Cars.Add(myfriendscar);

            var mymomscar = new Car();

            mymomscar.IsDrivable = true;
            mymomscar.Make = "Nissan";
            mymomscar.EngineNoise = "move";
            mymomscar.Year = 2021;
            mymomscar.Model = "Altima";
            mymomscar.HonkNoise = "get out the way";

            lot.Cars.Add(mymomscar);

            var mycar = new Car(2020, "Jetta", "Volkswagen", "Im here!", " No smoke", true);

            lot.Cars.Add(mycar);

            myfriendscar.MakeEngineNoise(myfriendscar.EngineNoise);
            mymomscar.MakeEngineNoise(mymomscar.EngineNoise);
            mycar.MakeEngineNoise(mycar.EngineNoise);

            myfriendscar.MakeHonkNoise(myfriendscar.HonkNoise);
            mymomscar.MakeHonkNoise(mymomscar.HonkNoise);
            mycar.MakeHonkNoise(mycar.HonkNoise);


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of cars created: {CarLot.numberOfcars}");

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make {car.Make} Model {car.Model}");
            }
        }
    }
}
