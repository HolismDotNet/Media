namespace Media;

public class ImageController : ReadController<ImageView>
{
    public override ReadBusiness<ImageView> ReadBusiness => new ImageBusiness();

    [BindProperty(SupportsGet = true)]
    public Guid? EntityGuid { get; set; }

    public override Action<ListParameters> ListParametersAugmenter => listParameters => 
    {
        if (EntityGuid == null)
        {
            throw new ClientException("EntityGuid is not provided");
        }
        listParameters.AddFilter<ImageView>(i => i.EntityGuid, EntityGuid);
    };
}