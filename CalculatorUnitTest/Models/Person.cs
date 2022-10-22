using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUnitTest.Models
{
    public abstract class Person
    {
        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        private string cpf;

        public string GetCpf()
        {
            return cpf;
        }

        public void SetCpf(string value)
        {
            cpf = value;
        }

        private int yearsOld;

        public int GetBirthday()
        {
            return yearsOld;
        }

        public void SetBirthday(int value)
        {
            yearsOld = value;
        }

        public Person() { }
        public Person(string name, string cpf, int yearsOld)
        {
            this.name = name;
            this.cpf = cpf;
            this.yearsOld = yearsOld;
        }

    }
}
