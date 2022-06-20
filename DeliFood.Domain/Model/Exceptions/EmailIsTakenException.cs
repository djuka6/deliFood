using System;


namespace DeliFood.Domain.Model.Exceptions
{
    public class EmailIsTakenException : ArgumentException
    {
        public EmailIsTakenException() : base("Email is already taken!")
        {

        }
    }
}
