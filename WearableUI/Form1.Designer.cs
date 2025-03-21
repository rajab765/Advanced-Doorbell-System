namespace WearableUI
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
            this.shakeButton = new System.Windows.Forms.Button();
            this.btnVibrate = new System.Windows.Forms.Button();
            this.labelVibrate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shakeButton
            // 
            this.shakeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.shakeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shakeButton.Location = new System.Drawing.Point(12, 22);
            this.shakeButton.Name = "shakeButton";
            this.shakeButton.Size = new System.Drawing.Size(288, 173);
            this.shakeButton.TabIndex = 0;
            this.shakeButton.Text = "Open Door";
            this.shakeButton.UseVisualStyleBackColor = true;
            this.shakeButton.Click += new System.EventHandler(this.shakeButton_Click);
            // 
            // btnVibrate
            // 
            this.btnVibrate.BackColor = System.Drawing.Color.Red;
            this.btnVibrate.Location = new System.Drawing.Point(50, 210);
            this.btnVibrate.Name = "btnVibrate";
            this.btnVibrate.Size = new System.Drawing.Size(206, 65);
            this.btnVibrate.TabIndex = 1;
            this.btnVibrate.UseVisualStyleBackColor = false;
            // 
            // labelVibrate
            // 
            this.labelVibrate.AutoSize = true;
            this.labelVibrate.Location = new System.Drawing.Point(131, 278);
            this.labelVibrate.Name = "labelVibrate";
            this.labelVibrate.Size = new System.Drawing.Size(50, 16);
            this.labelVibrate.TabIndex = 3;
            this.labelVibrate.Text = "Vibrate";
            this.labelVibrate.Click += new System.EventHandler(this.labelVibrate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 316);
            this.Controls.Add(this.labelVibrate);
            this.Controls.Add(this.btnVibrate);
            this.Controls.Add(this.shakeButton);
            this.Name = "Form1";
            this.Text = "Wearable UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button shakeButton;
        private System.Windows.Forms.Button btnVibrate;
        private System.Windows.Forms.Label labelVibrate;
    }
}

