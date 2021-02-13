using GxTrans.Domain.Interfaces;
using GxTrans.Infra.Data.Context;
using System;
using System.Collections.Generic;
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
        public void ParseCommunityDetail()
        {
            //ToDo: Remove it, just for POC
            var tasks= _dbContext.GetTaskDetails;
        }

        public void ParseProducerDetail()
        {
            throw new NotImplementedException();
        }

        public void ParseProtocolDetail()
        {
            throw new NotImplementedException();
        }

        public void ParseRoutingTemplateDetail()
        {
            throw new NotImplementedException();
        }
    }
}
