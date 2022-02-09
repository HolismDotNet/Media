namespace Media;

public class Thumbnail : IEntity
{
    public Thumbnail()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public long ImageId { get; set; }

    public long SizeId { get; set; }

    public Guid ThumbnailGuid { get; set; }

    public dynamic RelatedItems { get; set; }
}
