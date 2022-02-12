namespace Media;

public class ThumbnailBusiness : Business<ThumbnailView, Thumbnail>
{
    protected override Read<ThumbnailView> Read => Repository.ThumbnailView;

    protected override Write<Thumbnail> Write => Repository.Thumbnail;

    public List<ThumbnailView> GetThumbnails(List<long> imageIds)
    {
        var thumbnails = GetList(i => imageIds.Contains(i.ImageId));
        thumbnails = thumbnails.OrderBy(i => i.SizeId).ToList();
        return thumbnails;
    }
}