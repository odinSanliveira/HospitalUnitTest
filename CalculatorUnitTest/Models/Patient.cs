using CalculatorUnitTest.Enums;

namespace CalculatorUnitTest.Models
{
    public class Patient : Person
    {
        public Illnesses Illnesses { get; set; }
        
        public Patient(string name, string cpf, int yearsOld, Illnesses illnesses) : base(name, cpf, yearsOld)
        {
            this.Illnesses = illnesses;
        }
    }
}