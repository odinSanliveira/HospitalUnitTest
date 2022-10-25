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

        public Doctor DoctorOne;
        public Doctor DoctorTwo;

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
            DoctorOne = new Doctor("Luan", "201.235.445-98", 55, "36544258");
            ServiceForm = new ServiceForm(PatientOne, Attendant, Priority.RED, DoctorOne);
            ServiceForm.SaveForm(Services, ServiceForm);
            
            var actual = ServiceForm.VerifyIfFormExistInList(Services, ServiceForm);

            Assert.True(actual);
        }

        [Fact]
        public void ReturnFormsByIllness()
        {
            Services = new List<ServiceForm>();
            PatientOne = new Patient("Bruna", "123.123.223-00", 12);
            PatientOne.SetIllness(Illnesses.FRATURA);

            PatientTwo = new Patient("Creuza", "123.145.223-00", 92);
            PatientTwo.SetIllness(Illnesses.DENGUE);


            Attendant = new Attendant("Gabriel", "106.554.857-22", 22, "ADSPL202021312");
            DoctorOne = new Doctor("Luan", "201.235.445-98", 55, "36544258");

            DoctorOne = new Doctor("Luan", "201.235.445-98", 55, "36544258");
            DoctorTwo = new Doctor("Maria", "111.235.360-95", 39, "2036982");

            ServiceForm = new ServiceForm(PatientOne, Attendant, Priority.RED, DoctorOne);
            ServiceForm.SaveForm(Services, ServiceForm);
            ServiceForm = new ServiceForm(PatientTwo, Attendant, Priority.RED, DoctorTwo);
            ServiceForm.SaveForm(Services, ServiceForm);

            PatientOne = new Patient("Gabriel", "123.123.223-00", 12);
            PatientOne.SetIllness(Illnesses.FRATURA);
            ServiceForm = new ServiceForm(PatientOne, Attendant, Priority.RED, DoctorTwo);
            ServiceForm.SaveForm(Services, ServiceForm);

            var actual = ServiceForm.GetSpecificIlness(Services, Illnesses.FRATURA);

            Assert.Equal(typeof(List<ServiceForm>), actual.GetType());
            Assert.Contains(actual, item => item.Patient.Illnesses == Illnesses.FRATURA);
        }
    }
}
