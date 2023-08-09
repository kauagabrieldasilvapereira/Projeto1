using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            string name = txbNome.Text;
            string enrollmanet = txbPront.Text;

            string message = "Nome: " + name +
                "\nMatricula:" + enrollmanet;
            MessageBox.Show(message,
                "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }
    }
}
