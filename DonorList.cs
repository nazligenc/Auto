using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KanBaS
{
    public partial class DonorList : Form
    {
        public DonorList()
        {
            InitializeComponent();
            uyeler();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Belgeler\KanBankasıDb.mdf;Integrated Security = True; Connect Timeout = 30");
        private void uyeler()
        {
            baglanti.Open();
            string query = "select from DonorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder bulder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DonorDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void DonorList_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#EDE4EE");
            DonorDGV.BackgroundColor = ColorTranslator.FromHtml("#EDE4EE");
        }

        private void dtDonorList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
