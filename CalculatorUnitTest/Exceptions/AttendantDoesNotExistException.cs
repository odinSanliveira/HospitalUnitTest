using System;

namespace HospitalUnitTest.Exceptions
{
    class AttendantDoesNotExistException : Exception
    {
        public AttendantDoesNotExistException(string message) : base(message)
        {
        }
    }
}
