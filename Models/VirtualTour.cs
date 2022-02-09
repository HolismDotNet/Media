namespace Media;

public class VirtualTour : IEntity
{
    public VirtualTour()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid EntityTypeGuid { get; set; }

    public Guid EntityGuid { get; set; }

    public string Link { get; set; }

    public dynamic RelatedItems { get; set; }
}
