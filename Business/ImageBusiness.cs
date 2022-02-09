namespace Media;

public class ImageBusiness : Business<ImageView, Image>
{
    protected override ReadRepository<ImageView> ReadRepository => Repository.ImageView;

    protected override Repository<Image> WriteRepository => Repository.Image;

    protected override void ModifyItemBeforeReturning(ImageView image)
    {
        base.ModifyItemBeforeReturning(image);
    }

    public ImageView Upload(string entityType, Guid entityGuid, byte[] bytes)
    {
        var image = new Image();
        image.EntityTypeGuid = new EntityTypeBusiness().GetGuid(entityType);
        image.EntityGuid = entityGuid;
        image.ImageGuid = Guid.NewGuid();
        Storage.UploadImage(bytes, image.ImageGuid, entityType.ToLower() + "images");
        Create(image);
        return Get(image.Id);
    }
}