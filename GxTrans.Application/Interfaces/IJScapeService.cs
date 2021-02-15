using GxTrans.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GxTrans.Application.Interfaces
{
    public interface IJScapeService
    {
        public JScapeUserOutput ExtractCommunity(JScapeUserInput userInput);
        public JScapeUserOutput ExtractPartner(JScapeUserInput userInput);
        public JScapeUserOutput ExtractRoutingDetail(JScapeUserInput userInput);
        public JScapeUserOutput ExtractProtocolDetail(JScapeUserInput userInput);

    }
}
