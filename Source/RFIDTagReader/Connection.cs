using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFIDTagReader
{
    public partial class Connection : Form
    {
        public static String Port;
        public Connection()
        {
            InitializeComponent();
        }

        private void Connection_Load(object sender, EventArgs e)
        {
            RefreshCOM();
        }

        private void RefreshCOM()
        {
            int i;
            bool pStill;

            i = 0;
            pStill = false;

            if (Ports.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (Ports.Items[i++].Equals(s) == false)
                    {
                        pStill = true;
                    }
                }
            }
            else
            {
                pStill = true;
            }

            if (pStill == false)
            {
                return;
            }

            Ports.Items.Clear();

            foreach (string s in SerialPort.GetPortNames())
            {
                Ports.Items.Add(s);
            }
            Ports.SelectedIndex = 0;
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == false)
            {
                try
                {
                    serialPort.PortName = Ports.Items[Ports.SelectedIndex].ToString();
                    serialPort.Open();
                }
                catch
                {
                    return;
                }
                if (serialPort.IsOpen)
                {
                    Ports.Enabled = false; 
                    progressBar.Visible = true;
                    Connect.Visible = false;
                    try
                    {
                        Main.entries = new Dictionary<string, List<string>>();
                        DirectoryInfo d = new DirectoryInfo("Entries");

                        foreach (var file in d.GetFiles("*.txt"))
                        {
                            List<String> lines = new List<string>();
                            foreach (String l in File.ReadAllLines(file.FullName))
                            {
                                lines.Add(l);
                            }
                            Main.entries.Add(file.Name.Replace(".txt", ""), lines);
                        }
                    }
                    finally
                    {
                        Port = Ports.Items[Ports.SelectedIndex].ToString();
                        serialPort.Close();
                        Main m = new Main();
                        this.Hide();
                        m.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private void COMr_Tick(object sender, EventArgs e)
        {
            RefreshCOM();
        }
    }
}
