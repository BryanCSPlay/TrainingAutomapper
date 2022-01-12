using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingAutomapper.Models;

namespace TrainingAutomapper.Repositories
{
    public interface IClientRepository
    {
        Client GetClient();
    }

    public class ClientRepository : IClientRepository
    {
        public ClientRepository()
        {

        }

        public Client GetClient()
        {
            return new Client()
            {
                Id = 1,
                FirstName = "Braian",
                LastName = "Contreras",
                Email = "contreras@gmail.com",
                Phone = "431-123-1221-85",
                Address = new Address()
                {
                    City = "Buenos Aires",
                    Number = 1235,
                    Street = "Fashioncy"
                }
            };
        }
    }
}
