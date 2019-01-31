namespace Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Usd = new System.Windows.Forms.Label();
            this.Naira = new System.Windows.Forms.Label();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Usd
            // 
            this.Usd.AllowDrop = true;
            this.Usd.AutoSize = true;
            this.Usd.BackColor = System.Drawing.Color.Transparent;
            this.Usd.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Usd.Location = new System.Drawing.Point(297, 122);
            this.Usd.Name = "Usd";
            this.Usd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Usd.Size = new System.Drawing.Size(224, 25);
            this.Usd.TabIndex = 0;
            this.Usd.Text = "United State Dollar";
            this.Usd.Click += new System.EventHandler(this.label1_Click);
            // 
            // Naira
            // 
            this.Naira.AutoSize = true;
            this.Naira.BackColor = System.Drawing.Color.Transparent;
            this.Naira.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naira.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Naira.Location = new System.Drawing.Point(293, 202);
            this.Naira.Name = "Naira";
            this.Naira.Size = new System.Drawing.Size(161, 25);
            this.Naira.TabIndex = 1;
            this.Naira.Text = "Nigeria Naira";
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(117, 122);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(149, 26);
            this.textBox_number.TabIndex = 2;
            this.textBox_number.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(110, 196);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(156, 26);
            this.textBox_result.TabIndex = 3;
            this.textBox_result.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Convert
            // 
            this.Convert.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Convert.Font = new System.Drawing.Font("Kristen ITC", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert.Location = new System.Drawing.Point(191, 280);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(106, 38);
            this.Convert.TabIndex = 4;
            this.Convert.Text = "Convert";
            this.Convert.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Convert.UseVisualStyleBackColor = false;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(458, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(576, 383);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.Naira);
            this.Controls.Add(this.Usd);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usd;
        private System.Windows.Forms.Label Naira;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Button button1;
    }
}

