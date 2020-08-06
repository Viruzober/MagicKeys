using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MagicKeys.MagicKeys;

namespace DeveloperTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Speak("The kyka has been found!");
        }

    }
}
