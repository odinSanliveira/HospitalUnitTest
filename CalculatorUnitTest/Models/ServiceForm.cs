/**
Este código foi desenvolvido por: Gabriel Santana, Izabel Mendes, Odin Oliveira
Para disciplina de Teste de Software - IFPE - 2022.2
*/

using HospitalUnitTest.Models;
using HospitalUnitTest.Enums;

namespace HospitalUnitTest.Models
{
    public class ServiceForm : FichaBase
    {
        public Patient patient { get; set; }
        public Attendant attendant { get; set; }
        public Priority priorityColor { get; set; }
        public Doctor doctor { get; set; }


        public ServiceForm()
        {
        }

        public ServiceForm(Patient patient, Attendant attendant, Priority priorityColor, Doctor doctor)
        {
            this.patient = patient;
            this.attendant = attendant;
            this.priorityColor = priorityColor;
            this.doctor = doctor;
        }
    }
}
