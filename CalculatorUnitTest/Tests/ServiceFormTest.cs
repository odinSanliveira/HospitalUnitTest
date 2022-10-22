/**
Este código foi desenvolvido por: Gabriel Santana, Izabel Mendes, Odin Oliveira
Para disciplina de Teste de Software - IFPE - 2022.2
*/

using HospitalUnitTest.Enums;
using HospitalUnitTest.Exceptions;
using HospitalUnitTest.Models;
using System.Collections.Generic;
using Xunit;

namespace HospitalUnitTest.Tests
{
    public class ServiceFormTest
    {
        public List<Patient> Patients;
        public List<ServiceForm> Services;
        public Patient PatientOne;
        public Patient PatientTwo;

        public ServiceForm ServiceForm;

        public Attendant Attendant;

        public Doctor Doctor;

        [Fact]
        public void AddPatientFormToSystem()
        {
            Patients = new List<Patient>();
            PatientOne = new Patient("Izabel", "123.456.789-00", 21);
            PatientOne.SetIllness(Illnesses.UNKNOWN);

            Patients.Add(PatientOne);

            ServiceForm.VerifyIfPatientExist(Patients, PatientOne);

            Assert.Contains(Patients[0].GetName(), PatientOne.GetName());
        }

        [Fact]
        public void PatientDoesNotExist()
        {
            Patients = new List<Patient>();
            PatientOne = new Patient("Izabel", "123.456.789-00", 21);
            PatientOne.SetIllness(Illnesses.UNKNOWN);

            PatientTwo = new Patient("Bruna", "123.123.223-00", 12);
            PatientTwo.SetIllness(Illnesses.FRATURA);
            Patients.Add(PatientTwo);

            var actual = Assert.Throws<PatientDoesNotExistException>(() => ServiceForm.VerifyIfPatientExist(Patients, PatientOne));

            Assert.Equal($"Não foi encontrado nenhum registro com o paciente {PatientOne.GetCpf()}", actual.Message);
        }


        [Fact]
        public void SavePatientForm()
        {
            Services = new List<ServiceForm>();
            PatientOne = new Patient("Bruna", "123.123.223-00", 12);
            PatientOne.SetIllness(Illnesses.FRATURA);
            Attendant = new Attendant("Gabriel", "106.554.857-22", 22, "ADSPL202021312");
            Doctor = new Doctor("Luan", "201.235.445-98", 55, "36544258");
            ServiceForm = new ServiceForm(PatientOne, Attendant, Priority.RED, Doctor);
            ServiceForm.SaveForm(Services, ServiceForm);
            
            var actual = ServiceForm.VerifyIfFormExistInList(Services, ServiceForm);

            Assert.True(actual);
        }
    }
}
