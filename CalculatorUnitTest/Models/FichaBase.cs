/**
    Este código foi desenvolvido por: Gabriel Santana, Izabel Mendes, Odin Oliveira
    Para disciplina de Teste de Software - IFPE - 2022.2
 */

using CalculatorUnitTest.Interfaces;

namespace CalculatorUnitTest.Models
{
    public class FichaBase : IFicha
    {
        public Patient Patient { get; set; }
        public Attendant Attendant { get; set; }

        public void Save(Patient patient, Attendant attendant)
        {
            Patient = patient;
            Attendant = attendant;
        }
    }
}
