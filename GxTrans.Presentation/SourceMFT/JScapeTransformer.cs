using System;
using System.Collections.Generic;
using System.Text;
using GxTrans.Application.Interfaces;
using GxTrans.Domain.Models;

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
            JScapeUserInput userInput = new JScapeUserInput
            {
                folderPath = @"E:\Nishant_Backup_Mar2020\Nishant\Project\Fiserv\JscapeToSFG\POC\Users\Fiserv_CUSolutions"
            };

            JScapeUserOutput output = _JScapeService.ExtractPartner(userInput);
            
        }
    }
}
