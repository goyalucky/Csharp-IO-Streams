/* ByteArray Stream - Convert Image to ByteArray
Problem Statement: Write a C# program that converts an image file into a byte array and then writes it back to another image file.
Requirements: Use MemoryStream to handle byte arrays. Verify that the new file is identical to the original image. Handle IOException. */

using System;
using System.IO;
namespace Streams
{
    public static class ImageHelper{
    // Convert image file to byte array
    public static byte[] ImageToByteArray(string path)
    {
        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        using (MemoryStream ms = new MemoryStream())
        {
            fs.CopyTo(ms);
            return ms.ToArray();
        }
    }

    // Write byte array back to image file
    public static void ByteArrayToImage(byte[] bytes, string path)
    {
        using (MemoryStream ms = new MemoryStream(bytes))
        using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            ms.CopyTo(fs);
        }
    }

    // Verify if two files are identical
    public static bool AreFilesIdentical(string path1, string path2)
    {
        byte[] file1 = File.ReadAllBytes(path1);
        byte[] file2 = File.ReadAllBytes(path2);
        if (file1.Length != file2.Length) return false;

        for (int i = 0; i < file1.Length; i++)
            if (file1[i] != file2[i]) return false;

        return true;
    }
}
}
