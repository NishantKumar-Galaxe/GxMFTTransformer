using GxTrans.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using GxTrans.Domain.Interfaces;

namespace GxTrans.Application.Services
{
    public class MOVEitService: IMOVEitService
    {
        private IMOVEitRepository _MOVEitRepository;
        public MOVEitService(IMOVEitRepository MOVEitRepository)
        {
            _MOVEitRepository = MOVEitRepository;
        }
    }
}
