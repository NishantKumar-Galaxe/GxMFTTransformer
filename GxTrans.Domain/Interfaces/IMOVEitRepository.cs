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
        MOVEitUserOutput ParseCommunityDetail(MOVEitUserInput userInput);
        MOVEitUserOutput ParseProducerDetail(MOVEitUserInput userInput);
        MOVEitUserOutput ParseProtocolDetail(MOVEitUserInput userInput);
        MOVEitUserOutput ParseRoutingTemplateDetail(MOVEitUserInput userInput);

        MOVEitUserOutput ParseScriptDetail(MOVEitUserInput userInput);
        MOVEitUserOutput ParseMacroDetail(MOVEitUserInput userInput);
    }
}
