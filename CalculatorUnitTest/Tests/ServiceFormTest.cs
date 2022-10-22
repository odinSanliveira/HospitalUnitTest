/**
Este código foi desenvolvido por: Gabriel Santana, Izabel Mendes, Odin Oliveira
Para disciplina de Teste de Software - IFPE - 2022.2
*/

using HospitalUnitTest.Enums;
using HospitalUnitTest.Models;
using System.Collections.Generic;
using Xunit;

namespace HospitalUnitTest.Tests
{
    public class ServiceFormTest
    {
        List<Patient> patients;
        Patient patient1;
        Patient patient2;

        [Fact]
        public void AddPatientFormToSystem()
        {
            patients = new List<Patient>();
            patient1 = new Patient("Izabel", "123.456.789-00", 21);
            patient1.SetIllness(Illnesses.UNKNOWN);

            patients.Add(patient1);

            Assert.Contains(patients[0].GetName(), patient1.GetName());
        }
    }
}
