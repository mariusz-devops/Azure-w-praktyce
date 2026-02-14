import axios from "axios";
const api = axios.create({
// Tutaj React pobiera adres z pliku .env, który właśnie stworzyłeś
baseURL: import.meta.env.VITE_API_URL,
});
export default api;
