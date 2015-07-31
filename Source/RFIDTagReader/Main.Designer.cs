namespace RFIDTagReader
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RemoveCardBT = new System.Windows.Forms.Button();
            this.AddCardBt = new System.Windows.Forms.Button();
            this.LogView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(477, 443);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RemoveCardBT);
            this.tabPage1.Controls.Add(this.AddCardBt);
            this.tabPage1.Controls.Add(this.LogView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(469, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RemoveCardBT
            // 
            this.RemoveCardBT.Location = new System.Drawing.Point(344, 36);
            this.RemoveCardBT.Name = "RemoveCardBT";
            this.RemoveCardBT.Size = new System.Drawing.Size(117, 23);
            this.RemoveCardBT.TabIndex = 2;
            this.RemoveCardBT.Text = "Remove Card";
            this.RemoveCardBT.UseVisualStyleBackColor = true;
            this.RemoveCardBT.Click += new System.EventHandler(this.RemoveCardBT_Click);
            // 
            // AddCardBt
            // 
            this.AddCardBt.Location = new System.Drawing.Point(344, 7);
            this.AddCardBt.Name = "AddCardBt";
            this.AddCardBt.Size = new System.Drawing.Size(117, 23);
            this.AddCardBt.TabIndex = 1;
            this.AddCardBt.Text = "Add Card";
            this.AddCardBt.UseVisualStyleBackColor = true;
            this.AddCardBt.Click += new System.EventHandler(this.AddCard_Click);
            // 
            // LogView
            // 
            this.LogView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LogView.LabelWrap = false;
            this.LogView.Location = new System.Drawing.Point(8, 6);
            this.LogView.Name = "LogView";
            this.LogView.Size = new System.Drawing.Size(329, 405);
            this.LogView.TabIndex = 0;
            this.LogView.UseCompatibleStateImageBehavior = false;
            this.LogView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Key";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time";
            this.columnHeader2.Width = 97;
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 443);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RFID Tag Reader";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ListView LogView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button AddCardBt;
        private System.Windows.Forms.Button RemoveCardBT;
    }
}