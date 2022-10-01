using Microsoft.EntityFrameworkCore;
using video_portal.Models;

namespace video_portal.Repository;

public class VideoPortalContext : DbContext, IVideoPortalContext
{
    public virtual DbSet<Channel> Channels { get; set; }
    public virtual DbSet<Video> Videos { get; set; }
    public virtual DbSet<Comment> Comments { get; set; }
    public virtual DbSet<User> Users { get; set; }
    public VideoPortalContext(DbContextOptions<VideoPortalContext> options) : base(options) { }
    public VideoPortalContext() { }
}
