﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace B1944
{
    internal class Update
    {
        public Update()
        {

        }

        public string updateConfig()
        {
            String strFile = File.ReadAllText(@"C:\Program Files (x86)\Steam\steamapps\common\Battalion 1944\Battalion\configs\custom\custom4.config");

            string[] lines = System.IO.File.ReadAllLines(@"C:\Program Files (x86)\Steam\steamapps\common\Battalion 1944\Battalion\configs\presets\default.config");
            string[] lines2 = System.IO.File.ReadAllLines(@"C:\Program Files (x86)\Steam\steamapps\common\Battalion 1944\Battalion\configs\custom\custom4.config");
            
            var version = "";
            var temp = "";

            // Display the file contents by using a foreach loop.
            foreach (string line in lines)
            {
                if (line.Contains("version"))
                {
                    version = "\t" + line;
                    //Console.WriteLine(version);
                    continue;
                }
            }
            foreach (string line2 in lines2)
            {
                if (line2.Contains("version"))
                {
                    temp = line2;
                    //Console.WriteLine(temp);
                    continue;
                }
            }

            strFile = strFile.Replace(temp, version);
            File.WriteAllText(@"C:\Program Files (x86)\Steam\steamapps\common\Battalion 1944\Battalion\configs\custom\custom4.config", strFile);

            temp = version;

            return version + "|" + temp;
        }

    }
}