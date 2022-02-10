namespace Media;

public class Repository
{
    public static Repository<Media.Audio> Audio
    {
        get
        {
            return new Repository<Media.Audio>(new MediaContext());
        }
    }

    public static Repository<Media.Image> Image
    {
        get
        {
            return new Repository<Media.Image>(new MediaContext());
        }
    }

    public static Repository<Media.ImageView> ImageView
    {
        get
        {
            return new Repository<Media.ImageView>(new MediaContext());
        }
    }

    public static Repository<Media.Thumbnail> Thumbnail
    {
        get
        {
            return new Repository<Media.Thumbnail>(new MediaContext());
        }
    }

    public static Repository<Media.ThumbnailView> ThumbnailView
    {
        get
        {
            return new Repository<Media.ThumbnailView>(new MediaContext());
        }
    }

    public static Repository<Media.Video> Video
    {
        get
        {
            return new Repository<Media.Video>(new MediaContext());
        }
    }

    public static Repository<Media.VirtualTour> VirtualTour
    {
        get
        {
            return new Repository<Media.VirtualTour>(new MediaContext());
        }
    }
}
