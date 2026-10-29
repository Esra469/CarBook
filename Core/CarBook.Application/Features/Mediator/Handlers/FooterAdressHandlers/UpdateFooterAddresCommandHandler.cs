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
    public class UpdateFooterAddresCommandHandler : IRequestHandler<UpdateFooterAddressCommand>
    {
        private readonly IRepository<FooterAdress> _repository;
        
        public UpdateFooterAddresCommandHandler(IRepository<FooterAdress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.FooterAdressID);
            values.Phone = request.Phone;
            values.Address=request.Address;
            values.Email = request.Email;
            values.Description=request.Description;
            await _repository.UpdateAsync(values);
        }
    }
}
