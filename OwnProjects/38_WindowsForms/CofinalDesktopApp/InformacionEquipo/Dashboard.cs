using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Text.RegularExpressions;

namespace InformacionEquipo
{
    public partial class Dashboard : Form
    {
        List<string> carpetasCompartidas = new List<string>();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void ObtenerButton_Click(object sender, EventArgs e)
        {
            string nombreUsuario = Environment.UserName;
            string nombreDominio = Environment.UserDomainName;
            string nombreComputador = Environment.MachineName;

            NombreUsuarioText.Text = nombreUsuario;
            NombreDominioText.Text = nombreDominio;
            NombreComputadorText.Text = nombreComputador;
            IpText.Text = ObtenerIp();

            ObtenerCarpetasCompartidas();
            CarpetasCompartidasListaBox.DataSource = carpetasCompartidas;

        }

        private string ObtenerIp()
        {
            string output = "";
            try
            {
                IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress address in hostEntry.AddressList)
                {
                    if (address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        output = address.ToString();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la dirección IP: " + ex.Message);
            }

            return output;
        }
        private void ObtenerCarpetasCompartidas()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c net use";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.OutputDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    string line = e.Data.Trim();
                    if (line.StartsWith("OK") || line.StartsWith("Usado") || line.StartsWith("The command completed"))
                    {
                        return;
                    }
                    if (line.Contains("Conectado"))
                    {
                        carpetasCompartidas.Add(line);
                    }
                }
            };

            process.ErrorDataReceived += (sender, e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    Console.WriteLine("Error: " + e.Data);
                }
            };

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit();
        }
    }
}
