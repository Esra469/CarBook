using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetBrandTitleByMaxBlogCommentQueryHandler: IRequestHandler<GetBrandTitleByMaxBlogCommentQuery, GetBrandTitleByMaxBlogCommentQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetBrandTitleByMaxBlogCommentQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetBrandTitleByMaxBlogCommentQueryResult> Handle(GetBrandTitleByMaxBlogCommentQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetBrandTitleByMaxBlogComment();
            return new GetBrandTitleByMaxBlogCommentQueryResult
            {
                BrandTitleByMaxBlogComment = value,
            };

        }
    }

}
