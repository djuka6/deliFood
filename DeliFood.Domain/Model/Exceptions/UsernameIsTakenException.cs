using System;


namespace DeliFood.Domain.Model.Exceptions
{
    public class UsernameIsTakenException : ArgumentException
    {
        public UsernameIsTakenException() : base("Username is already taken!")
        {

        }
    }
}
