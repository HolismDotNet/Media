namespace Media;

public class ImageBusiness : Business<ImageView, Image>
{
    protected override ReadRepository<ImageView> ReadRepository => Repository.ImageView;

    protected override Repository<Image> WriteRepository => Repository.Image;

    public string GetContainerName(string entityType)
    {
        return $"{entityType.ToLower()}";
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

    public void Augment(List<IGuid> items)
    {
        var guids = items.Select(i => i.Guid).ToList();
        var images = GetList(i => guids.Contains(i.EntityGuid));
        var imageIds = images.Select(i => i.Id).ToList();
        var thumbnails = new ThumbnailBusiness().GetThumbnails(imageIds);
        foreach (var item in items)
        {
            var itemImages = images.Where(i => i.EntityGuid == item.Guid);
            foreach (var itemImage in itemImages)
            {
                itemImage.RelatedItems.Thumbnails = thumbnails.Where(i => i.ImageId == itemImage.Id);
            }
            ((IEntity)item).RelatedItems.Images = itemImages;
        }
    }
}