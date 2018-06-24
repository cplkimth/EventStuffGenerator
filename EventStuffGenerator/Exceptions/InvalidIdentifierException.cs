using System;

namespace EventStuffGenerator.Exceptions
{
    public class InvalidIdentifierException : Exception
    {
        public InvalidIdentifierException(string identifier)
        {
            Identifier = identifier;
        }

        public string Identifier { get; private set; }

        public override string Message => $"{Identifier} 는 식별자로 사용할 수 없는 이름입니다.";
    }
}