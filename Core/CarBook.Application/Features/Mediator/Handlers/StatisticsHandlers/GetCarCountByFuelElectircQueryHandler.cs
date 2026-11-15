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
    public class GetCarCountByFuelElectircQueryHandler: IRequestHandler<GetCarCountByFuelElectircQuery, GetCarCountByFuelElectircQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarCountByFuelElectircQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountByFuelElectircQueryResult> Handle(GetCarCountByFuelElectircQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByFuelElectirc();
            return new GetCarCountByFuelElectircQueryResult
            {
                CarCountByFuelElectirc = value,
            };

        }
    }

}
