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
        public Form1(IJScapeService JScapeService)
        {
            InitializeComponent();
            _iJScapeService = JScapeService;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnJScape_Click(object sender, EventArgs e)
        {
            JScapeTransformer jTrans = new JScapeTransformer(_iJScapeService);
            jTrans.Parse();
        }
    }
}
