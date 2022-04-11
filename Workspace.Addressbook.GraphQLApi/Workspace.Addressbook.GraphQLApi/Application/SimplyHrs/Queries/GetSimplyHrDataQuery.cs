using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Workspace.Addressbook.GraphQLApi.Domain;

namespace Workspace.Addressbook.GraphQLApi.Application.SimplyHrs.Queries
{
    public class GetSimplyHrDataQuery : IRequest<IQueryable<SimplyHr>>
    {
        public GetSimplyHrDataQuery() { }
    }

    internal class GetAllHrDataQueryHandler : IRequestHandler<GetSimplyHrDataQuery, IQueryable<SimplyHr>>
    {
        private readonly DNBCustomContext _context;

        public GetAllHrDataQueryHandler(DNBCustomContext context)
        {
            _context = context;
        }

        public async Task<IQueryable<SimplyHr>> Handle(GetSimplyHrDataQuery request, CancellationToken cancellationToken)
        {
            var urls = await _context.SimplyHrs.ToListAsync(cancellationToken);
            return urls.AsQueryable();
        }
    }
}