using HotChocolate;
using HotChocolate.Data;
using MediatR;
using System.Linq;
using System.Threading.Tasks;
using Workspace.Addressbook.GraphQLApi.Application.SimplyHrs.Queries;
using Workspace.Addressbook.GraphQLApi.Domain;

namespace Workspace.Addressbook.GraphQLApi.GraphQL
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public async Task<IQueryable<SimplyHr>> GetSimplyHr([Service] IMediator _mediator)
        {
            return await _mediator.Send(new GetSimplyHrDataQuery());
        }
    }
}
