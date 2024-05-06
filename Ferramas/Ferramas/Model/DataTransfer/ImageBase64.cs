namespace Ferramas.Model.DataTransfer;

public struct ImageBase64
{
    public string Mime { get; set; }
    public string Data { get; set; }

    public ImageBase64() { }

    public static ImageBase64 PNG
    {
        get
        {
            return new()
            {
                Mime = "image/png"
            };
        }
    }
}
