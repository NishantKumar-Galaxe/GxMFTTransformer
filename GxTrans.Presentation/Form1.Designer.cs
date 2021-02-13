
namespace GxTrans.Presentation
{
    partial class Form1
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
            this.btnMOVEit = new System.Windows.Forms.Button();
            this.btnJScape = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMOVEit
            // 
            this.btnMOVEit.Location = new System.Drawing.Point(134, 62);
            this.btnMOVEit.Name = "btnMOVEit";
            this.btnMOVEit.Size = new System.Drawing.Size(75, 23);
            this.btnMOVEit.TabIndex = 0;
            this.btnMOVEit.Text = "MOVEit";
            this.btnMOVEit.UseVisualStyleBackColor = true;
            this.btnMOVEit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnJScape
            // 
            this.btnJScape.Location = new System.Drawing.Point(261, 62);
            this.btnJScape.Name = "btnJScape";
            this.btnJScape.Size = new System.Drawing.Size(75, 23);
            this.btnJScape.TabIndex = 1;
            this.btnJScape.Text = "JScape";
            this.btnJScape.UseVisualStyleBackColor = true;
            this.btnJScape.Click += new System.EventHandler(this.btnJScape_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJScape);
            this.Controls.Add(this.btnMOVEit);
            this.Name = "Form1";
            this.Text = "JScape";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMOVEit;
        private System.Windows.Forms.Button btnJScape;
    }
}

