/**
    Este código foi desenvolvido por: Gabriel Santana, Izabel Mendes, Odin Oliveira
    Para disciplina de Teste de Software - IFPE - 2022.2
 */

using HospitalUnitTest.Enums;

namespace HospitalUnitTest.Models
{
    public class Patient : Person
    {
        public Illnesses Illnesses { get; set; }

        public Patient()
        {

        }
        public Patient(string name, string cpf, int yearsOld) : base(name, cpf, yearsOld)
        {
        }

        public void SetIllness(Illnesses illnesses)
        {
            Illnesses = illnesses;
        }
    }
}