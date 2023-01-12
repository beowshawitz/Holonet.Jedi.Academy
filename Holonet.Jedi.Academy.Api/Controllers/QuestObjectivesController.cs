using Holonet.Jedi.Academy.BL.Data;
using Holonet.Jedi.Academy.Entities.App;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Holonet.Jedi.Academy.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class QuestObjectivesController : ControllerBase
	{
		private readonly ILogger<QuestObjectivesController> _logger;
		private readonly AcademyContext _context;

		public QuestObjectivesController(ILogger<QuestObjectivesController> logger, AcademyContext context)
		{
			_logger = logger;
			_context = context;
		}

		// GET: api/[controller]
		[HttpGet]
		public async Task<ActionResult<IEnumerable<QuestObjective>>> GetObjectives()
		{
			return await _context.QuestObjectives
				.Include(q => q.Objective).ThenInclude(o => o.Destinations).ThenInclude(d => d.Planet)
				.ToListAsync();
		}

		// GET: api/[controller]/5
		[HttpGet("{id}")]
		public async Task<ActionResult<QuestObjective>> GetObjective(int id)
		{
			var questObjective = await _context.QuestObjectives
				.Include(q => q.Objective).ThenInclude(o => o.Destinations).ThenInclude(d => d.Planet)
				.Where(qo => qo.Id == id)
				.FirstOrDefaultAsync();

			if (questObjective == null)
			{
				return NotFound();
			}

			return questObjective;
		}

		// PUT: api/[controller]/5
		// To protect from overposting attacks, enable the specific properties you want to bind to, for
		// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
		[HttpPut("{id}")]
		public async Task<IActionResult> PutObjective(int id, QuestObjective item)
		{
			if (id != item.Id)
			{
				return BadRequest();
			}

			_context.QuestObjectives.Update(item);

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!ObjectiveExists(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return NoContent();
		}

		// POST: api/[controller]
		// To protect from overposting attacks, enable the specific properties you want to bind to, for
		// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
		[HttpPost]
		public async Task<ActionResult<QuestObjective>> PostObjective(QuestObjective item)
		{
			_context.QuestObjectives.Add(item);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetObjective", new { id = item.Id }, item);
		}

		// DELETE: api/[controller]/5
		[HttpDelete("{id}")]
		public async Task<ActionResult<QuestObjective>> DeleteObjective(int id)
		{
			var questObjective = await _context.QuestObjectives.FindAsync(id);
			if (questObjective == null)
			{
				return NotFound();
			}

			_context.QuestObjectives.Remove(questObjective);
			await _context.SaveChangesAsync();

			return questObjective;
		}

		private bool ObjectiveExists(int id)
		{
			return _context.QuestObjectives.Any(e => e.Id == id);
		}
	}
}