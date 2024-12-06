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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Belgeler\KanBankasıDb.mdf;Integrated Security = True; Connect Timeout = 30");
        private void Reset()
        {
            HAdSoyadTb.Text = "";
            HYasTb.Text = "";
            HCinsCb.SelectedIndex = -1;
            HTelefonTb.Text = "";
            HAdresTb.Text = "";
            HKGrupCb.SelectedIndex = -1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (HAdSoyadTb.Text == "" || HYasTb.Text == "" || HCinsCb.SelectedIndex == -1 || HTelefonTb.Text == "||DKGrupCb.SelectedIndex==-1||DAdresTb.Text==")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    string query = "insert into HastaTbl values('" + HAdSoyadTb.Text + "'," + HYasTb.Text + ",'" + HTelefonTb.Text + "','" + HCinsCb.SelectedItem.ToString() + "','" + HKGrupCb.SelectedItem.ToString() + "','" + HAdresTb.Text + "')";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(query, baglanti); 
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Hasta Bşarıyla Kaydedildi");
                    baglanti.Close();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error"+Ex.Message);
                }
            }
        }
    }
}
