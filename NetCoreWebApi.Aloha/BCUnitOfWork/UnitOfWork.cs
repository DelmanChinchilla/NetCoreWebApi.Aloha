using NetCoreWebApi.Aloha.DataContext;
using NetCoreWebApi.Aloha.Features.Aloha;
using NetCoreWebApi.Aloha.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApi.Aloha.BCUnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AlohaDataContext _context;
        private readonly IRepository<AlohaGroupMember> _alohaRepository;
        public UnitOfWork(AlohaDataContext context)
        {
            _context = context;
        }

        public IRepository<AlohaGroupMember> repository => _alohaRepository ?? new GenericRepository<AlohaGroupMember>(_context);

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            if(_context != null) 
            {
                _context.Dispose();
            }
        }
    }
}
