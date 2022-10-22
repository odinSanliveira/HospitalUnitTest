/**
    Este código foi desenvolvido por: Gabriel Santana, Izabel Mendes, Odin Oliveira
    Para disciplina de Teste de Software - IFPE - 2022.2
 */

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