using System;
using System.IO.Compression;

namespace _06.ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"E:\FileDirectory", @"E:\CreateZipFile\myZipFile");
            ZipFile.ExtractToDirectory(@"E:\CreateZipFile\myZipFile", @"E:\ExtractZipFile");
        }
    }
}
