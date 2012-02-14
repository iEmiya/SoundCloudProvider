namespace SoundCloudProvider.Net
{
    public interface IRequestInfo
    {
        string UriString { get; }
        string ContentType { get; }
        byte[] PostContent { get; }
    }

    public class RequestInfoImp : IRequestInfo
    {
        public string UriString { get; set; }
        public string ContentType { get; set; }
        public byte[] PostContent { get; set; }
    }
}
