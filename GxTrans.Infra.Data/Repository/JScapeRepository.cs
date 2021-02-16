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

        public JScapeUserResponse ParseCommunityDetail(JScapeUserRequest userinput)
        {
            //ToDo: Remove it, just for POC
            var tasks = _dbContext.GetTaskDetails;
            return null;
        }

        public JScapeUserResponse ParseProducerDetail(JScapeUserRequest userinput)
        {
            DataTable dtUsers = JScapeCustomMethod.ReadXML(userinput.folderPath);
            return new JScapeUserResponse { 
                UserDetail= dtUsers
            };
        }

        public JScapeUserResponse ParseProtocolDetail(JScapeUserRequest userinput)
        {
            return null;
        }

        public JScapeUserResponse ParseRoutingTemplateDetail(JScapeUserRequest userinput)
        {
            return null;
        }


    }
}
