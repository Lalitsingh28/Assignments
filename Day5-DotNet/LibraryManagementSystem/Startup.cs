
services.AddDbContext<LibraryContext>(options =>
    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));