const handleAddTask = async (e) => {
  e.preventDefault(); // Zatrzymaj przeładowanie strony
  if (!newTaskName.trim()) return;

  try {
    // Wysyłamy TYLKO pole 'name', bo tego wymaga TaskCreateDto
    await axios.post(`${import.meta.env.VITE_API_URL}/api/Tasks`, {
      name: newTaskName
    });
    
    setNewTaskName(""); // Wyczyść pole
    fetchTasks();       // Odśwież listę, aby zobaczyć nowe zadanie
  } catch (err) {
    console.error("Błąd podczas dodawania:", err);
  }
};
