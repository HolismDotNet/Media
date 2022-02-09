namespace Media;

public class Image : IEntity
{
    public Image()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid EntityTypeGuid { get; set; }

    public Guid EntityGuid { get; set; }

    public Guid ImageGuid { get; set; }

    public dynamic RelatedItems { get; set; }
}
