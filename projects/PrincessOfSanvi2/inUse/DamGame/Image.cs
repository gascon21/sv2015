﻿/// <summary>
///  Hardware: to hide SDL details and allow an easier access
///  @author Nacho Cabanes, Alumnos DAM IesSanVicente 2015-16
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.02  15-Apr-2016  David Gascón and Sergio Martinez:
                      Added a constructor to load an image from a pointer.
   0.01, 20-Nov-2015  Nacho: Basic skeleton
 ---------------------------------------------------- */

using System;
using Tao.Sdl;

public class Image
{
    private IntPtr internalPointer;

    public Image(string fileName)
    {
        Load(fileName);
    }

    public Image(IntPtr ptr)
    {
        internalPointer = ptr;
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
