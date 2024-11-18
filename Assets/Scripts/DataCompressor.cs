using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using UnityEngine;

public class DataCompressor
{
    /*
    This script compresses a string array by converting it into a byte array,
    then zipping it, and finally returning a Base64 encoded version of it.
    */
    public static string CompressArray(string[] data)
    {
        if (data == null || data.Length == 0)
        {
            return string.Empty;
        }

        // Convert string array to a single byte array
        byte[] byteArray = Encoding.UTF8.GetBytes(string.Join("\n", data));

        // Compress using GZip
        using (MemoryStream output = new MemoryStream())
        {
            using (GZipStream gzip = new GZipStream(output, CompressionMode.Compress, true))
            {
                gzip.Write(byteArray, 0, byteArray.Length);
                gzip.Close(); // Ensure all data is flushed before converting to Base64
            }
            return Convert.ToBase64String(output.ToArray());
        }
    }
}
