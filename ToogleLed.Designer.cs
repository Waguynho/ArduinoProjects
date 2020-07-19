namespace ArduinoOne
{
    partial class ToogleLed
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enableRdb = new System.Windows.Forms.RadioButton();
            this.disableRdb = new System.Windows.Forms.RadioButton();
            this.cboxPorts = new System.Windows.Forms.ComboBox();
            this.lb_ports = new System.Windows.Forms.Label();
            this.txtBoxLog = new System.Windows.Forms.RichTextBox();
            this.btnRGB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enableRdb
            // 
            this.enableRdb.AutoSize = true;
            this.enableRdb.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.enableRdb.ForeColor = System.Drawing.Color.Green;
            this.enableRdb.Location = new System.Drawing.Point(46, 56);
            this.enableRdb.Name = "enableRdb";
            this.enableRdb.Size = new System.Drawing.Size(156, 41);
            this.enableRdb.TabIndex = 2;
            this.enableRdb.Text = "Ligar LED";
            this.enableRdb.UseVisualStyleBackColor = true;
            this.enableRdb.CheckedChanged += new System.EventHandler(this.enableRdb_CheckedChanged);
            // 
            // disableRdb
            // 
            this.disableRdb.AutoSize = true;
            this.disableRdb.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.disableRdb.Location = new System.Drawing.Point(279, 56);
            this.disableRdb.Name = "disableRdb";
            this.disableRdb.Size = new System.Drawing.Size(196, 41);
            this.disableRdb.TabIndex = 2;
            this.disableRdb.Text = "Desligar LED";
            this.disableRdb.UseVisualStyleBackColor = true;
            this.disableRdb.CheckedChanged += new System.EventHandler(this.disableRdb_CheckedChanged);
            // 
            // cboxPorts
            // 
            this.cboxPorts.FormattingEnabled = true;
            this.cboxPorts.Location = new System.Drawing.Point(253, 16);
            this.cboxPorts.Name = "cboxPorts";
            this.cboxPorts.Size = new System.Drawing.Size(140, 23);
            this.cboxPorts.TabIndex = 3;
            this.cboxPorts.SelectedValueChanged += new System.EventHandler(this.cboxPorts_SelectedValueChanged);
            // 
            // lb_ports
            // 
            this.lb_ports.AutoSize = true;
            this.lb_ports.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lb_ports.ForeColor = System.Drawing.Color.Black;
            this.lb_ports.Location = new System.Drawing.Point(99, 11);
            this.lb_ports.Name = "lb_ports";
            this.lb_ports.Size = new System.Drawing.Size(147, 28);
            this.lb_ports.TabIndex = 4;
            this.lb_ports.Text = "Portas Seriais:";
            // 
            // txtBoxLog
            // 
            this.txtBoxLog.Location = new System.Drawing.Point(56, 140);
            this.txtBoxLog.Name = "txtBoxLog";
            this.txtBoxLog.Size = new System.Drawing.Size(409, 210);
            this.txtBoxLog.TabIndex = 5;
            this.txtBoxLog.Text = "";
            // 
            // btnRGB
            // 
            this.btnRGB.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnRGB.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnRGB.Location = new System.Drawing.Point(297, 357);
            this.btnRGB.Name = "btnRGB";
            this.btnRGB.Size = new System.Drawing.Size(137, 35);
            this.btnRGB.TabIndex = 6;
            this.btnRGB.Text = "Go To RGB";
            this.btnRGB.UseVisualStyleBackColor = true;
            this.btnRGB.Click += new System.EventHandler(this.btnRGB_Click);
            // 
            // ToogleLed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.btnRGB);
            this.Controls.Add(this.txtBoxLog);
            this.Controls.Add(this.lb_ports);
            this.Controls.Add(this.cboxPorts);
            this.Controls.Add(this.disableRdb);
            this.Controls.Add(this.enableRdb);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "ToogleLed";
            this.Text = "ToogleLed";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToogleLed_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton enableRdb;
        private System.Windows.Forms.RadioButton disableRdb;
        private System.Windows.Forms.ComboBox cboxPorts;
        private System.Windows.Forms.Label lb_ports;
        private  System.Windows.Forms.RichTextBox txtBoxLog;
        private System.Windows.Forms.Button btnRGB;
    }
}

