using GxTrans.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GxTrans.Domain.Interfaces
{
    /// <summary>
    /// Specify custom method need to be implemented for current MFT.
    /// </summary>

    public interface IJScapeRepository
    {
        JScapeUserOutput ParseCommunityDetail(JScapeUserInput userInput);
        JScapeUserOutput ParseProducerDetail(JScapeUserInput userInput);
        JScapeUserOutput ParseProtocolDetail(JScapeUserInput userInput);
        JScapeUserOutput ParseRoutingTemplateDetail(JScapeUserInput userInput);
    }
}
