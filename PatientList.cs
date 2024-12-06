using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KanBaS
{
    public partial class PatientList : Form
    {
        public PatientList()
        {
            InitializeComponent();
            uyeler();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Belgeler\KanBankasıDb.mdf;Integrated Security = True; Connect Timeout = 30");
        private void uyeler()
        {
            baglanti.Open();
            string query = "select from HastaTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder bulder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            HastaDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HastaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
