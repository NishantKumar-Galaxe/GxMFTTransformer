using System;
using System.Collections.Generic;
using System.Text;

namespace GxTrans.Domain.Interfaces
{
    /// <summary>
    /// Common method used for all Source MFT.
    /// </summary>
    public interface ICommonRepository
    {
        void ParseCommunityDetail();
        void ParseProducerDetail();
        void ParseProtocolDetail();
        void ParseRoutingTemplateDetail();
    }
}
