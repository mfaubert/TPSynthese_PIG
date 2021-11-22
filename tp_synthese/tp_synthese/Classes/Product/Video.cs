using System.Collections.Generic;

namespace Classes01_Corrige
{
    public class Video : Product
    {
        public float Length;
        public VideoFormat VideoFormat;

        public List<VideoCategory> VideoCategories = new List<VideoCategory>();

    }
}
