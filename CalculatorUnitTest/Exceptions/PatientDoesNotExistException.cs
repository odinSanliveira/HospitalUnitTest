using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalUnitTest.Exceptions
{
    class PatientDoesNotExistException : Exception
    {
        public PatientDoesNotExistException(string message) : base(message)
        {
        }
    }
}
