/**
 * Image.cs - To hide SDL image handling
 * Cool image to show image
 */





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.Sdl;

namespace Aquarium
{
    public class Image
    {
        private IntPtr internalPointer;

        public Image(string fileName)
        {
            Load(fileName);
        }

        public void Load(string fileName)
        {
            internalPointer = SdlImage.IMG_Load(fileName);
            if (internalPointer == IntPtr.Zero)
                Hardware.FatalError("Image not found: " + fileName);
        }


        public IntPtr GetPointer()
        {
            return internalPointer;
        }
    }

}
