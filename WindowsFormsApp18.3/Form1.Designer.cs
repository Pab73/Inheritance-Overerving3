
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
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoogte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(37, 80);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 22);
            this.txtX.TabIndex = 3;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(37, 122);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 22);
            this.txtY.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Coordinaten Punt:";
            // 
            // txtHoogte
            // 
            this.txtHoogte.Location = new System.Drawing.Point(40, 318);
            this.txtHoogte.Name = "txtHoogte";
            this.txtHoogte.Size = new System.Drawing.Size(100, 22);
            this.txtHoogte.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hoogte:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoogte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.btnCilinder);
            this.Controls.Add(this.btnCikel);
            this.Controls.Add(this.btnPunt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPunt;
        private System.Windows.Forms.Button btnCikel;
        private System.Windows.Forms.Button btnCilinder;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoogte;
        private System.Windows.Forms.Label label2;
    }
}

