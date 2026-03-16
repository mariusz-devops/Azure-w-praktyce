[HttpGet("{id}")]
public async Task<ActionResult<TaskReadDto>> GetById(int id)
{
    var task = await _context.Tasks.FindAsync(id);
    if (task == null) return NotFound();  // Zwracamy DTO zamiast czystej encji
    return Ok(new TaskReadDto 
    { 
        Id = task.Id, 
        Name = task.Name, 
        IsCompleted = task.IsCompleted 
    });
}
