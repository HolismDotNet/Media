namespace Media;

public class ImageController : Controller<ImageView, Image>
{
    public override ReadBusiness<ImageView> ReadBusiness => new ImageBusiness();
    
    public override Business<ImageView, Image> Business => new ImageBusiness();

    [BindProperty]
    public string EntityType { get; set; }

    [BindProperty]
    public Guid? EntityGuid { get; set; }

    [FileUploadChecker]
    [HttpPost]
    public virtual object Upload(IFormFile file)
    {
        if (EntityType.IsNothing())
        {
            throw new ClientException("Please provide entityType");
        }
        if (EntityGuid == null || EntityGuid.Value == Guid.Empty)
        {
            throw new ClientException("Please provide entityGuid");
        }
        var bytes = file.OpenReadStream().GetBytes();
        var image = new Media.ImageBusiness().Upload(EntityType, EntityGuid.Value, bytes);
        return image;
    }
}