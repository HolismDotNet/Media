namespace Media;

public class ImageBusiness : Business<ImageView, Image>
{
    protected override ReadRepository<ImageView> ReadRepository => Repository.ImageView;

    protected override Repository<Image> WriteRepository => Repository.Image;

    protected override void ModifyItemBeforeReturning(ImageView image)
    {
        base.ModifyItemBeforeReturning(image);
    }
}