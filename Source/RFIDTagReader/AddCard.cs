using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFIDTagReader
{
    public partial class AddCard : Form
    {
        public static String tagString;
        public AddCard()
        {
            InitializeComponent();
        }

        public static void TagAdd(string tag){
            tagString = tag;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (tagString != null)
            {
                timer.Enabled = false;
                if (!Main.entries.ContainsKey(tagString))
                {
                    textBox1.Text = tagString;
                    Name.Focus();
                    panel1.Visible = true;
                    label1.Visible = false;
                }
                else
                {
                    MessageBox.Show("Key awready added", "Error");
                    this.Close();
                }
            }
        }

        private void AddEntry_Click(object sender, EventArgs e)
        {
            string[] lines = {Name.Text};
            String pt = "Entries/" + tagString + ".txt";
            try
            {
                File.WriteAllLines(pt, lines);
            }
            finally
            {
                List<String> li = new List<string>();
                foreach (String l in File.ReadAllLines(pt))
                {
                    li.Add(l);
                }
                Main.entries.Add(tagString, li);
                MessageBox.Show("Entry Added", "Alert");
                tagString = null;
                Main.serialIntercept = false;
                Main.FromIntecepted = null;
                this.Close();
            }
        }

        private void AddCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            tagString = null;
            Main.serialIntercept = false;
            Main.FromIntecepted = null;
            Main.oldEntry = "";
        }
    }
}
