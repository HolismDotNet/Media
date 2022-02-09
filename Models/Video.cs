namespace Media;

public class Video : IEntity
{
    public Video()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid EntityTypeGuid { get; set; }

    public string EntityType { get; set; }

    public string CoverImage { get; set; }

    public Guid? VideoGuid { get; set; }

    public string EmbedCode { get; set; }

    public string Url { get; set; }

    public dynamic RelatedItems { get; set; }
}
