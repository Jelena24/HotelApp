namespace HotelApp
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxBrojSobe = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxBrojSprata = new System.Windows.Forms.TextBox();
            this.textBoxBrojOsoba = new System.Windows.Forms.TextBox();
            this.textBoxKvadratura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 154);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get All Rooms";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Location = new System.Drawing.Point(336, 92);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(877, 340);
            this.listBox1.TabIndex = 1;
            // 
            // textBoxBrojSobe
            // 
            this.textBoxBrojSobe.Location = new System.Drawing.Point(336, 506);
            this.textBoxBrojSobe.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBrojSobe.Name = "textBoxBrojSobe";
            this.textBoxBrojSobe.PlaceholderText = "Room Number";
            this.textBoxBrojSobe.Size = new System.Drawing.Size(183, 34);
            this.textBoxBrojSobe.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 248);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 41);
            this.button2.TabIndex = 0;
            this.button2.Text = "Update Room";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxBrojSprata
            // 
            this.textBoxBrojSprata.Location = new System.Drawing.Point(558, 506);
            this.textBoxBrojSprata.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBrojSprata.Name = "textBoxBrojSprata";
            this.textBoxBrojSprata.PlaceholderText = "Floor Number";
            this.textBoxBrojSprata.Size = new System.Drawing.Size(175, 34);
            this.textBoxBrojSprata.TabIndex = 2;
            // 
            // textBoxBrojOsoba
            // 
            this.textBoxBrojOsoba.Location = new System.Drawing.Point(787, 506);
            this.textBoxBrojOsoba.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBrojOsoba.Name = "textBoxBrojOsoba";
            this.textBoxBrojOsoba.PlaceholderText = "Number Of Persons";
            this.textBoxBrojOsoba.Size = new System.Drawing.Size(187, 34);
            this.textBoxBrojOsoba.TabIndex = 2;
            // 
            // textBoxKvadratura
            // 
            this.textBoxKvadratura.Location = new System.Drawing.Point(1026, 506);
            this.textBoxKvadratura.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKvadratura.Name = "textBoxKvadratura";
            this.textBoxKvadratura.PlaceholderText = "Quadrature";
            this.textBoxKvadratura.Size = new System.Drawing.Size(187, 34);
            this.textBoxKvadratura.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1279, 678);
            this.Controls.Add(this.textBoxKvadratura);
            this.Controls.Add(this.textBoxBrojOsoba);
            this.Controls.Add(this.textBoxBrojSprata);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxBrojSobe);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Information About Rooms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxBrojSobe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxBrojSprata;
        private System.Windows.Forms.TextBox textBoxBrojOsoba;
        private System.Windows.Forms.TextBox textBoxKvadratura;
    }
}