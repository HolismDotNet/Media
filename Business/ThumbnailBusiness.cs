namespace Media;

public class ThumbnailBusiness : Business<ThumbnailView, Thumbnail>
{
    protected override ReadRepository<ThumbnailView> ReadRepository => Repository.ThumbnailView;

    protected override Repository<Thumbnail> WriteRepository => Repository.Thumbnail;

    public List<ThumbnailView> GetThumbnails(List<long> imageIds)
    {
        var thumbnails = GetList(i => imageIds.Contains(i.ImageId));
        thumbnails = thumbnails.OrderBy(i => i.SizeId).ToList();
        return thumbnails;
    }
}