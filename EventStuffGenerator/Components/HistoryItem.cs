using System.Runtime.Serialization;

namespace EventStuffGenerator.Components
{
    [DataContract]
    public class HistoryItem
    {
        public HistoryItem(string eventName, string argument)
        {
            EventName = eventName;
            Argument = argument;
        }

        [DataMember]
        public string EventName { get; set; }

        [DataMember]
        public string Argument { get; set; }

        public override string ToString()
        {
            return EventName;
        }
    }
}