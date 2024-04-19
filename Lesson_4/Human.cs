using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    [Serializable]
    public class Human
    {
        string name;
        string surname;
        string telephone;
        string email;

        public Human()
        {
            name = "";
            surname = "";
            telephone = "";
            email = "";
        }

        public Human(string name, string surname, string telephone, string email)
        {
            this.name = name;
            this.surname = surname;
            this.telephone = telephone;
            this.email = email;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public override string ToString() 
        {
            return string.Format(name + " " + surname);
        }
    }
}
