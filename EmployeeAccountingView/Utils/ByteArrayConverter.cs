namespace EmployeeAccountingView.Utils
{
    public class ByteArrayConverter
    {
        public static byte[] ImageToByteArray(Image image)
        {
            using var memoryStream = new MemoryStream();
            image.Save(memoryStream, image.RawFormat);
            return memoryStream.ToArray();
        }

        public static Image ByteArrayToImage(byte[] byteArray)
        {
            using var memoryStream = new MemoryStream(byteArray);
            return Image.FromStream(memoryStream);
        }
    }
}
