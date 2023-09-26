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
        private object txtName;
        private object txtNum1;
        private object txtNum2;

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

        private void InitializeComponent()
        {
            throw new NotImplementedException();
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

        

        static void Main()

        {

            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainForm());

        }

    }

}