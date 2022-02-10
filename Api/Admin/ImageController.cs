namespace Media;

public class ImageController : Controller<ImageView, Image>
{
    public override ReadBusiness<ImageView> ReadBusiness => new ImageBusiness();
    
    public override Business<ImageView, Image> Business => new ImageBusiness();

    [BindProperty(SupportsGet = true)]
    public string EntityType { get; set; }

    [BindProperty(SupportsGet = true)]
    public Guid? EntityGuid { get; set; }

    public override Action<ListParameters> ListParametersAugmenter => listParameters => 
    {
        EnsureParametersExist();
        listParameters.AddFilter<ImageView>(i => i.EntityGuid, EntityGuid);
        listParameters.PageSize = 20;
    };

    [FileUploadChecker]
    [HttpPost]
    public virtual object Upload(IFormFile file)
    {
        EnsureParametersExist();
        var bytes = file.OpenReadStream().GetBytes();
        var image = new Media.ImageBusiness().Upload(EntityType, EntityGuid.Value, bytes);
        return image;
    }

    public void EnsureParametersExist()
    {
        if (EntityType.IsNothing())
        {
            throw new ClientException("Please provide entityType");
        }
        if (EntityGuid == null || EntityGuid.Value == Guid.Empty)
        {
            throw new ClientException("Please provide entityGuid");
        }
    }
}