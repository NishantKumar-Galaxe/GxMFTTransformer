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
        object ParseCommunityDetail(object userInput);
        object ParseProducerDetail(object userInput);
        object ParseProtocolDetail(object userInput);
        object ParseRoutingTemplateDetail(object userInput);
    }
}
