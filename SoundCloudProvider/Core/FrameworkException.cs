using System;
using System.Runtime.Serialization;

namespace SoundCloudProvider.Core
{
    [Serializable]
    public class FrameworkException : Exception
    {
        public FrameworkException()
        {
        }

        public FrameworkException(string message) 
            : base(message)
        {
        }

        public FrameworkException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected FrameworkException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
