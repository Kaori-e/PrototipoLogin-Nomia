using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;



namespace Exercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();  // Est� dando erro aqui por: Exce��o sem tratamento .

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pb_Ledlogado_Click(object sender, EventArgs e)
        {

        }

       
    }
}