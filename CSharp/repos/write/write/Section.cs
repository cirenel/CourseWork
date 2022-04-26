using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace write
{
    class Section
    {
        public string path;
        public string contents;
        public string title;
        public DateTime lastSave; 

        public Section()
        {

        }
        public Section(string t)
        {
            title = t;
            path =  t + ".txt";
        }

        public bool createSection()
        {
            if (!File.Exists(path))
            {
                return true; 
            }
            return false; 
        }
        public bool openSection()
        {
            if ((contents == null || contents=="") && File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        contents += s; 
                    }
                }
                return true; 
            }

            return false; 
        }

        public bool writeSection()
        {
            if ((contents != null || contents != "") )
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(contents);
                }
                lastSave = DateTime.Now;
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return title ; 
        }

    }
}
