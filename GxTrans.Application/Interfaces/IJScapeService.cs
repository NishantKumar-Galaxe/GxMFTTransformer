using System;
using System.Collections.Generic;
using System.Text;

namespace GxTrans.Application.Interfaces
{
    interface IJScapeService
    {
        public void ExtractCommunity();
        public void ExtractPartner();
        public void ExtractRoutingDetail();
        public void ExtractProtocolDetail();

    }
}
