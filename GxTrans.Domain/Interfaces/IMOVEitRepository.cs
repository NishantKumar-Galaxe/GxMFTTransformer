using System;
using System.Collections.Generic;
using System.Text;

namespace GxTrans.Domain.Interfaces
{
    /// <summary>
    /// Specify custom method need to be implemented for current MFT.
    /// </summary>
    public interface IMOVEitRepository : ICommonRepository
    {
        void ParseScriptDetail();
        void ParseMacroDetail();
    }
}
