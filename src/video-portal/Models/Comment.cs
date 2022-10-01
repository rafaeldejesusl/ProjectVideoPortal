namespace video_portal.Models
{
    public class Comment
    {
        public int CommentId;
        public string CommentText;
        public int VideoId;
        public Video Video;
        public int UserId;
        public User User;
    }
}
