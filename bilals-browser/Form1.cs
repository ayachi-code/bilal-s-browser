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
        //Array geschiedenis
        public String[] geschiedenis;
        //Lengte van array
        public int lengte_geschiedenis = 10;

        public Form1()
        {
            InitializeComponent();
            browser.Navigate("https://google.com");
            //Geschiedenis word 10 lang
            geschiedenis = new String[lengte_geschiedenis];               
        }


        //Calback van een enter op de url balk
        private void url_KeyPress(object sender, KeyPressEventArgs e)
        {
          //Als iemand enter klikt
          if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                String url_naam = url.Text;
                if (!(url_naam.Contains("http://") || url_naam.Contains("https://")))
                {
                    //Veranderd de url naar een string
                    String url_naam_string = url_naam.ToString();
                    //De url krijgt een http:// bij
                    String url_niewe = "http://" + url_naam_string;
                    //Negeer error's
                    browser.ScriptErrorsSuppressed = true;
                    //Navigeer daar na toe
                    browser.Navigate(url_niewe);
                    //Voegt 1 toe aan array
                    lengte_geschiedenis += 1;


                }
                else {
                    //Negeert error's
                    browser.ScriptErrorsSuppressed = true;
                    //navigeer naar url.Text
                    browser.Navigate(url.Text);
                    
                }
            }

          //Als iemand opzoek: wie heeft deze browser gemaakt: dan krijgt de client een message
          if (url.Text == "wie heeft deze browser gemaakt")
            {
                browser.Navigate("https://google.com");
                MessageBox.Show("Bilal el Ayachi ");
                url.Text = "";
                       
            }


        }

        //Als docuemnt geladen is...
        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {          
            Console.WriteLine("geladen");
   
            //Loopt door alle ellementen met een a tag
            foreach (HtmlElement a in browser.Document.GetElementsByTagName("a"))
            {
                //Geeft het een blauw kleur
                a.Style = "color:blue";
                   
            }
        }
        //Als er op opnieuw word geklikt
        private void button1_Click(object sender, EventArgs e)
        {
            //vernieuw de  huidigen pagina
            browser.Refresh();
        }
    }
}
