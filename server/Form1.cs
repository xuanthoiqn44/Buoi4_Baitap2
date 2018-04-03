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
using System.Net;

namespace server
{
    public partial class Form1 : Form
    {
        int recv;
        byte[] data;
        TcpListener server;
        TcpClient client;
        NetworkStream ns;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data = new byte[1024];
            server = new TcpListener(9050);
            server.Start();
        }
    }
}
