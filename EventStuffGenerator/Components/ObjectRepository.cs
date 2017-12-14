using System.IO;
using System.Runtime.Serialization;

namespace EventStuffGenerator.Components
{
    public static class ObjectRepository
    {
        public static byte[] Serialize<T>(T @object)
        {
            MemoryStream stream = new MemoryStream();
            DataContractSerializer serializer = new DataContractSerializer(typeof (T));
            serializer.WriteObject(stream, @object);

            var bytes = stream.ToArray();
            stream.Close();

            return bytes;
        }

        public static T Deserialize<T>(byte[] bytes)
        {
            MemoryStream stream = new MemoryStream(bytes);
            DataContractSerializer serializer = new DataContractSerializer(typeof (T));
            T @object = (T) serializer.ReadObject(stream);

            stream.Close();

            return @object;
        }
    }
}