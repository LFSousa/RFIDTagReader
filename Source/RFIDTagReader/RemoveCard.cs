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
    public partial class RemoveCard : Form
    {
        public static String tagString;
        public RemoveCard()
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
                if (Main.entries.ContainsKey(tagString))
                {
                    File.Delete("Entries/" + tagString + ".txt");
                    Main.entries.Remove(tagString);
                    MessageBox.Show("Tag Removed", "Alert");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Key not added", "Error");
                    this.Close();
                }
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
