using GxTrans.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GxTrans.Domain.Interfaces
{
    /// <summary>
    /// Specify custom method need to be implemented for current MFT.
    /// </summary>
    public interface IMOVEitRepository
    {
        MOVEitUserResponse ParseCommunityDetail(MOVEitUserRequest userInput);
        MOVEitUserResponse ParseProducerDetail(MOVEitUserRequest userInput);
        MOVEitUserResponse ParseProtocolDetail(MOVEitUserRequest userInput);
        MOVEitUserResponse ParseRoutingTemplateDetail(MOVEitUserRequest userInput);

        MOVEitUserResponse ParseScriptDetail(MOVEitUserRequest userInput);
        MOVEitUserResponse ParseMacroDetail(MOVEitUserRequest userInput);
    }
}
