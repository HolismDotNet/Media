namespace Media;

public class ImageController : Controller<ImageView, Image>
{
    public override ReadBusiness<ImageView> ReadBusiness => new ImageBusiness();
    
    public override Business<ImageView, Image> Business => new ImageBusiness();
}