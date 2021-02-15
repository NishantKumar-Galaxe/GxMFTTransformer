using GxTrans.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GxTrans.Application.Interfaces
{
    public interface IMOVEitService
    {
        public MOVEitUserOutput ExtractCommunity(MOVEitUserInput userInput);
        public MOVEitUserOutput ExtractPartner(MOVEitUserInput userInput);
        public MOVEitUserOutput ExtractRoutingDetail(MOVEitUserInput userInput);
        public MOVEitUserOutput ExtractProtocolDetail(MOVEitUserInput userInput);
    }
}
