using System;
using System.Collections.Generic;
using System.Text;
using GxTrans.Domain.Interfaces;
using GxTrans.Domain.Models;
using GxTrans.Infra.Data.Context;

namespace GxTrans.Infra.Data.Repository
{
    public class MOVEitRepository : IMOVEitRepository
    {
        private TransDBContext _dbContext;
        public MOVEitRepository(TransDBContext ctx)
        {
            _dbContext = ctx;
        }

        public MOVEitUserResponse ParseCommunityDetail(MOVEitUserRequest userInput)
        {
            return null;
        }

        public MOVEitUserResponse ParseMacroDetail(MOVEitUserRequest userInput)
        {
            return null;
        }

        public MOVEitUserResponse ParseProducerDetail(MOVEitUserRequest userInput)
        {
            return null;
        }

        public MOVEitUserResponse ParseProtocolDetail(MOVEitUserRequest userInput)
        {
            return null;
        }

        public MOVEitUserResponse ParseRoutingTemplateDetail(MOVEitUserRequest userInput)
        {
            return null;
        }

        public MOVEitUserResponse ParseScriptDetail(MOVEitUserRequest userInput)
        {
            return null;
        }
    }
}
