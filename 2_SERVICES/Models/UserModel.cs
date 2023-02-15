using _3_REPOSITORY.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_SERVICES.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalNumber { get; set; }
        public DateTime Dateofbirth { get; set; }
        public EGender Gender { get; set; }
        public EHMO HMO { get; set; }
    }
}
