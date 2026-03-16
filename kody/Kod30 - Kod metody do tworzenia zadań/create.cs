 [HttpPost] // 3. Dodaj (CREATE)
    public async Task<ActionResult> Create(CloudTask task) 
    {
        _context.Tasks.Add(task);
        await _context.SaveChangesAsync();
        // Zwraca status 201 Created oraz lokalizację nowego zasobu
        return CreatedAtAction(nameof(GetById), new { id = task.Id }, task);
    }