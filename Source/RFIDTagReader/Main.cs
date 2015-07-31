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
    public partial class Main : Form
    {
        public static Dictionary<String, List<String>> entries;
        String RxString;
        public static String oldEntry = "";
        public static Boolean serialIntercept = false;
        public static String FromIntecepted;
        public Main()
        {
            InitializeComponent();
            
            if (serialPort.IsOpen == false)
            {
                try
                {
                    serialPort.PortName = Connection.Port;
                    serialPort.Open();
                }
                catch
                {
                    return;
                }
                if (serialPort.IsOpen)
                {

                }
            }
        }
        private void serialRecived(object sender, EventArgs e)
        {
            ListViewItem li = new ListViewItem();

            ListViewItem.ListViewSubItem tm = new ListViewItem.ListViewSubItem();
            tm.Text = DateTime.Now.ToString("h:mm:ss tt");
            li.SubItems.Add(tm);
            if (!entries.ContainsKey(RxString))
            {
                li.ForeColor = Color.Red;
                li.Text = RxString;
                LogView.Items.Add(li);
            }
            else
            {
                li.ForeColor = Color.Green;
                li.Text = entries[RxString][0];
                LogView.Items.Add(li);
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = serialPort.ReadExisting();
            if (!serialIntercept)
            {
                if (oldEntry != RxString)
                {
                    this.Invoke(new EventHandler(serialRecived));
                    oldEntry = RxString;
                }
            }
            else
            {
                switch (FromIntecepted)
                {
                    case "Add":
                        AddCard.TagAdd(RxString);
                        break;
                    case "Remove":
                        RemoveCard.TagAdd(RxString);
                        break;
                    default:
                        serialIntercept = false;
                        break;
                }
            }
        }

        private void AddCard_Click(object sender, EventArgs e)
        {
            FromIntecepted = "Add";
            serialIntercept = true;
            AddCard ad = new AddCard();
            ad.ShowDialog();
        }

        private void RemoveCardBT_Click(object sender, EventArgs e)
        {
            FromIntecepted = "Remove";
            serialIntercept = true;
            RemoveCard ad = new RemoveCard();
            ad.ShowDialog();
        }
    }
}
