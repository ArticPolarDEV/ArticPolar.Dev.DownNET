# ArticPolar.Dev.DownNET
Download files from Internet in Console and WinForms Application C#

# Usage: 
````
using System;
using ArticPolar.Dev.DownNET;

namespace MyApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Functions.Download("url/to/download/file", @"path/to/save/file", QuietDownload: true, ForceReplace: false);
     }
  }
}
````
* NO TESTED IN C# WINFORMS!!
