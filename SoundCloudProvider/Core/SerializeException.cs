using System;
using System.Runtime.Serialization;

namespace SoundCloudProvider.Core
{
    [Serializable]
    internal class SerializeException : FrameworkException
    {
        public SerializeException(Type objectType)
        {
            this.ObjectType = objectType;
        }

        public SerializeException(Type objectType, Exception innerException)
            : base(null, innerException)
        {
            this.ObjectType = objectType;
        }

        public Type ObjectType { get; private set; }

        public override string Message
        {
            get
            {
                return string.Format(
                    "Serialize Failed.{0}Type:{1}",
                    Environment.NewLine,
                    this.ObjectType);
            }
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("ObjectType", this.ObjectType);
        }
    }
}
