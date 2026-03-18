// Pobranie parametrów bazy z konfiguracji systemu (Docker to dostarczy)
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));
// Ważne: Włączamy CORS, aby Frontend (port 8080) mógł rozmawiać z API (port 8081)
builder.Services.AddCors(options => {
    options.AddDefaultPolicy(policy => 
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});
