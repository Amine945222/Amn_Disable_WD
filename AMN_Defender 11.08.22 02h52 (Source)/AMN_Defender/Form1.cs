using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMN_Defender.Defender;

namespace AMN_Defender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Enable_Click(object sender, EventArgs e)
        {
            Enable.RunEnable();
        }

        private void button_Disable_Click(object sender, EventArgs e)
        {
            Disable.RunDisable();
        }
    }
    public class UTIL
    {
        //public static void 
    }
}
