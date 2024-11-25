using System.Management;
using System.Net.Sockets;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text.Json;
using System.Text;


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
            NotifyIcon trayIcon;

            trayIcon = new NotifyIcon();
            trayIcon.Icon = new System.Drawing.Icon("icone.ico"); // Use um ícone personalizado
            trayIcon.Text = "Seu App está rodando";
            trayIcon.Visible = true;

            // Criando o menu de contexto
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Abrir", null, (sender, e) =>
            {
                this.Show();
                this.ShowInTaskbar = true;

            }); // Exibe a janela principal
            contextMenu.Items.Add("Sair", null, (sender, e) => Application.Exit()); // Fecha o programa

            // Associando o menu de contexto ao NotifyIcon
            trayIcon.ContextMenuStrip = contextMenu;

            this.ShowInTaskbar = false; // Não mostrar na barra de tarefas
            this.WindowState = FormWindowState.Minimized; // Iniciar minimizado
            this.Hide(); // Esconde a janela principal



            lblComputerNameField.Text = GetMachineName();

            lblUserNameField.Text = GetUserName();

            lblOperatingSystemField.Text = GetOperatingSystem();

            lblProcessorField.Text = GetProcessor();

            lblIpAddressField.Text = GetLocalIPAddress();

            lblMacAddressField.Text = GetMacAddress();


            Task.Run(() => SendRequestAsync());

        }

        private async Task SendRequestAsync()
        {
            string request = GenerateRequestObject();

            using (HttpClient client = new HttpClient())
            {

                var content = new StringContent(request, Encoding.UTF8, "application/json");
                await client.PostAsync("http://localhost:8080/api/v1/devices", content);
            }
        }

        private string GenerateRequestObject()
        {

            var requestObject = new
            {
                id = Guid.NewGuid(),
                name = GetMachineName(),
                username = GetUserName(),
                operatingSystem = GetOperatingSystem(),
                ip = GetLocalIPAddress(),
                mac = GetMacAddress()
            };

            string requestJson = JsonSerializer.Serialize(requestObject);

            return requestJson;

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

            this.ShowInTaskbar = false; // Não mostrar na barra de tarefas
            this.WindowState = FormWindowState.Minimized; // Iniciar minimizado
            this.Hide(); // Esconde a janela principal

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
