using GxTrans.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GxTrans.Application.Interfaces
{
    public interface IMOVEitService
    {
        public MOVEitUserResponse ExtractCommunity(MOVEitUserRequest userInput);
        public MOVEitUserResponse ExtractPartner(MOVEitUserRequest userInput);
        public MOVEitUserResponse ExtractRoutingDetail(MOVEitUserRequest userInput);
        public MOVEitUserResponse ExtractProtocolDetail(MOVEitUserRequest userInput);
    }
}
