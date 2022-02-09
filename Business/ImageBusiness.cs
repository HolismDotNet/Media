namespace Media;

public class ImageBusiness : Business<ImageView, Image>
{
    protected override ReadRepository<ImageView> ReadRepository => Repository.ImageView;

    protected override Repository<Image> WriteRepository => Repository.Image;

    public string GetContainerName(string entityType)
    {
        return $"{entityType.ToLower()}images";
    }

    protected override void ModifyItemBeforeReturning(ImageView image)
    {
        var entityType = new EntityTypeBusiness().GetName(image.EntityTypeGuid);
        image.RelatedItems.OriginalEntityType = entityType;
        image.RelatedItems.Url = Storage.GetImageUrl(GetContainerName(entityType), image.ImageGuid);
        base.ModifyItemBeforeReturning(image);
    }

    public ImageView Upload(string entityType, Guid entityGuid, byte[] bytes)
    {
        var image = new Image();
        image.EntityTypeGuid = new EntityTypeBusiness().GetGuid(entityType);
        image.EntityGuid = entityGuid;
        image.ImageGuid = Guid.NewGuid();
        Storage.UploadImage(bytes, image.ImageGuid, GetContainerName(entityType));
        Create(image);
        return Get(image.Id);
    }
}