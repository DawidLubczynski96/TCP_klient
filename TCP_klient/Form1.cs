using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace TCP_klient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void info_o_polaczeniu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adres_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void przycisk_polacz_Click(object sender, EventArgs e)
        {
            string host = adres.Text;
            int port = Convert.ToInt32(my_port.Value);
            try
            {
                TcpClient klient = new TcpClient(host, port);
                info_o_polaczeniu.Items.Add("Nawiązano połącznie z" + host + "na porcie:" + port);
                klient.Close();
            }
            catch(Exception ex)
            {
                info_o_polaczeniu.Items.Add("Błąd: Nie udało się nawiązać połączenia!");
                MessageBox.Show(ex.ToString(), "Błąd");
            }
        }
    }
}
