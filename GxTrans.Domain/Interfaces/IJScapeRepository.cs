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
        JScapeUserResponse ParseCommunityDetail(JScapeUserRequest userInput);
        JScapeUserResponse ParseProducerDetail(JScapeUserRequest userInput);
        JScapeUserResponse ParseProtocolDetail(JScapeUserRequest userInput);
        JScapeUserResponse ParseRoutingTemplateDetail(JScapeUserRequest userInput);
    }
}
