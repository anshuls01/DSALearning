// See https://aka.ms/new-console-template for more information

using System.IO.Compression;
using LinkedLists;

Console.WriteLine("LinkedList");
ZipperList zipperList = new ZipperList();
zipperList.PrintZipperList(zipperList.Create(zipperList.BuildFirstLL(), zipperList.BuildSecondLL()));