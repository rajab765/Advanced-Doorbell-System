namespace SystemForm
{
    partial class Form1
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
            this.buttonNo1 = new System.Windows.Forms.Button();
            this.buttonNo2 = new System.Windows.Forms.Button();
            this.buttonNo3 = new System.Windows.Forms.Button();
            this.buttonNo4 = new System.Windows.Forms.Button();
            this.buttonNo5 = new System.Windows.Forms.Button();
            this.buttonNo6 = new System.Windows.Forms.Button();
            this.buttonNo7 = new System.Windows.Forms.Button();
            this.buttonNo8 = new System.Windows.Forms.Button();
            this.buttonNo9 = new System.Windows.Forms.Button();
            this.buttonNo0 = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.bluetoothComponent1 = new InTheHand.Net.Bluetooth.BluetoothComponent();
            this.selectBluetoothDeviceDialog1 = new InTheHand.Windows.Forms.SelectBluetoothDeviceDialog();
            this.buttonBell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNo1
            // 
            this.buttonNo1.Location = new System.Drawing.Point(35, 219);
            this.buttonNo1.Name = "buttonNo1";
            this.buttonNo1.Size = new System.Drawing.Size(67, 30);
            this.buttonNo1.TabIndex = 1;
            this.buttonNo1.Text = "1";
            this.buttonNo1.UseVisualStyleBackColor = true;
            this.buttonNo1.Click += new System.EventHandler(this.buttonNo1_Click);
            // 
            // buttonNo2
            // 
            this.buttonNo2.Location = new System.Drawing.Point(99, 219);
            this.buttonNo2.Name = "buttonNo2";
            this.buttonNo2.Size = new System.Drawing.Size(75, 30);
            this.buttonNo2.TabIndex = 2;
            this.buttonNo2.Text = "2";
            this.buttonNo2.UseVisualStyleBackColor = true;
            this.buttonNo2.Click += new System.EventHandler(this.buttonNo2_Click);
            // 
            // buttonNo3
            // 
            this.buttonNo3.Location = new System.Drawing.Point(171, 219);
            this.buttonNo3.Name = "buttonNo3";
            this.buttonNo3.Size = new System.Drawing.Size(75, 30);
            this.buttonNo3.TabIndex = 3;
            this.buttonNo3.Text = "3";
            this.buttonNo3.UseVisualStyleBackColor = true;
            this.buttonNo3.Click += new System.EventHandler(this.buttonNo3_Click);
            // 
            // buttonNo4
            // 
            this.buttonNo4.Location = new System.Drawing.Point(35, 190);
            this.buttonNo4.Name = "buttonNo4";
            this.buttonNo4.Size = new System.Drawing.Size(67, 29);
            this.buttonNo4.TabIndex = 4;
            this.buttonNo4.Text = "4";
            this.buttonNo4.UseVisualStyleBackColor = true;
            this.buttonNo4.Click += new System.EventHandler(this.buttonNo4_Click);
            // 
            // buttonNo5
            // 
            this.buttonNo5.Location = new System.Drawing.Point(99, 190);
            this.buttonNo5.Name = "buttonNo5";
            this.buttonNo5.Size = new System.Drawing.Size(75, 29);
            this.buttonNo5.TabIndex = 5;
            this.buttonNo5.Text = "5";
            this.buttonNo5.UseVisualStyleBackColor = true;
            this.buttonNo5.Click += new System.EventHandler(this.buttonNo5_Click);
            // 
            // buttonNo6
            // 
            this.buttonNo6.Location = new System.Drawing.Point(171, 190);
            this.buttonNo6.Name = "buttonNo6";
            this.buttonNo6.Size = new System.Drawing.Size(75, 29);
            this.buttonNo6.TabIndex = 6;
            this.buttonNo6.Text = "6";
            this.buttonNo6.UseVisualStyleBackColor = true;
            this.buttonNo6.Click += new System.EventHandler(this.buttonNo6_Click);
            // 
            // buttonNo7
            // 
            this.buttonNo7.Location = new System.Drawing.Point(35, 161);
            this.buttonNo7.Name = "buttonNo7";
            this.buttonNo7.Size = new System.Drawing.Size(67, 31);
            this.buttonNo7.TabIndex = 7;
            this.buttonNo7.Text = "7";
            this.buttonNo7.UseVisualStyleBackColor = true;
            this.buttonNo7.Click += new System.EventHandler(this.buttonNo7_Click);
            // 
            // buttonNo8
            // 
            this.buttonNo8.Location = new System.Drawing.Point(99, 161);
            this.buttonNo8.Name = "buttonNo8";
            this.buttonNo8.Size = new System.Drawing.Size(75, 31);
            this.buttonNo8.TabIndex = 8;
            this.buttonNo8.Text = "8";
            this.buttonNo8.UseVisualStyleBackColor = true;
            this.buttonNo8.Click += new System.EventHandler(this.buttonNo8_Click);
            // 
            // buttonNo9
            // 
            this.buttonNo9.Location = new System.Drawing.Point(171, 161);
            this.buttonNo9.Name = "buttonNo9";
            this.buttonNo9.Size = new System.Drawing.Size(75, 31);
            this.buttonNo9.TabIndex = 9;
            this.buttonNo9.Text = "9";
            this.buttonNo9.UseVisualStyleBackColor = true;
            this.buttonNo9.Click += new System.EventHandler(this.buttonNo9_Click);
            // 
            // buttonNo0
            // 
            this.buttonNo0.Location = new System.Drawing.Point(99, 248);
            this.buttonNo0.Name = "buttonNo0";
            this.buttonNo0.Size = new System.Drawing.Size(75, 34);
            this.buttonNo0.TabIndex = 10;
            this.buttonNo0.Text = "0";
            this.buttonNo0.UseVisualStyleBackColor = true;
            this.buttonNo0.Click += new System.EventHandler(this.buttonNo0_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonOk.ForeColor = System.Drawing.Color.Ivory;
            this.buttonOk.Location = new System.Drawing.Point(171, 248);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 34);
            this.buttonOk.TabIndex = 11;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = false;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.BackColor = System.Drawing.Color.DarkRed;
            this.buttonBackspace.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBackspace.Location = new System.Drawing.Point(35, 248);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(67, 34);
            this.buttonBackspace.TabIndex = 12;
            this.buttonBackspace.Text = "->";
            this.buttonBackspace.UseVisualStyleBackColor = false;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // codeBox
            // 
            this.codeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeBox.Location = new System.Drawing.Point(35, 110);
            this.codeBox.Name = "codeBox";
            this.codeBox.ReadOnly = true;
            this.codeBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.codeBox.Size = new System.Drawing.Size(211, 45);
            this.codeBox.TabIndex = 13;
            this.codeBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // selectBluetoothDeviceDialog1
            // 
            this.selectBluetoothDeviceDialog1.AddNewDeviceWizard = false;
            this.selectBluetoothDeviceDialog1.DeviceFilter = null;
            this.selectBluetoothDeviceDialog1.DiscoverableOnly = false;
            this.selectBluetoothDeviceDialog1.ForceAuthentication = false;
            this.selectBluetoothDeviceDialog1.Info = null;
            this.selectBluetoothDeviceDialog1.ShowAuthenticated = true;
            this.selectBluetoothDeviceDialog1.ShowDiscoverableOnly = false;
            this.selectBluetoothDeviceDialog1.ShowRemembered = true;
            this.selectBluetoothDeviceDialog1.ShowUnknown = true;
            this.selectBluetoothDeviceDialog1.SkipServicesPage = false;
            // 
            // buttonBell
            // 
            this.buttonBell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBell.Location = new System.Drawing.Point(35, 12);
            this.buttonBell.Name = "buttonBell";
            this.buttonBell.Size = new System.Drawing.Size(211, 81);
            this.buttonBell.TabIndex = 14;
            this.buttonBell.Text = "Door Bell";
            this.buttonBell.UseVisualStyleBackColor = true;
            this.buttonBell.Click += new System.EventHandler(this.buttonBell_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 293);
            this.Controls.Add(this.buttonBell);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonNo0);
            this.Controls.Add(this.buttonNo9);
            this.Controls.Add(this.buttonNo8);
            this.Controls.Add(this.buttonNo7);
            this.Controls.Add(this.buttonNo6);
            this.Controls.Add(this.buttonNo5);
            this.Controls.Add(this.buttonNo4);
            this.Controls.Add(this.buttonNo3);
            this.Controls.Add(this.buttonNo2);
            this.Controls.Add(this.buttonNo1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNo1;
        private System.Windows.Forms.Button buttonNo2;
        private System.Windows.Forms.Button buttonNo3;
        private System.Windows.Forms.Button buttonNo4;
        private System.Windows.Forms.Button buttonNo5;
        private System.Windows.Forms.Button buttonNo6;
        private System.Windows.Forms.Button buttonNo7;
        private System.Windows.Forms.Button buttonNo8;
        private System.Windows.Forms.Button buttonNo9;
        private System.Windows.Forms.Button buttonNo0;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.TextBox codeBox;
        private InTheHand.Net.Bluetooth.BluetoothComponent bluetoothComponent1;
        private InTheHand.Windows.Forms.SelectBluetoothDeviceDialog selectBluetoothDeviceDialog1;
        private System.Windows.Forms.Button buttonBell;
    }
}

