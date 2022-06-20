using System;


namespace DeliFood.Domain.Model.Exceptions
{
   public class LogInException : ArgumentException
    {
        public LogInException() : base("Username does not exist!")
        {

        }
    }
}
