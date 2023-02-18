namespace Split
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Input = new System.Windows.Forms.TextBox();
            this.Procesar = new System.Windows.Forms.Button();
            this.Adios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(10, 27);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(300, 150);
            this.Input.TabIndex = 0;
            this.Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Input.TextChanged += new System.EventHandler(this.Procesar_Click);
            this.Input.Enter += new System.EventHandler(this.Procesar_Click);
            // 
            // Procesar
            // 
            this.Procesar.Location = new System.Drawing.Point(10, 183);
            this.Procesar.Name = "Procesar";
            this.Procesar.Size = new System.Drawing.Size(300, 23);
            this.Procesar.TabIndex = 1;
            this.Procesar.Text = "Procesar";
            this.Procesar.UseVisualStyleBackColor = true;
            this.Procesar.Click += new System.EventHandler(this.Procesar_Click);
            // 
            // Adios
            // 
            this.Adios.Location = new System.Drawing.Point(10, 212);
            this.Adios.Name = "Adios";
            this.Adios.Size = new System.Drawing.Size(300, 23);
            this.Adios.TabIndex = 2;
            this.Adios.Text = "Adios";
            this.Adios.UseVisualStyleBackColor = true;
            this.Adios.Click += new System.EventHandler(this.Adios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pega el texto aqui...";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 249);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Adios);
            this.Controls.Add(this.Procesar);
            this.Controls.Add(this.Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Split For Claris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Input;
        private Button Procesar;
        private Button Adios;
        private Label label1;
    }
}