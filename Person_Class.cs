using System;

namespace Person
{
    public class Person
    {
        private string name; 

        private string id; 

        public String Name 
        {
            get
            {
                return this.name;
            }

            set
            {
                if (IsValidName(value))
                {
                    this.name = value;
                }
            }
        }


        public String Id 
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



        public Person(string name, string id) 
        { 
            this.Name = name; 
            this.Id = id; 
        } 

 
        public static bool IsValidName(string name)
        {
            return name != "";
        } 
        public void IntroduceYourself() 
        { 
            Console.WriteLine( 
                $"Soy {this.Name} y mi cédula es {this.Id}"); 
        } 
    }




}
