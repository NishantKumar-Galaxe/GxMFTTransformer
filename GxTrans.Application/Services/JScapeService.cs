using GxTrans.Application.Interfaces;
using GxTrans.Domain.Interfaces;
using System;
using System.Collections.Generic;
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
        public void ExtractCommunity()
        {
            _JScapeRepository.ParseCommunityDetail();
        }

        /// <summary>
        /// 
        /// </summary>
        public void ExtractPartner()
        {
            _JScapeRepository.ParseProducerDetail();
        }

        /// <summary>
        /// 
        /// </summary>
        public void ExtractProtocolDetail()
        {
            _JScapeRepository.ParseProtocolDetail();
        }

        /// <summary>
        /// 
        /// </summary>

        public void ExtractRoutingDetail()
        {
            _JScapeRepository.ParseRoutingTemplateDetail();
        }
    }
}
