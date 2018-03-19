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
    public partial class geschiedenispagina : Form
    {
        public Array geschiedenis_array;
        public geschiedenispagina(Array geschiedenis)
        {
            InitializeComponent();
            geschiedenis_array = geschiedenis;
            
        }

        //Als pagina is geladen
        private void geschiedenispagina_Load(object sender, EventArgs e)
        {
            foreach(String gs in geschiedenis_array)
            {
                Console.WriteLine(gs);
            }
        }
    }
}
