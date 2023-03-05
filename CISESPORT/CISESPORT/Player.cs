using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISESPORT
{
    public class Player
    {
        public string name, lastName, studentid, major, displayname, mail, phone;
        public int age = 0;

        Player(string name , string lastName, string studentid,string major,string displayanme , string mail , string phone ,int age) 
        {
            this .name = name;
            this .lastName = lastName;
            this .studentid = studentid;
            this .major = major;
            this .displayname = displayanme;
            this .mail = mail;
            this .phone = phone;
            this .age = age;

        }
    }
}
