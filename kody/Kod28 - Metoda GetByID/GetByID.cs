    [HttpGet("{id}")] // 2. Szczegóły (READ ONE)
    public async Task<ActionResult> GetById(int id) 
    {
        var task = await _context.Tasks.FindAsync(id);
        return task == null ? NotFound() : Ok(task);
    }