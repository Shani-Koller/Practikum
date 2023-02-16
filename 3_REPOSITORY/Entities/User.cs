using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_REPOSITORY.Entities
{
    public enum EGender { Male, Female }

    public enum EHMO { Maccabi, Klallit, Leumit, Meuchedet };
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }    
        public string LastName { get; set; }    
        public string PersonalNumber { get; set; }    
        public DateTime Dateofbirth { get; set; }
        public EGender Gender { get; set; }
        public EHMO HMO { get; set; }
        public List<Child> children { get; set; }
    }
}
