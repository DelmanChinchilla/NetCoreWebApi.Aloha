using NetCoreWebApi.Aloha.Features.Aloha;
using NetCoreWebApi.Aloha.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApi.Aloha.BCUnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {

        IRepository<AlohaGroupMember> repository { get; }

        void Commit();

        Task CommitAsync();
    }
}
