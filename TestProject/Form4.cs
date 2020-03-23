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

namespace TestProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //Connect("192.168.1.245", "Send");

            TcpClient client = new TcpClient();
            client.Connect(new IPEndPoint(IPAddress.Parse("192.168.1.245"), 23));
            while (!client.Connected) { } // Wait for connection

            WriteData(client.GetStream(), "Send to server");
            while (true)
            {
                NetworkStream strm = client.GetStream();
                if (ReadData(strm) != string.Empty)
                {
                    //Console.WriteLine("Connect to scale " + ReadData(strm));
                    textBox1.Text = "Connected";
                }
            }


        }

        private void Connect(string server, string message)
        {            
            try
            {
                // Create a TcpClient. 
                // Note, for this client to work you need to have a TcpServer  
                // connected to the same address as specified by the server, port combination.
                int port = 23;
                TcpClient client = new TcpClient(server, port);

                //Translate the passed message into ASCII and store it as a Byte array.
                byte[]  data = System.Text.Encoding.ASCII.GetBytes(message);

                //Get a client stream for reading and writing. 
                //Stream stream = client.GetStream();
                NetworkStream stream = client.GetStream();

                //Send the message to the connected TcpServer. 
                stream.Write(data, 0, data.Length);
                //textBox1.Text = "Sent: " + message + System.Environment.NewLine;
                MessageBox.Show("Sent: {0}", message);
                //Console.WriteLine("Sent: {0}", message);

                 //Receive the TcpServer.response. Buffer to store the response bytes.
                 data = new byte[256];

                string responseData = null;

                //Read the first batch of the TcpServer response bytes. 
                int bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                textBox1.Text += "Receive: " + System.Environment.NewLine + responseData + System.Environment.NewLine;
                //MessageBox.Show("Receive: {0}", responseData);
                //Console.WriteLine("Receive: {0}", responseData);

                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show("ArgumentNullException: {0}", e.Message);
                //Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                MessageBox.Show("ArgumentNullException: {0}", e.Message);
                //Console.WriteLine("ArgumentNullException: {0}", e);
            }
            //textBox1.Text += "The end";
            //MessageBox.Show("The end");
            //Console.WriteLine("The end");
        }

        static string ReadData(NetworkStream network)
        {
            string Output = string.Empty;
            byte[] bReads = new byte[1024];
            int ReadAmount = 0;

            while (network.DataAvailable)
            {
                ReadAmount = network.Read(bReads, 0, bReads.Length);

                Output += string.Format("{0}", Encoding.ASCII.GetString(
                        bReads, 0, ReadAmount));
            }
            return Output;
        }

        static void WriteData(NetworkStream stream, string cmd)
        {
            stream.Write(Encoding.UTF8.GetBytes(cmd), 0,
                        Encoding.UTF8.GetBytes(cmd).Length);
        }
    }    
}
