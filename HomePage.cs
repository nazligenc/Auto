using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanBaS
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#EDE4EE");
        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
