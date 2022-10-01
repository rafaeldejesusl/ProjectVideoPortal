namespace video_portal.Models
{
    public class Channel
    {
        public int ChannelId;
        public string ChannelName;
        public string? ChannelDescription;
        public string Url;
        public ICollection<Video> Videos;
        public ICollection<User> Owners;
    }
}
