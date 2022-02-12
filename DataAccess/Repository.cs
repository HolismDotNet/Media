namespace Media;

public class Repository
{
    public static Write<Media.Audio> Audio
    {
        get
        {
            return new Write<Media.Audio>(new MediaContext());
        }
    }

    public static Write<Media.Image> Image
    {
        get
        {
            return new Write<Media.Image>(new MediaContext());
        }
    }

    public static Write<Media.ImageView> ImageView
    {
        get
        {
            return new Write<Media.ImageView>(new MediaContext());
        }
    }

    public static Write<Media.Thumbnail> Thumbnail
    {
        get
        {
            return new Write<Media.Thumbnail>(new MediaContext());
        }
    }

    public static Write<Media.ThumbnailView> ThumbnailView
    {
        get
        {
            return new Write<Media.ThumbnailView>(new MediaContext());
        }
    }

    public static Write<Media.Video> Video
    {
        get
        {
            return new Write<Media.Video>(new MediaContext());
        }
    }

    public static Write<Media.VirtualTour> VirtualTour
    {
        get
        {
            return new Write<Media.VirtualTour>(new MediaContext());
        }
    }
}
