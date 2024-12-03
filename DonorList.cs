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
    public partial class DonorList : Form
    {
        public DonorList()
        {
            InitializeComponent();
        }

        private void DonorList_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#EDE4EE");
            dtDonorList.BackgroundColor = ColorTranslator.FromHtml("#EDE4EE");
        }

        private void dtDonorList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
