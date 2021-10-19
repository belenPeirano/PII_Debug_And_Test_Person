using System;

namespace UnitTestAndDebug
{
    public class Person
    {
        public Person(string name, string id, string fechaNac)
        {
            this.Name = name;
            this.ID = id;
            this.FechaNac = fechaNac;
        }

        private string fechaNac; //property

        private string name;

        private string id;

        public string FechaNac
        {
            get
            {
                return this.FechaNac;
            }
            
            set
            {
                string[] partes = value.Split("/");
                int dia = Int32.Parse(partes[0]);
                int mes = Int32.Parse(partes[1]);
                int año = Int32.Parse(partes[3]);

                if (( dia > 1 && dia < 30) && ( mes > 1 && mes < 12) && (año > 1700))
                {
                    this.FechaNac = value;
                }
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }
        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
            }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Soy {this.Name} y mi cédula es {this.ID}");
        }
    }
}
