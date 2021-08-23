using NetCoreWebApi.Aloha.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApi.Aloha.Features.Aloha
{
    public class AlohaGroupMember : BaseEntity
    {

        public string MemberName { get; set; }

        public DateTime BirthDay { get; set; }


    }
}
