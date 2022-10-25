using HospitalUnitTest.Exceptions;
using HospitalUnitTest.Models;
using System;

namespace HospitalUnitTest.Models
{
    public class Doctor : Person
    {
        public string Id { get; set; }

        public Doctor()
        {

        }

        public Doctor(string name, string cpf, int yearsOld, string id) : base(name, cpf, yearsOld)
        {
            Id = id;
        }

        public void Validate()
        {
            
        }

        internal string GetRegistry()
        {
            return this.Id != null ? this.Id : throw new DoctorNullRegistryException("Médico não pode ter matrícula nula");
        }
    }
}
