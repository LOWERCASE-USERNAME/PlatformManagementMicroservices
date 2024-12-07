using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDB
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<ApplicationDbContext>());
            }
        }

        public static void SeedData(ApplicationDbContext context)
        {
            if (context.Platforms.Any())
            {
                return;
            }

            context.Platforms.AddRange(
                new Platform() { Name = ".NET", Publisher = "Microsoft", Cost = "Free"},
                new Platform() { Name = "Sql Server Express", Publisher = "Microsoft", Cost = "Free"},
                new Platform() { Name = "Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost = "Free"}
                );

            context.SaveChanges();
        }
    }
}
