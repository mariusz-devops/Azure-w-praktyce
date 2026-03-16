[HttpPost]
public async Task<ActionResult<TaskReadDto>> Create(TaskCreateDto taskDto)
{
    // 1. Mapowanie DTO -> Entity
    // Przekształcamy to, co przyszło z sieci, na model bazy danych
    var newTask = new CloudTask
    {
        Name = taskDto.Name,
        IsCompleted = false // Domyślnie nowe zadanie nie jest gotowe
    };

    // 2. Zapis do bazy danych
    _context.Tasks.Add(newTask);
    await _context.SaveChangesAsync();

    // 3. Mapowanie Entity -> DTO (Zwrotka)
    // Zwracamy TaskReadDto, który zawiera już nadane przez bazę Id
    var readDto = new TaskReadDto
    {
        Id = newTask.Id,
        Name = newTask.Name,
        IsCompleted = newTask.IsCompleted
    };

    return CreatedAtAction(nameof(GetById), new { id = readDto.Id }, readDto);
}
