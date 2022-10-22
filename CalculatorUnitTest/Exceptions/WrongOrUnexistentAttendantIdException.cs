/**
    Este código foi desenvolvido por: Gabriel Santana, Izabel Mendes, Odin Oliveira
    Para disciplina de Teste de Software - IFPE - 2022.2
 */

using System;
using System.Runtime.Serialization;

namespace CalculatorUnitTest.Exceptions
{
    [Serializable]
    class WrongOrUnexistentAttendantIdException : Exception
    {
        public string AttendantId { get; set; }
        public WrongOrUnexistentAttendantIdException(string message) : base(message){}

        public WrongOrUnexistentAttendantIdException(string message, string id) : this(message)
        {
            AttendantId = id;
        }
        protected WrongOrUnexistentAttendantIdException(SerializationInfo info, StreamingContext context) : base(info, context){}
    }
}
