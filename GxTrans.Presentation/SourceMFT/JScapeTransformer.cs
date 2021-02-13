using System;
using System.Collections.Generic;
using System.Text;
using GxTrans.Application.Interfaces;

namespace GxTrans.Presentation.SourceMFT
{
    public class JScapeTransformer
    {
        private IJScapeService _JScapeService;
        public JScapeTransformer(IJScapeService JScapeService)
        {
            _JScapeService = JScapeService;
        }

        public void Parse()
        {
            //Parse all details
            _JScapeService.ExtractCommunity();
        }
    }
}
