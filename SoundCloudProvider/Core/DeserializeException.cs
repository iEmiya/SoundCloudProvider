using System;
using System.Runtime.Serialization;

namespace SoundCloudProvider.Core
{
    [Serializable]
    internal class DeserializeException : FrameworkException
    {
        public DeserializeException(Type objectType, string objectString)
        {
            this.ObjectType = objectType;
            this.ObjectString = objectString;
        }

        public DeserializeException(Type objectType, string objectString, Exception innerException)
            : base(null, innerException)
        {
            this.ObjectType = objectType;
            this.ObjectString = objectString;
        }

        public Type ObjectType { get; private set; }

        public string ObjectString { get; private set; }

        public override string Message
        {
            get
            {
                return string.Format(
                    "Deserialize Failed.{0}Type:{1}{0}String:{2}",
                    Environment.NewLine,
                    this.ObjectType,
                    this.ObjectString);
            }
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("ObjectType", this.ObjectType);
            info.AddValue("ObjectString", this.ObjectString);
        }
    }
}
