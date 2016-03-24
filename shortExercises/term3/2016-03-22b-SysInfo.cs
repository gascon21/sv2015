// Miguel Moya Ortega

using System;
using System.IO;

public class SysInfos
{
    public static void Main()
    {
        Console.WriteLine(Environment.OSVersion);
        Console.WriteLine("Dot Net " + Environment.Version);
        String[] disks = Environment.GetLogicalDrives();
        foreach(string disk in disks)
        {
            try
            {
                Console.Write( disk.Substring(0,2) + " ");
                DriveInfo drive = new DriveInfo(disk);
                Console.Write((drive.TotalFreeSpace/1024/1024/1024) + "GB / ");
                Console.WriteLine((drive.TotalSize/1024/1024/1024) + "GB");
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot do it");
            }
        }
    }
}
