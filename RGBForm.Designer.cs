namespace ArduinoOne
{
    partial class RGBForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.sliderRed = new System.Windows.Forms.TrackBar();
            this.lbGreen = new System.Windows.Forms.Label();
            this.sliderGreen = new System.Windows.Forms.TrackBar();
            this.lbBlue = new System.Windows.Forms.Label();
            this.sliderBlue = new System.Windows.Forms.TrackBar();
            this.lbRed = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sliderRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(71, 277);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 39);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // sliderRed
            // 
            this.sliderRed.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sliderRed.Location = new System.Drawing.Point(34, 35);
            this.sliderRed.Name = "sliderRed";
            this.sliderRed.Size = new System.Drawing.Size(516, 45);
            this.sliderRed.TabIndex = 1;
            this.sliderRed.Scroll += new System.EventHandler(this.sliderRed_Scroll);
            this.sliderRed.ValueChanged += new System.EventHandler(this.sliderRed_ValueChanged);
            // 
            // lbGreen
            // 
            this.lbGreen.AutoSize = true;
            this.lbGreen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbGreen.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbGreen.Location = new System.Drawing.Point(569, 116);
            this.lbGreen.Name = "lbGreen";
            this.lbGreen.Size = new System.Drawing.Size(19, 21);
            this.lbGreen.TabIndex = 2;
            this.lbGreen.Text = "0";
            // 
            // sliderGreen
            // 
            this.sliderGreen.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sliderGreen.Location = new System.Drawing.Point(34, 106);
            this.sliderGreen.Name = "sliderGreen";
            this.sliderGreen.Size = new System.Drawing.Size(516, 45);
            this.sliderGreen.TabIndex = 1;
            this.sliderGreen.Scroll += new System.EventHandler(this.sliderGreen_Scroll);
            this.sliderGreen.ValueChanged += new System.EventHandler(this.sliderGreen_ValueChanged);
            // 
            // lbBlue
            // 
            this.lbBlue.AutoSize = true;
            this.lbBlue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBlue.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbBlue.Location = new System.Drawing.Point(569, 185);
            this.lbBlue.Name = "lbBlue";
            this.lbBlue.Size = new System.Drawing.Size(19, 21);
            this.lbBlue.TabIndex = 2;
            this.lbBlue.Text = "0";
            // 
            // sliderBlue
            // 
            this.sliderBlue.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sliderBlue.Location = new System.Drawing.Point(34, 174);
            this.sliderBlue.Name = "sliderBlue";
            this.sliderBlue.Size = new System.Drawing.Size(516, 45);
            this.sliderBlue.TabIndex = 1;
            this.sliderBlue.Scroll += new System.EventHandler(this.sliderBlue_Scroll);
            this.sliderBlue.ValueChanged += new System.EventHandler(this.sliderBlue_ValueChanged);
            // 
            // lbRed
            // 
            this.lbRed.AutoSize = true;
            this.lbRed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRed.ForeColor = System.Drawing.Color.Red;
            this.lbRed.Location = new System.Drawing.Point(569, 46);
            this.lbRed.Name = "lbRed";
            this.lbRed.Size = new System.Drawing.Size(19, 21);
            this.lbRed.TabIndex = 2;
            this.lbRed.Text = "0";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(380, 277);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(95, 39);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Change";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // RGBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lbRed);
            this.Controls.Add(this.sliderBlue);
            this.Controls.Add(this.lbBlue);
            this.Controls.Add(this.sliderGreen);
            this.Controls.Add(this.lbGreen);
            this.Controls.Add(this.sliderRed);
            this.Controls.Add(this.btnBack);
            this.Name = "RGBForm";
            this.Text = "RGBForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RGBForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.sliderRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TrackBar sliderRed;
        private System.Windows.Forms.Label lbGreen;
        private System.Windows.Forms.TrackBar sliderGreen;
        private System.Windows.Forms.Label lbBlue;
        private System.Windows.Forms.TrackBar sliderBlue;
        private System.Windows.Forms.Label lbRed;
        private System.Windows.Forms.Button btnSend;
    }
}