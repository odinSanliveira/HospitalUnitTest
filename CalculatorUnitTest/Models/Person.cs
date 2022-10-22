/**
    Este código foi desenvolvido por: Gabriel Santana, Izabel Mendes, Odin Oliveira
    Para disciplina de Teste de Software - IFPE - 2022.2
 */

namespace HospitalUnitTest.Models
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
