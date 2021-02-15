using GxTrans.Domain.Interfaces;
using GxTrans.Domain.Models;
using GxTrans.Infra.Data.Context;
using GxTrans.Infra.Data.CustomImplementation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GxTrans.Infra.Data.Repository
{
    public class JScapeRepository : IJScapeRepository
    {
        private TransDBContext _dbContext;


        public JScapeRepository(TransDBContext ctx)
        {
            _dbContext = ctx;
        }

        public JScapeUserOutput ParseCommunityDetail(JScapeUserInput userinput)
        {
            //ToDo: Remove it, just for POC
            var tasks = _dbContext.GetTaskDetails;
            return null;
        }

        public JScapeUserOutput ParseProducerDetail(JScapeUserInput userinput)
        {
            DataTable dtUsers = JScapeCustomMethod.ReadXML(userinput.folderPath);
            return new JScapeUserOutput { 
                UserDetail= dtUsers
            };
        }

        public JScapeUserOutput ParseProtocolDetail(JScapeUserInput userinput)
        {
            return null;
        }

        public JScapeUserOutput ParseRoutingTemplateDetail(JScapeUserInput userinput)
        {
            return null;
        }


    }
}
