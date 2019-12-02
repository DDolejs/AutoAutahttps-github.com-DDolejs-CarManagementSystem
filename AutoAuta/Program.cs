using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutoAuta
{
    public enum Weather { Zataženo, Deštivo, Kalamita }
    public enum TypTerenu { Rovina, Most, Tunel }

    public class WeatherGenerator
    {
        public Weather Generuj(Random r)
        {
            Weather[] wArr = { Weather.Zataženo, Weather.Deštivo, Weather.Kalamita };
            return wArr[r.Next(wArr.Length)];

        }
    }
    public class Vehicle
    {
        public Vehicle(double speed, 
            bool lights, 
            double lenght, 
            string[] pathArr)
        {
            Speed = speed;
            Lights = lights;
            Lenght = lenght;
            PathArr = pathArr;
        }
        double Speed { get; set; }
        bool Lights { get; set; }
        double Lenght { get; set; }
        string[] PathArr { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
