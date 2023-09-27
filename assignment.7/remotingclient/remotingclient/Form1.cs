using System;

using System.Runtime.Remoting;

using System.Runtime.Remoting.Channels;

using System.Runtime.Remoting.Channels.Tcp;

using System.Windows.Forms;

using RemotingServer;



namespace RemotingClient

{

    public partial class MainForm : Form

    {

        private Service service;



        public MainForm()

        {

            InitializeComponent();



            // Create a TCP channel with port

            TcpChannel tcpChannel = new TcpChannel(8002); // Use the same port as the server



            // Register the TCP channel

            ChannelServices.RegisterChannel(tcpChannel);



            // Create a service class object

            service = (Service)Activator.GetObject(typeof(Service),

                "tcp://localhost:8089/OurFirstRemoteService"); // Use the correct server address and port

        }



        private void btnSayHello_Click(object sender, EventArgs e)

        {

            string result = service.SayHello(textBox1.Text);

            button1.Text = result;

        }



        private void btnAdd_Click(object sender, EventArgs e)

        {

            int n1, n2;

            if (int.TryParse(textBox2.Text, out n1) && int.TryParse(button2.Text, out n2))

            {

                int result = service.Add(n1, n2);

                button2.Text = "Result: " + result.ToString();

            }

            else

            {

                button2.Text = "Invalid input. Please enter valid numbers.";

            }

        }



        private void btnSubtract_Click(object sender, EventArgs e)

        {

            int n1, n2;

            if (int.TryParse(textBox1.Text, out n1) && int.TryParse(textBox2.Text, out n2))

            {

                int result = service.Subtract(n1, n2);

                button3.Text = "Result: " + result.ToString();

            }

            else

            {

                button3.Text = "Invalid input. Please enter valid numbers.";

            }

        }



        private void btnMultiply_Click(object sender, EventArgs e)

        {

            int n1, n2;

            if (int.TryParse(textBox1.Text, out n1) && int.TryParse(textBox2.Text, out n2))

            {

                int result = service.Multiply(n1, n2);

                button4.Text = "Result: " + result.ToString();

            }

            else

            {

                button4.Text = "Invalid input. Please enter valid numbers.";

            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }

}