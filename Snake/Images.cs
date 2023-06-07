using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Snake
{
    public static class Images
    {

        public readonly static ImageSource Empty = LoadImamge("Empty.png");
        public readonly static ImageSource Body = LoadImamge("Body.png");
        public readonly static ImageSource Head = LoadImamge("Head.png");
        public readonly static ImageSource Food = LoadImamge("Food.png");
        public readonly static ImageSource DeadBody = LoadImamge("DeadBody.png");
        public readonly static ImageSource DeadHead = LoadImamge("DeadHead.png");

        private static ImageSource LoadImamge(string filename)
        {
            return new BitmapImage(new Uri($"Assets/{filename}", UriKind.Relative));
        }
    }
}
