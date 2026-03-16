[HttpGet]
public async Task<ActionResult> GetAll() 
{
    return Ok(await _context.Tasks.ToListAsync());
}
