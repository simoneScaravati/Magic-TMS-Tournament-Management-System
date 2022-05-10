using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Magic_Tournamente_Tables_Management_System.version;

namespace Magic_Tournamente_Tables_Management_System
{
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
            setVersion();
        }

        public void setVersion()
        {
            this.labelVersion.Text = "VERSION: " + version.VER_MAJOR.ToString() + "." + version.VER_MINOR.ToString() + "." + version.VER_REVISION.ToString();
        }
    }
}
