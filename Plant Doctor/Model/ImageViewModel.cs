using System;
using System.Collections.Generic;
using System.Text;

namespace Plant_Doctor.Model
{
    class ImageViewModel
    {
        public List<string> Images { get; set; }

        public ImageViewModel()
        {
            Images = new List<string>
            {
                "img1.png",
                "Signoutflower.png",
                "img2.png",
                "img4.png",
                "img6.png"
            };
        }
    }
}
