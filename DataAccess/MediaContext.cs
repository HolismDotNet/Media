namespace Media;

public class MediaContext : DatabaseContext
{
    public override string ConnectionStringName => "Media";

    public DbSet<Media.Audio> Audios { get; set; }

    public DbSet<Media.Image> Images { get; set; }

    public DbSet<Media.ImageView> ImageViews { get; set; }

    public DbSet<Media.Thumbnail> Thumbnails { get; set; }

    public DbSet<Media.Video> Videos { get; set; }

    public DbSet<Media.VirtualTour> VirtualTours { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
