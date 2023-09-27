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

namespace Projeto1
{
    public partial class btnMessage : Form
    {
        public btnMessage()
        {
            InitializeComponent();
        }

       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMessage_Load(object sender, EventArgs e)
        {

        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            Conection conection = new Conection();
            SqlCommand sqlComand = new SqlCommand();

            sqlComand.Connection = conection.ReturnConnection();
            sqlComand.CommandText = @"INSERT INTO login VALUES (@nome, @email, @senha)";

            sqlComand.Parameters.AddWithValue("@nome", txbNome.Text);
            sqlComand.Parameters.AddWithValue("@email", txbPront.Text);
            sqlComand.Parameters.AddWithValue("@senha", txbSenha.Text);

            sqlComand.ExecuteNonQuery();

            MessageBox.Show("Cadastro com sucesso)",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txbNome.Clear();
            txbPront.Clear();
            txbSenha.Clear();
            txbNome.Clear();
            txbNome.Clear();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPront_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
