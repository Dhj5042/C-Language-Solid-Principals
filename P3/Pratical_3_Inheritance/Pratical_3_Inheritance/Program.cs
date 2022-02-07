using System;

namespace Pratical_3_Inheritance
{
    class Sponsor
    {
        protected string owner="Rakuteen";
    }

    class Team:Sponsor
    {
        private string teamName = "DHJ";
        /// <summary>
        /// return type is string
        /// </summary>
        /// <returns></returns>
        public string printInfo()
        {
            return "Owner name is "+ owner +" TeamName is "+ teamName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //created object of class
            Team team = new Team();
            //return printinfo method
            Console.WriteLine("*********************************************");
            Console.WriteLine(team.printInfo());
            Console.WriteLine("*********************************************");
        }
    }
}
