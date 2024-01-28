using MediatR;

namespace Mediator_Grupo1.Mediator
{
    public class MediadorConcreto
    {
        private readonly IMediator _mediator;

        public MediadorConcreto(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task EnviarMensaje(Usuario remitente, string mensaje)
        {
            await _mediator.Send(new Mensaje($"{remitente.Nombre}: {mensaje}"));
        }
    }
}
