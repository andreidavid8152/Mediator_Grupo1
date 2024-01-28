using MediatR;

namespace Mediator_Grupo1.Mediator
{
    public class Mensaje : IRequest<Unit>
    {
        public string Contenido { get; set; }

        public Mensaje(string contenido)
        {
            Contenido = contenido;
        }
    }
}
