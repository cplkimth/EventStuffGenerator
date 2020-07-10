using System;

namespace EventStuffGenerator.Core.Exceptions
{
    public class KeywordException : Exception
    {
        public KeywordException(string keyword)
        {
            Keyword = keyword;
        }

        public string Keyword { get; private set; }

        public override string Message => $"{Keyword} 는 C#의 키워드입니다.";
    }
}