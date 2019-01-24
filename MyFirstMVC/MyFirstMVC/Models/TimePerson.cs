using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace MyFirstMVC.Models
{
    public class TimePerson
    {
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }
        
        public static List<TimePerson> GetPersons(int startYear, int endYear)
        {
            List<TimePerson> people = new List<TimePerson>();
            string path = Environment.CurrentDirectory;
            string newPath = Path.GetFullPath(Path.Combine(path, @"C:\Users\casti\coding\codeFellows\code401\Lab11-MyFirstMVCApp\MyFirstMVC\MyFirstMVC\wwwroot\personOfTheYear.csv"));

            string[] newFile = File.ReadAllLines(newPath);
             
            for (int i = 1; i < newFile.Length; i++)
            {
                string[] field = newFile[i].Split(','); ;

                people.Add(new TimePerson
                {
                    //turinery opers
                    Year = (field[0] == "") ? 0 : Convert.ToInt32(field[0]),
                    Honor = field[1],
                    Name = field[2],
                    Country = field[3],
                    BirthYear = (field[4] == "") ? 0 : Convert.ToInt32(field[4]),
                    DeathYear = (field[5] == "") ? 0 : Convert.ToInt32(field[5]),
                    Title = field[6],
                    Category = field[7],
                    Context = field[8],
                });
            }
            List<TimePerson> displayOfPeople = people.Where(x =>(x.Year >= startYear) && (x.Year <= endYear)).ToList();
            return displayOfPeople;
        }
        
    }
}
