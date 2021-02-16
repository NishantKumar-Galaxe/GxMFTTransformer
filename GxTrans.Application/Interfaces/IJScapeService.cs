using GxTrans.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GxTrans.Application.Interfaces
{
    public interface IJScapeService
    {
        public JScapeUserResponse ExtractCommunity(JScapeUserRequest userInput);
        public JScapeUserResponse ExtractPartner(JScapeUserRequest userInput);
        public JScapeUserResponse ExtractRoutingDetail(JScapeUserRequest userInput);
        public JScapeUserResponse ExtractProtocolDetail(JScapeUserRequest userInput);

    }
}
