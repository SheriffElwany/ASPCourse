using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace IOSystemSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //check for permissions every time 


            //var path = @"D:\pic1\AMF limits.png";
            //if (!File.Exists(path)) return;
            //File.Copy(@"D:\pic1\AMF limits.png", @"D:\pic2\AMF limits.png",true);
           
            ////File.Delete(path);
            //var content = File.ReadAllText(@"d:\SampleFile.txt");
            //Console.WriteLine(content);

            //*****************

            /// dir is faster in memory and check permisiions once
            #region Dirctory
            Directory.CreateDirectory(@"c:\TEMP\folder1");
            var files= Directory.GetFiles(@"c:\Logs", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            #endregion
        }
    }
}
