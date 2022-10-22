using CalculatorUnitTest.Interfaces;

namespace CalculatorUnitTest.Models
{
    public class FichaBase : IFicha
    {
        public Patient Patient { get; set; }
        public Attendant Attendant { get; set; }

        public virtual void Save(Patient patient, Attendant attendant)
        {
            Patient = patient;
            Attendant = attendant;
        }
    }
}
