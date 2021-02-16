using GxTrans.Application.Interfaces;
using GxTrans.Domain.Interfaces;
using GxTrans.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GxTrans.Application.Services
{
    public class JScapeService : IJScapeService
    {
        private IJScapeRepository _JScapeRepository;
        public JScapeService(IJScapeRepository JScapeRepository)
        {
            _JScapeRepository = JScapeRepository;
        }
        /// <summary>
        /// 
        /// </summary>
        public JScapeUserResponse ExtractCommunity(JScapeUserRequest userInput)
        {
            _JScapeRepository.ParseCommunityDetail(userInput);
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        public JScapeUserResponse ExtractPartner(JScapeUserRequest userInput)
        {
            return _JScapeRepository.ParseProducerDetail(userInput);
        }

        /// <summary>
        /// 
        /// </summary>
        public JScapeUserResponse ExtractProtocolDetail(JScapeUserRequest userInput)
        {
            _JScapeRepository.ParseProtocolDetail(userInput);
            return null;
        }

        /// <summary>
        /// 
        /// </summary>

        public JScapeUserResponse ExtractRoutingDetail(JScapeUserRequest userInput)
        {
            _JScapeRepository.ParseRoutingTemplateDetail(userInput);
            return null;
        }
    }
}
