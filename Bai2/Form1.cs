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

namespace Bai2
{
    public partial class Form1 : Form
    {
        byte[] data;
        string input, stringData;
        IPEndPoint ip;
        //TcpClient server;
        TcpClient client;
        IPEndPoint ipe;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttoncheck_Click(object sender, EventArgs e)
        {
            listBoxresult.Items.Add("Dang kiem tra dich vu TCP...");
                for (int i = 1; i <= 80; i++)
                {
                    checkTCP(i, textBoxiphost.Text);
                }
            listBoxresult.Items.Add("Dang kiem tra dich vu UDP...");
            for (int i = 1; i <= 80; i++)
            {
                checkUDP(i, textBoxiphost.Text);
            }

        }
        private void checkTCP(int port, string ipAddress)
        {
            ipe = new IPEndPoint(IPAddress.Parse(ipAddress), port);
            client = new TcpClient();
            try
            {
                client.Connect(ipe);
                listBoxresult.Items.Add(ipe.ToString() + " open");
                client.Close();
            }
            catch (SocketException se)
            {
                listBoxresult.Items.Add(ipe.ToString() + " closed");
            }
        }
        private void checkUDP(int port, string ipAddress)
        {
            UdpClient udp = new UdpClient();
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(ipAddress), port);
            byte[] data = new byte[1024];
            udp.Client.ReceiveTimeout = 1000;
            udp.Connect(ipe);
            udp.Send(data,data.Length);
            try
            {
                udp.Receive(ref ipe);
                listBoxresult.Items.Add(ipe.ToString() + " open");
            }
            catch
            {
                listBoxresult.Items.Add(ipe.ToString() + " closed");
            }
        }
       
    }
}
