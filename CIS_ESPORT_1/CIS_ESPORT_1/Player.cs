using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_ESPORT_1
{
    public class Player
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }
        public string Major { get; set; }
        public string Gname { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public int Age { get; set; }
        public Player(string name, string lastname, string id, string major, string gname, string mail, string tel, int age)
        {
            Name = name;
            LastName = lastname;
            ID = id;
            Major = major;
            Gname = gname;
            Mail = mail;
            Tel = tel;
            Age = age;
        }
    }
}
