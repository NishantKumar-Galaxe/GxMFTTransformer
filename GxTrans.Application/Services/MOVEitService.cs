using GxTrans.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using GxTrans.Domain.Interfaces;
using GxTrans.Domain.Models;

namespace GxTrans.Application.Services
{
    public class MOVEitService: IMOVEitService
    {
        private IMOVEitRepository _MOVEitRepository;
        public MOVEitService(IMOVEitRepository MOVEitRepository)
        {
            _MOVEitRepository = MOVEitRepository;
        }

        public MOVEitUserOutput ExtractCommunity(MOVEitUserInput userInput)
        {
            return null;
        }

        public MOVEitUserOutput ExtractPartner(MOVEitUserInput userInput)
        {
            return null;
        }

        public MOVEitUserOutput ExtractProtocolDetail(MOVEitUserInput userInput)
        {
            return null;
        }

        public MOVEitUserOutput ExtractRoutingDetail(MOVEitUserInput userInput)
        {
            return null;
        }
    }
}
