namespace Media;

public class Audio : IEntity
{
    public Audio()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid EntityTypeGuid { get; set; }

    public Guid EntityGuid { get; set; }

    public Guid AudioGuid { get; set; }

    public dynamic RelatedItems { get; set; }
}
