using CarBook.Application.Features.Mediator.Queries.FooterAddresQueries;
using CarBook.Application.Features.Mediator.Results.FooterAddressResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.FooterAdressHandlers
{
    public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAdressQuery, List<GetFooterAddressQueryResult>>
    {
        private readonly IRepository<FooterAdress> _repository;
        public GetFooterAddressQueryHandler(IRepository<FooterAdress> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFooterAddressQueryResult>> Handle(GetFooterAdressQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAllAsync();
            return value.Select(x => new GetFooterAddressQueryResult
            {
                Address = x.Address,
                Description = x.Description,
                Email = x.Email,
                FooterAdressID = x.FooterAdressID,
                Phone = x.Phone,
            }).ToList();
        }
    }
}
