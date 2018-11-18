using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace wpfImagesOperationsLibrary
{
    public class BitmapSourceByteArray
    {
        public static BitmapSource ByteArrayToBitmapSource(byte [] array, int width, int height, int bitsPerPixel)
        {
            int stride = width * ((bitsPerPixel + 7) / 8);
            return BitmapSource.Create(width, height, 96, 96, PixelFormats.Bgra32, null, array, stride);
        }
    }
}
