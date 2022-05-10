using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Tournamente_Tables_Management_System
{
    public class version
    {
        public const int VER_MAJOR     = 0;
        public const int VER_MINOR     = 1;
        public const int VER_REVISION  = 0;

        public static string getVersionText()
        {
            return "VERSION: " + version.VER_MAJOR.ToString() + "." + version.VER_MINOR.ToString() + "." + version.VER_REVISION.ToString();
        }

    }
}
