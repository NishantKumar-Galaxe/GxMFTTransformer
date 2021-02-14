
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
            this.brnUploadConfiguration = new System.Windows.Forms.Button();
            this.btnJScape = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lstSourceMFT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openSourceConfig = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSelectedFile = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // brnUploadConfiguration
            // 
            this.brnUploadConfiguration.Location = new System.Drawing.Point(15, 271);
            this.brnUploadConfiguration.Name = "brnUploadConfiguration";
            this.brnUploadConfiguration.Size = new System.Drawing.Size(157, 23);
            this.brnUploadConfiguration.TabIndex = 0;
            this.brnUploadConfiguration.Text = "Upload Configuration";
            this.brnUploadConfiguration.UseVisualStyleBackColor = true;
            this.brnUploadConfiguration.Click += new System.EventHandler(this.btnUploadConfiguration_click);
            // 
            // btnJScape
            // 
            this.btnJScape.Location = new System.Drawing.Point(192, 271);
            this.btnJScape.Name = "btnJScape";
            this.btnJScape.Size = new System.Drawing.Size(75, 23);
            this.btnJScape.TabIndex = 1;
            this.btnJScape.Text = "Transform";
            this.btnJScape.UseVisualStyleBackColor = true;
            this.btnJScape.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.88664F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.11336F));
            this.tableLayoutPanel1.Controls.Add(this.lstSourceMFT, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 116);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.97403F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.02597F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(741, 128);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // lstSourceMFT
            // 
            this.lstSourceMFT.FormattingEnabled = true;
            this.lstSourceMFT.Items.AddRange(new object[] {
            "MOVEit",
            "JScape",
            "XFB"});
            this.lstSourceMFT.Location = new System.Drawing.Point(180, 3);
            this.lstSourceMFT.Name = "lstSourceMFT";
            this.lstSourceMFT.Size = new System.Drawing.Size(121, 23);
            this.lstSourceMFT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Source MFT";
            // 
            // openSourceConfig
            // 
            this.openSourceConfig.FileName = "openConfig";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblSelectedFile
            // 
            this.lblSelectedFile.Location = new System.Drawing.Point(15, 323);
            this.lblSelectedFile.Name = "lblSelectedFile";
            this.lblSelectedFile.Size = new System.Drawing.Size(477, 23);
            this.lblSelectedFile.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSelectedFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnJScape);
            this.Controls.Add(this.brnUploadConfiguration);
            this.Name = "Form1";
            this.Text = "JScape";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button brnUploadConfiguration;
        private System.Windows.Forms.Button btnJScape;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox lstSourceMFT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openSourceConfig;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSelectedFile;
    }
}

