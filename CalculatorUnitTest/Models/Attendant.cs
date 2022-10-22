/**
    Este código foi desenvolvido por: Gabriel Santana, Izabel Mendes, Odin Oliveira
    Para disciplina de Teste de Software - IFPE - 2022.2
 */

using HospitalUnitTest.Exceptions;
using System;
using System.Collections.Generic;

namespace HospitalUnitTest.Models
{
    public class Attendant : Person
    {
        public string Id { get; set; }

        public Attendant()
        {

        }
        public Attendant(string name, string cpf, int yearsOld, string id) : base(name, cpf, yearsOld)
        {
            Id = id;
        }

        internal object GetId()
        {
            if (String.IsNullOrEmpty(Id))
            {
                throw new WrongOrUnexistentAttendantIdException($"Usuário {this.GetName()} não existe ou não tem ID");
            }
            return Id;
        }

        public static bool RegisterUserToConsultation(List<Attendant> attendants, Attendant attendant)
        {
            return attendants.Contains(attendant) ? true : throw new AttendantDoesNotExistException($"Não existe atendente com a matrícula {attendant.GetId()}");
        }
    }
}
