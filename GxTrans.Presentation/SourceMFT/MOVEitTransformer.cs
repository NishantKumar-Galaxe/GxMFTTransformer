using System;
using System.Collections.Generic;
using System.Text;
using GxTrans.Application.Interfaces;

namespace GxTrans.Presentation.SourceMFT
{
    public class MOVEitTransformer
    {
        private IMOVEitService _MOVEitService;
        public MOVEitTransformer(IMOVEitService MOVEitService)
        {
            _MOVEitService = MOVEitService;
        }
        public void Parse()
        {
            //Parse all details
            _MOVEitService.ExtractCommunity();
        }
    }
}
