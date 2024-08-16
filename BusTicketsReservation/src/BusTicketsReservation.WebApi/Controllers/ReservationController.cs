using BusTicketsReservation.Application.Commands.Reservations;
using BusTicketsReservation.Domain.Common;
using BusTicketsReservation.Domain.Entities.Reservations;
using BusTicketsReservation.Domain.Entities.Users;
using BusTicketsReservation.Infrastructure.Context;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BusTicketsReservation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ReservationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("book-tickets")]
        public async Task<IActionResult> BookTickets([FromBody] TicketsRequest request)
        {
            var response = await _mediator.Send(request);

            if (!string.IsNullOrEmpty(response.Message))
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        
    }

}
