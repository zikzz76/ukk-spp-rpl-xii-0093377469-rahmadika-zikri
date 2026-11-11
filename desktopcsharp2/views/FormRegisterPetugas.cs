using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktopcsharp2.views
{
    public partial class FormRegisterPetugas : Form
    {
        public FormRegisterPetugas()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormRegisterPetugas_Load(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                 string.IsNullOrWhiteSpace(txtNamaPetugas.Text) ||
                string.IsNullOrWhiteSpace(txtKonfirmasiPassword.Text))
            {
                MessageBox.Show("tidak boleh ada yang kosong");
                return;
            }
            if (txtPassword.Text != txtKonfirmasiPassword.Text)
            {
                MessageBox.Show("password yang di masukan salah");
                return;
            }
            if (txtPassword.Text.Length<6)
            {
                MessageBox.Show("password yang di masukan harus lebih dari 6 huruf");
                return;
            }



               
        }
    }
}
