using System;

using System.Runtime.Remoting;

using System.Runtime.Remoting.Channels;

using System.Runtime.Remoting.Channels.Tcp;
using System.Web.UI.MobileControls;
using System.Windows.Forms;

using RemotingServer;
using static System.Net.Mime.MediaTypeNames;

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

            string result = service.SayHello(txtName.Text);

            MessageBox.Show(result, "Remote Response");

        }



        private void btnHighestNumber_Click(object sender, EventArgs e)

        {

            int n1, n2;

            if (int.TryParse(txtNum1.Text, out n1) && int.TryParse(txtNum2.Text, out n2))

            {

                int result = service.HighestNumber(n1, n2);

                MessageBox.Show("The highest number is: " + result, "Remote Response");

            }

            else

            {

                MessageBox.Show("Invalid input. Please enter valid numbers.", "Error");

            }

        }

    }



    static class Program

    {

        [STAThread]

        static void Main()

        {

            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainForm());

        }

    }

}
