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

        public MOVEitUserResponse ExtractCommunity(MOVEitUserRequest userInput)
        {
            return null;
        }

        public MOVEitUserResponse ExtractPartner(MOVEitUserRequest userInput)
        {
            return null;
        }

        public MOVEitUserResponse ExtractProtocolDetail(MOVEitUserRequest userInput)
        {
            return null;
        }

        public MOVEitUserResponse ExtractRoutingDetail(MOVEitUserRequest userInput)
        {
            return null;
        }
    }
}
