using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace NavegacaoPosicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestStack.White.Application app =
                TestStack.White.Application
                .Launch(@"C:\Users\Luis\Desktop\Crawler\WebBrowser\WebBrowser\bin\Debug\WebBrowser.exe");

            Window window = app.GetWindow("Titulos");

            SearchCriteria criteria = SearchCriteria.ByText("Com estrela");
            
            var link = window.Get<Hyperlink>(criteria);
            link.Click();


            //TestStack.White.UIItems.Hyperlink link;
            //link.GetElement(criteria);
        }
    }
}
