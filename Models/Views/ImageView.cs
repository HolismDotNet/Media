namespace Media;

public class ImageView : IEntity
{
    public ImageView()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid EntityTypeGuid { get; set; }

    public Guid EntityGuid { get; set; }

    public Guid ImageGuid { get; set; }

    public dynamic RelatedItems { get; set; }
}
