[HttpGet]
public async Task<ActionResult<IEnumerable<TaskReadDto>>> GetAll()
{
    // Pobieramy encje z bazy danych
    var tasks = await _context.Tasks.ToListAsync();
    // Mapujemy każdą encję na obiekt DTO
    var tasksDto = tasks.Select(t => new TaskReadDto
    {
        Id = t.Id,
        Name = t.Name,
        IsCompleted = t.IsCompleted
    });
    return Ok(tasksDto);
}
