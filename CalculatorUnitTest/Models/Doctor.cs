using HospitalUnitTest.Models;

namespace HospitalUnitTest.Models
{
    public class Doctor : Person
    {
        public string Id { get; set; }

        public Doctor()
        {

        }

        public Doctor(string name, string cpf, int yearsOld, string id) : base(name, cpf, yearsOld)
        {
            Id = id;
        }
    }
}
