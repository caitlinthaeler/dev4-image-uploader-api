
namespace dev4_image_uploader.Models;
public class ImageEntry
{
    public int Id { get; set; }
    public string FileName { get; set; } = null!; // ex. my-image.jpg
    public string FilePath { get; set; } = null!; // ex. wwwroot/uploads/my-image.jpg
    public DateTime UploadDate { get; set; }
    public string ContentType { get; set; } = "application/octet-stream"!; // ex. image/jpeg
    public int FileSize { get; set; }
}