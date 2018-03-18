using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilals_browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        //Calback van een enter op de url balk
        private void url_KeyPress(object sender, KeyPressEventArgs e)
        {
          //Als iemand enter klikt
          if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                //Negeert error's
                browser.ScriptErrorsSuppressed = true;
            }
        }
    }
}
