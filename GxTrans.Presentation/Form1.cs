using GxTrans.Application.Interfaces;
using GxTrans.Presentation.SourceMFT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GxTrans.Presentation
{
    public partial class Form1 : Form
    {
        private IJScapeService _iJScapeService;
        private IMOVEitService _iMOVEitService;
        public Form1(IJScapeService JScapeService, IMOVEitService MOVEitService)
        {
            InitializeComponent();
            _iJScapeService = JScapeService;
            _iMOVEitService = MOVEitService;
        }

        private void btnUploadConfiguration_click(object sender, EventArgs e)
        {
            openSourceConfig.InitialDirectory = @"E:\Nishant_Backup_Mar2020\Nishant\Project\Fiserv\Migration2SFG\Documents\Document From Client\Moveit config Exports";
            openSourceConfig.Title = "Select Source Config File";
            openSourceConfig.FileName = "";
            openSourceConfig.Filter = "XML File|*.xml|JSON Files|.JSON";

            if (openSourceConfig.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Operation Cancelled");
            }
            else
            {
                lblSelectedFile.Text = openSourceConfig.FileName;
            }
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            switch (lstSourceMFT.Text)
            {
                case "MOVEit":
                    MOVEitTransformer MOVEitTrans = new MOVEitTransformer(_iMOVEitService);
                    MOVEitTrans.Parse();
                    MessageBox.Show("MOVEit File Sucessfully Parsed..");
                    break;

                case "JScape":
                    JScapeTransformer jTrans = new JScapeTransformer(_iJScapeService);
                    jTrans.Parse();
                    MessageBox.Show("JScape File Sucessfully Parsed..");
                    break;
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
