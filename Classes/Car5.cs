using System;
namespace ClassesExample
{
    public class Car
    {
        //Constructors
        public Car()
        {
            
        }
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = Year;
        }   

        

        //Create a Make property of type string that is public
        public string Make {  get; set; } //get = read set = write
        public string Model { get; set; } 
        public int Year { get; set; }






    }
}

