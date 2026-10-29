using CarBook.Application.Features.Mediator.Commands.FooterAdressCommand;
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
    public class CreateFooterAddresCommandHandler:IRequestHandler<CreateFooterAddressCommand>
    {
        private readonly IRepository<FooterAdress> _repository;
        public CreateFooterAddresCommandHandler(IRepository<FooterAdress> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateFooterAddressCommand request,CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new FooterAdress
            {
                Address = request.Address,
                Description = request.Description,
                Email = request.Email,
                Phone = request.Phone
            });
        }
    }
}
