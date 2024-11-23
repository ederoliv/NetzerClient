using System.Management;
using System.Net.Sockets;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.Json.Nodes;
using System.Text.Json;

namespace NetzerClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblComputerNameField.Text = GetMachineName();

            lblUserNameField.Text = GetUserName();

            lblOperatingSystemField.Text = GetOperatingSystem();

            lblProcessorField.Text = GetProcessor();

            lblIpAddressField.Text = GetLocalIPAddress();

            lblMacAddressField.Text = GetMacAddress();

            var requestObject = new
            {
                machineName = lblComputerNameField.Text,
                userName = lblUserNameField.Text,
                operatingSystem = lblOperatingSystemField.Text,
                processor = lblProcessorField.Text,
                ipAddress = lblIpAddressField.Text,
                macAddress = lblMacAddressField.Text
            };

            string requestJson = JsonSerializer.Serialize(requestObject);

            //MessageBox.Show(requestJson);
        }



        private static String GetProcessor()
        {
            try
            {
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select Name, ProcessorId from Win32_Processor"))
                {
                    foreach (ManagementObject obj in searcher.Get())
                    {
                        return $"{obj["Name"]}";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return "Erro ao obter processador";

        }

        private static String? GetOperatingSystem()
        {

            var name = (from x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().Cast<ManagementObject>()
                        select x.GetPropertyValue("Caption")).FirstOrDefault();
            return name != null ? name.ToString() : "Unknown";

            //return Environment.OSVersion.ToString();
        }

        private static String GetMachineName()
        {
            return Environment.MachineName;
        }

        private static String GetUserName()
        {
            return Environment.UserName;
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private string GetMacAddress()
        {
            string macAddresses = string.Empty;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }

            return macAddresses;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }





















        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
    }
}
