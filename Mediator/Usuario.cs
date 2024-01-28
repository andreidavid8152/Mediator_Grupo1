using MediatR;

namespace Mediator_Grupo1.Mediator
{
    public class Usuario : IRequestHandler<Mensaje, Unit>
    {
        public string Nombre { get; private set; }

        public Usuario(string nombre)
        {
            Nombre = nombre;
        }

        public async Task<Unit> Handle(Mensaje mensaje, CancellationToken cancellationToken)
        {
            Console.WriteLine($"{Nombre} recibió: {mensaje.Contenido}");
            return Unit.Value; // Cambiado de Unit.Task a Unit.Value
        }
    }

}
