using video_portal.Models;

namespace video_portal.Repository
{
    public class VideoPortalRepository : IVideoPortalRepository
    {
        private readonly IVideoPortalContext _context;
        public VideoPortalRepository(IVideoPortalContext context)
        {
            _context = context;
        }
        public Video GetVideoById(int videoId)
        {
            var result = _context.Videos.Where(v => v.VideoId == videoId).First();
            return result;
        }
        public IEnumerable<Video> GetVideos()
        {
            var result = _context.Videos;
            return result;
        }
        public Channel GetChannelById(int channelId)
        {
            var result = _context.Channels.Where(ch => ch.ChannelId == channelId).First();
            return result;
        }
        public IEnumerable<Channel> GetChannels()
        {
            var result = _context.Channels;
            return result;
        }
        public IEnumerable<Video> GetVideosByChannelId(int channelId)
        {
            var result = _context.Videos.ToList().Where(v => v.ChannelId == channelId);
            return result;
        }
        public IEnumerable<Comment> GetCommentsByVideoId(int videoId)
        {
            var result = _context.Comments.ToList().Where(c => c.VideoId == videoId);
            return result;
        }
        public void DeleteChannel(Channel channel)
        {
            if (this.GetVideosByChannelId(channel.ChannelId) == null) throw new InvalidOperationException();
            var deleted = _context.Channels.Where(ch => ch.ChannelId == channel.ChannelId).First();
            _context.Channels.Remove(deleted);
            _context.SaveChanges();
        }
        public void AddVideoToChannel(Channel channel, Video video)
        {
            if (channel == null || video == null) throw new InvalidOperationException();
            var selectedChannel = _context.Channels.Where(ch => ch.ChannelId == channel.ChannelId).First();
            var selectedVideo = _context.Videos.Where(v => v.VideoId == video.VideoId).First();
            selectedVideo.ChannelId = channel.ChannelId;
            _context.Videos.Update(selectedVideo);
        }
    }
}
