using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingAutomapper.Dto
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }

        public string AddressStreet { get; set; }
        public int AddressNumber { get; set; }
        public string AddressCity { get; set; }
    }
}
