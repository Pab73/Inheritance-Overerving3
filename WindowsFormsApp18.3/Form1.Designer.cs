
namespace WindowsFormsApp18._3
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
            this.btnPunt = new System.Windows.Forms.Button();
            this.btnCikel = new System.Windows.Forms.Button();
            this.btnCilinder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPunt
            // 
            this.btnPunt.Location = new System.Drawing.Point(276, 59);
            this.btnPunt.Name = "btnPunt";
            this.btnPunt.Size = new System.Drawing.Size(189, 85);
            this.btnPunt.TabIndex = 0;
            this.btnPunt.Text = "Punt";
            this.btnPunt.UseVisualStyleBackColor = true;
            this.btnPunt.Click += new System.EventHandler(this.btnPunt_Click);
            // 
            // btnCikel
            // 
            this.btnCikel.Location = new System.Drawing.Point(276, 172);
            this.btnCikel.Name = "btnCikel";
            this.btnCikel.Size = new System.Drawing.Size(189, 85);
            this.btnCikel.TabIndex = 1;
            this.btnCikel.Text = "Cirkel";
            this.btnCikel.UseVisualStyleBackColor = true;
            this.btnCikel.Click += new System.EventHandler(this.btnCikel_Click);
            // 
            // btnCilinder
            // 
            this.btnCilinder.Location = new System.Drawing.Point(276, 287);
            this.btnCilinder.Name = "btnCilinder";
            this.btnCilinder.Size = new System.Drawing.Size(189, 85);
            this.btnCilinder.TabIndex = 2;
            this.btnCilinder.Text = "Cilinder";
            this.btnCilinder.UseVisualStyleBackColor = true;
            this.btnCilinder.Click += new System.EventHandler(this.btnCilinder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCilinder);
            this.Controls.Add(this.btnCikel);
            this.Controls.Add(this.btnPunt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPunt;
        private System.Windows.Forms.Button btnCikel;
        private System.Windows.Forms.Button btnCilinder;
    }
}

