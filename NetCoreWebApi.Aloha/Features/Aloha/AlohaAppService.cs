using NetCoreWebApi.Aloha.BCUnitOfWork;
using NetCoreWebApi.Aloha.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApi.Aloha.Features.Aloha
{
    public class AlohaAppService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AlohaAppService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<Response> GetAllGroupMembers() 
        {
            IEnumerable<AlohaGroupMember> alohaGroupMembers = await _unitOfWork.repository.GetAllAsync();

            return new Response { Data = alohaGroupMembers };
        }
    }
}
