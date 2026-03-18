// 3. Pobranie Connection Stringa (zmiennej środowiskowej z Dockera)
// Najpierw szukaj w zmiennych środowiskowych (Docker), 
// a jeśli tam nie ma (lokalny terminal), weź z appsettings.json
var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING") 
                       ?? builder.Configuration.GetConnectionString("DefaultConnection");
