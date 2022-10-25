/**
Este código foi desenvolvido por: Gabriel Santana, Izabel Mendes, Odin Oliveira
Para disciplina de Teste de Software - IFPE - 2022.2
*/

using HospitalUnitTest.Models;
using HospitalUnitTest.Enums;
using System.Collections.Generic;
using System;
using HospitalUnitTest.Exceptions;
using HospitalUnitTest.Tests;

namespace HospitalUnitTest.Models
{
    public class ServiceForm : FichaBase
    {

        public Patient Patient { get; set; }
        public Attendant Attendant { get; set; }
        public Priority PriorityColor { get; set; }
        public Doctor Doctor { get; set; }


        public ServiceForm()
        {
        }

        public ServiceForm(Patient patient, Attendant attendant, Priority priorityColor, Doctor doctor)
        {
            Patient = patient;
            Attendant = attendant;
            PriorityColor = priorityColor;
            Doctor = doctor;
        }

        public ServiceForm(Patient patient)
        {
            Patient = patient;
        }

        public static bool VerifyIfPatientExist(List<Patient> patients, Patient patient)
        {
            return patients.Contains(patient) ? true : throw new PatientDoesNotExistException($"Não foi encontrado nenhum registro com o paciente {patient.GetCpf()}");
        }

        internal static void SaveForm(List<ServiceForm> services, ServiceForm serviceForm)
        {
            services.Add(serviceForm);
        }

        public static bool VerifyIfFormExistInList(List<ServiceForm> services, ServiceForm serviceForm)
        {
            return services.Contains(serviceForm);
        }

        internal List<ServiceForm> GetSpecificIlness(List<ServiceForm> services, Illnesses illness)
        {
            List<ServiceForm> result = new List<ServiceForm>();
             
            foreach(ServiceForm service in services)
            {
                if(service.Patient.Illnesses == illness)
                {
                    result.Add(service);
                }
            }
            return result;
        }
    }
}
