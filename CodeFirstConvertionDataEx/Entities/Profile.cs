using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConvertionDataEx.Entities
{
    public class Profile
    {

        public int Id { get; set; }
        public string Bio { get; set; }
        public User User { get; set; }

    }
}
