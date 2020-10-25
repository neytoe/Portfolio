using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetoPortfolio.Models
{
    public class PersonRepository: IPersonRepository
    {
        private List<Person> Neto;

        public PersonRepository()
        {
           Neto = new List<Person>()
            {
                new Person {
                    FirstName = "Netochukwu",
                    LastName = "Anyankah",
                    Image = "img/IMG_20200902_111852.jpg",
                    About = "A highly motivated and experienced C# Developer/Programmer" +
                    "using object oriented design techniques and microsoft .NET Technologies to create user friendly, scalable and reliable applications/software Applications",
                    Skills= new List<string>
                    {
                        "Micorsoft .Net,C#, ASP.NET CORE",
                        "HTML,CSS,JAVASCRIPT",
                        "AGILE DEVELOPMENT",
                        "GIT & GITHUB"
                    },
                    WorkPhotos = new List<WorkPhoto>
                    {
                       new WorkPhoto {
                           Photo = "img/bankimage.jpg",
                           Link = "https://github.com/neytoe/bankapp_refactored_week4"
                        }, 
                       new WorkPhoto
                       {
                           Photo = "img/calcc.jpg",
                           Link = "https://github.com/neytoe/SimpleCalculator"
                       },
                       new WorkPhoto
                       {
                           Photo = "img/shoppingCart.jpg",
                           Link = "https://github.com/neytoe/Entity-Framework-Core"
                       }
                    }
                }
            };
        }
              
        public Person GetPortfolio()
        {
            return Neto.FirstOrDefault();
        }
    }
}
