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
    public partial class Donor : Form
    {
        public Donor()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Belgeler\KanBankasıDb.mdf;Integrated Security = True; Connect Timeout = 30");
        private void Reset()
        {
            DAdSoyadTb.Text = "";
            DYasTb.Text = "";
            DCinsCb.SelectedIndex = -1;
            DTelefonTb.Text = "";
            DAdresTb.Text = "";
            DKGrupCb.SelectedIndex = -1;
        }

        private void Donor_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#EDE4EE");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (DAdSoyadTb.Text == "" || DYasTb.Text == "" || DCinsCb.SelectedIndex == -1 || DTelefonTb.Text == "||DKGrupCb.SelectedIndex==-1||DAdresTb.Text==")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    string query = "insert into DonorTbl values('" + DAdSoyadTb.Text + "'," + DYasTb.Text + ",'" + DCinsCb.SelectedItem.ToString() + "','" + DTelefonTb.Text + "','" + DAdresTb.Text + "','" + DKGrupCb.SelectedItem.ToString() + "')";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Donor Bşarıyla Kaydedildi");
                    baglanti.Close();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }
            }
        }

        private void Donor_Load_1(object sender, EventArgs e)
        {

        }
    }
}

