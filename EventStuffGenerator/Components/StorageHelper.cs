#region
using System.IO;

#endregion

namespace EventStuffGenerator.Components
{
    public abstract class StorageHelper
    {
        protected abstract dynamic GetStorage();

        protected abstract Stream GetStream(string fileName, FileMode fileMode);

        public void WriteText(string fileName, FileMode fileMode, string text)
        {
            StreamWriter writer = new StreamWriter(GetStream(fileName, fileMode));

            writer.Write(text);
            writer.Close();
        }

        public void WriteText(string fileName, string text)
        {
            WriteText(fileName, FileMode.Create, text);
        }

        public string ReadText(string fileName, FileMode fileMode)
        {
            StreamReader reader = new StreamReader(GetStream(fileName, fileMode));

            string text = reader.ReadToEnd();
            reader.Close();

            return text;
        }

        public string ReadText(string fileName)
        {
            return ReadText(fileName, FileMode.Open);
        }

        public void WriteBinary(string fileName, FileMode fileMode, byte[] bytes)
        {
            BinaryWriter writer = new BinaryWriter(GetStream(fileName, fileMode));

            writer.Write(bytes);
            writer.Close();
        }

        public void WriteBinary(string fileName, byte[] bytes)
        {
            WriteBinary(fileName, FileMode.Create, bytes);
        }

        public byte[] ReadBinary(string fileName, FileMode fileMode)
        {
            BinaryReader writer = new BinaryReader(GetStream(fileName, fileMode));

            var bytes = writer.ReadBytes((int) writer.BaseStream.Length);
            writer.Close();

            return bytes;
        }

        public byte[] ReadBinary(string fileName)
        {
            return ReadBinary(fileName, FileMode.Open);
        }

        public bool Exist(string fileName)
        {
            var storage = GetStorage();
            return storage.GetFileNames(fileName).Length > 0;
        }

        public void Delete(string fileName)
        {
            var storage = GetStorage();
            storage.DeleteFile(fileName);
        }

        public void SaveObject<T>(T @object, string fileName)
        {
            var bytes = ObjectRepository.Serialize(@object);
            WriteBinary(fileName, bytes);
        }

        public T LoadObject<T>(string fileName)
        {
            var bytes = ReadBinary(fileName);
            T @object = ObjectRepository.Deserialize<T>(bytes);

            return @object;
        }
    }
}