using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Car
    {


        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }


        //TODO
        public Car()
        {

        }
        public Car(int y, string mak, string mod, string en, string hn, bool drive)
        {
            Year = y;
            Make = mak;
            Model = mod;
            EngineNoise = en;
            HonkNoise = hn;
            IsDriveable = drive;
        }

        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property

        public void MakeEngineNoise(string noise)
        {
            Console.WriteLine(noise);
        }
        public void MakeHonkNoise(string honk)
        {
            Console.WriteLine(honk);
        }
    }
}
