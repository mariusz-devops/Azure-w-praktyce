<form onSubmit={handleAddTask} style={{ marginBottom: '20px' }}>
  <input 
    type="text" 
    placeholder="Wpisz nowe zadanie..." 
    value={newTaskName}
    onChange={(e) => setNewTaskName(e.target.value)}
    style={{ padding: '8px', width: '250px' }}
  />
  <button type="submit" style={{ marginLeft: '10px', padding: '8px 15px' }}>
    Dodaj Zadanie
  </button>
</form>
