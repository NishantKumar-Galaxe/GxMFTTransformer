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

        public MOVEitUserOutput ParseCommunityDetail(MOVEitUserInput userInput)
        {
            return null;
        }

        public MOVEitUserOutput ParseMacroDetail(MOVEitUserInput userInput)
        {
            return null;
        }

        public MOVEitUserOutput ParseProducerDetail(MOVEitUserInput userInput)
        {
            return null;
        }

        public MOVEitUserOutput ParseProtocolDetail(MOVEitUserInput userInput)
        {
            return null;
        }

        public MOVEitUserOutput ParseRoutingTemplateDetail(MOVEitUserInput userInput)
        {
            return null;
        }

        public MOVEitUserOutput ParseScriptDetail(MOVEitUserInput userInput)
        {
            return null;
        }
    }
}
