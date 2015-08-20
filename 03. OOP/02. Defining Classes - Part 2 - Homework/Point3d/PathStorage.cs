using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Point3D
{
    class PathStorage
    {
        public PathStorage()
        {
        }

        public void SerializeObject(string filename, Path objectToSerialize)
        {
            using (Stream stream = File.Open(filename, FileMode.Create))
            {
                BinaryFormatter bFormatter = new BinaryFormatter();
                bFormatter.Serialize(stream, objectToSerialize);
            }
        }

        public Path DeSerializeObject(string filename)
        {
            Path objectToSerialize;
            using (Stream stream = File.Open(filename, FileMode.Open))
            {
                BinaryFormatter bFormatter = new BinaryFormatter();
                objectToSerialize = (Path)bFormatter.Deserialize(stream);
            }
            return objectToSerialize;
        }
    }
}