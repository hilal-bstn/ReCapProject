using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.FileHelper
{
    public class FileHelper
    {
        public static string AddFile(IFormFile file,string path)
        {
            var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            if (!Directory.Exists(path))
            { Directory.CreateDirectory(path); }
            using (FileStream fileStream = System.IO.File.Create(path + fileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            return fileName;
        }
        public static string Update(IFormFile file,string filepath,string carImagepath)
        {
            File.Delete(filepath+carImagepath);
            //string updatePath = Path.Combine(carImagepath);
            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            //var FileNamePath = Path.Combine(filepath,fileName);
            //System.IO.File.Move(updatePath, carImagepath);
            using (FileStream fileStream = System.IO.File.Create(filepath + fileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            

            return fileName;
        }
        public static void Delete(string filepath,string imagepath)
        {
           System.IO.File.Delete(filepath+imagepath);
        }
        public static Byte[] Get(string filepath,string imagepath)
        {
          
            Byte[] b = System.IO.File.ReadAllBytes(filepath +imagepath);
            //return File(b, "image/png");
            return b;
        }
        //public static List<Byte[]> GetAll(string filepath, List<string> images)
        //{
            
        //    List<Byte[]>imagesFiles=new List<byte[]>();
        //    foreach (var i in images)
        //    {
        //       imagesFiles.Add(System.IO.File.ReadAllBytes(filepath + i));
        //    }
            
        //    return imagesFiles;
        //}

    }
}
