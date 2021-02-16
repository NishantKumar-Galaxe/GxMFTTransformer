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
            JScapeUserRequest userInput = new JScapeUserRequest
            {
                folderPath = @"E:\Nishant_Backup_Mar2020\Nishant\Project\Fiserv\JscapeToSFG\POC\Users\Fiserv_CUSolutions"
            };

            JScapeUserResponse output = _JScapeService.ExtractPartner(userInput);
            
        }
    }
}
