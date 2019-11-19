
using System;
using System.Collections.Generic;

namespace WorkingWithString
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //var nameoption = new List<string>();
             //nameoption.Add("eyasu");
             //nameoption.Add("kalle");
             //nameoption.Add("semhar");
             //nameoption.Insert(2,"amanuel");
             //nameoption.Remove("kalle");
             //Console.WriteLine($"name options" + nameoption);
             //Console.ReadLine();

             //########### WORKING WITH STRING

             //string myString = "SAY WHAT IS \"NAME\"OR YOU DIE";
             //string myString = "what if i need new line \nlike one on top of the ather";
             //string myString = "SAY WHAT IS \"NAME\"OR YOU DIE";
             //string myString = "go to yu c:\\ Data ";
             //string myString = @"go to your c:\ in yuor compu ter";
             //string myString = "SAY WHAT IS \"NAME\"OR YOU DIE";

             //string myString = string.Format("{2}={3}={0}", "152", "965","258","edu","mam");
             //string myString = "ati misaki msaki \"msaki eyu\" libey delo";
             //string myString = "ati misaki msaki \n\"msaki eyu\" \nlibey delo";
             //string myString = "ati misaki msaki \n\"msaki eyu\" \nlibey delo";
             //string myString = string.Format("carency:{0:c}", 456892);
             //string myString = string.Format(" space in between :{0:n}", 4568926556325323);
             //string myString = string.Format("phon number :{0:(####)#### ####}", 4568926556325323);
             //string myString = string.Format("persontag :{0:p}", 456892);
             string myString = "if you know how to go up you know how to go down";
             myString = myString.Replace(" ","**");
             myString = myString.ToUpper();

             Console.WriteLine(myString);
             Console.ReadLine();
             */

            var myCar = new Car();
            myCar.Make = "toyota";
            myCar.Model = "urban cruser";
            myCar.Year = 2010;
            myCar.Colour = "white";
            //myCar = myCar.Replace(" ", "**");
            
            Console.WriteLine("{0} {1} {2} {3}",myCar.Make, myCar.Model, myCar.Year, myCar.Colour);

            //decimal value =MarketValueTerminator(myCar);

            // Console.WriteLine("{0:c}", value);
            Console.WriteLine("{0:c}",myCar.DeterminingValu());
            
            Console.ReadLine();
        }
        public static decimal MarketValueTerminator(Car car)
        {
            decimal carvalue = 100.0M;
            return carvalue;
        }
        
    }

    class Car
    {

        public string Make { get; set; }
        public string Model { get; set; }
        public  int Year { get; set; }
        public string Colour { get; set; }

        public 
            decimal DeterminingValu()
        {
            decimal carvalue;
           
            if (Year > 1998)
                carvalue = 10000;
            else
                carvalue = 2000;
            return carvalue;
            
        }
    }


}
