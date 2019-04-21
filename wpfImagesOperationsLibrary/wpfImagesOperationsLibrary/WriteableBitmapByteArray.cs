using System.Windows.Media.Imaging;

namespace wpfImagesOperationsLibrary
{
    public class WriteableBitmapByteArray
    {
        public static byte[] WriteableBitmapToByteArray(WriteableBitmap writeableBitmap)
        {
            int width = writeableBitmap.PixelWidth;
            int height = writeableBitmap.PixelHeight;
            int stride = width * ((writeableBitmap.Format.BitsPerPixel + 7) / 8);
            byte[] array = new byte[height * stride];
            writeableBitmap.CopyPixels(array, stride, 0);
            return array;
        }
    }
}
