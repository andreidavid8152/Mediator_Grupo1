using Mediator.Data;
using Memento_Grupo1.Memento;
using Memento_Grupo1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Mediator.Controllers
{
    public class MediatorController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly Caretaker caretaker = new Caretaker();
        private readonly Originator originator = new Originator();
        private int savepoint = 0;

        public MediatorController(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

    }
}
