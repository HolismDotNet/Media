namespace Media;

public class ThumbnailView : IEntity
{
    public ThumbnailView()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public long ImageId { get; set; }

    public long SizeId { get; set; }

    public Guid ThumbnailGuid { get; set; }

    public string SizeKey { get; set; }

    public dynamic RelatedItems { get; set; }
}
