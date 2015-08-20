using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Point3D
{
    [Serializable()]
    class Path : ISerializable //Inherit the serializavle inteface
    {
        private List<Point3D> path = new List<Point3D>();

        public List<Point3D> PathList
        {
            get { return path; }
            set { path = value; }
        }

        public Path()
        {

        }
        // stubs for ISerializable
        public Path(SerializationInfo info, StreamingContext ctxt) 
        {
            this.path = (List<Point3D>)info.GetValue("Path", typeof(List<Point3D>));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Path", this.path);
        }

    }
}
