using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class EmpData
    {
        private String name;
        private int id;
        private int age;
        public void setName(String name)
        {
            Boolean isNameRight = name.All(char.IsLetter);
            if (isNameRight)
            {
                this.name = name;
            }
            else
            {
                throw new NameNotValid("Name should not contain any number or special character");
            }
           
        } 
        public String getName()
        {
            return name;
        }
        public void setAge(int age)
        {
            if (age > 30)
            {
                throw new EmpAgeNotValid("you are out of age");
            }
            else
            {
                this.age = age; 
            }
        }
        public int getAge()
        {
            return age;
        }
        public void setId(int id) 
        {
            if (id < 0)
            {
                throw new IdNotNegative("id can not be negative");
            }
            else { this.id = id; }
            
        }
        public int getId()
        {
            return id;
        }


    }
}
