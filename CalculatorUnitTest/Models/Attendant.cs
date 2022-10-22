using CalculatorUnitTest.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUnitTest.Models
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
    }
}
