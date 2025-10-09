using Bulky.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Fortune of Time",
                    Author = "Billy Spark",
                    Description = "<p><span style=\"font-family: 'book antiqua', palatino, serif;\">Pulvinar <em>vivamus fringilla</em> lacus nec metus bibendum egestas. Iaculis massa nisl malesuada lacinia integer nunc posuere. Ut hendrerit semper vel class aptent taciti sociosqu. <em>Ad litora</em> torquent per conubia nostra inceptos himenaeos.</span></p>\r\n<p><span style=\"font-family: 'book antiqua', palatino, serif;\">Lorem ipsum dolor sit amet <strong>consectetur </strong>adipiscing elit. Quisque faucibus ex sapien vitae <span style=\"text-decoration: underline;\">pellentesque</span> sem placerat. In id cursus mi pretium tellus duis convallis.</span></p>",
                    ISBN = "SWD9999001",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl = "\\images\\product\\8216e907-836a-4a7f-ba04-94bbf829f1d0.jpg"
                },
                new Product
                {
                    Id = 2,
                    Title = "Dark Skies",
                    Author = "Nancy Hoover",
                    Description = "<p><span style=\"font-family: 'book antiqua', palatino, serif;\">Pulvinar <em>vivamus fringilla</em> lacus nec metus bibendum egestas. Iaculis massa nisl malesuada lacinia integer nunc posuere. Ut hendrerit semper vel class aptent taciti sociosqu. <em>Ad litora</em> torquent per conubia nostra inceptos himenaeos.</span></p>\r\n<p><span style=\"font-family: 'book antiqua', palatino, serif;\">Lorem ipsum dolor sit amet <strong>consectetur </strong>adipiscing elit. Quisque faucibus ex sapien vitae <span style=\"text-decoration: underline;\">pellentesque</span> sem placerat. In id cursus mi pretium tellus duis convallis.</span></p>",
                    ISBN = "CAW777777701",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 1,
                    ImageUrl = "\\images\\product\\05a0a916-070d-408c-8293-6e0fceff1424.jpg"
                },
                new Product
                {
                    Id = 3,
                    Title = "Vanish in the Sunset",
                    Author = "Julian Button",
                    Description = "<p><span style=\"font-family: 'book antiqua', palatino, serif;\">Pulvinar <em>vivamus fringilla</em> lacus nec metus bibendum egestas. Iaculis massa nisl malesuada lacinia integer nunc posuere. Ut hendrerit semper vel class aptent taciti sociosqu. <em>Ad litora</em> torquent per conubia nostra inceptos himenaeos.</span></p>\r\n<p><span style=\"font-family: 'book antiqua', palatino, serif;\">Lorem ipsum dolor sit amet <strong>consectetur </strong>adipiscing elit. Quisque faucibus ex sapien vitae <span style=\"text-decoration: underline;\">pellentesque</span> sem placerat. In id cursus mi pretium tellus duis convallis.</span></p>",
                    ISBN = "RITO5555501",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 1,
                    ImageUrl = "\\images\\product\\38624c19-1449-4e6c-af00-7855b1f1a9f8.jpg"
                },
                new Product
                {
                    Id = 4,
                    Title = "Cotton Candy",
                    Author = "Abby Muscles",
                    Description = "<p><span style=\"font-family: 'book antiqua', palatino, serif;\">Pulvinar <em>vivamus fringilla</em> lacus nec metus bibendum egestas. Iaculis massa nisl malesuada lacinia integer nunc posuere. Ut hendrerit semper vel class aptent taciti sociosqu. <em>Ad litora</em> torquent per conubia nostra inceptos himenaeos.</span></p>\r\n<p><span style=\"font-family: 'book antiqua', palatino, serif;\">Lorem ipsum dolor sit amet <strong>consectetur </strong>adipiscing elit. Quisque faucibus ex sapien vitae <span style=\"text-decoration: underline;\">pellentesque</span> sem placerat. In id cursus mi pretium tellus duis convallis.</span></p>",
                    ISBN = "WS3333333301",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55,
                    CategoryId = 2,
                    ImageUrl = "\\images\\product\\24a75185-6234-4d15-a321-0120098d1dba.jpg"
                },
                new Product
                {
                    Id = 5,
                    Title = "Rock in the Ocean",
                    Author = "Ron Parker",
                    Description = "<p><span style=\"font-family: 'book antiqua', palatino, serif;\">Pulvinar <em>vivamus fringilla</em> lacus nec metus bibendum egestas. Iaculis massa nisl malesuada lacinia integer nunc posuere. Ut hendrerit semper vel class aptent taciti sociosqu. <em>Ad litora</em> torquent per conubia nostra inceptos himenaeos.</span></p>\r\n<p><span style=\"font-family: 'book antiqua', palatino, serif;\">Lorem ipsum dolor sit amet <strong>consectetur </strong>adipiscing elit. Quisque faucibus ex sapien vitae <span style=\"text-decoration: underline;\">pellentesque</span> sem placerat. In id cursus mi pretium tellus duis convallis.</span></p>",
                    ISBN = "SOTJ1111111101",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 2,
                    ImageUrl = "\\images\\product\\7685b99a-d0f6-475b-91cc-95982611db35.jpg"
                },
                new Product
                {
                    Id = 6,
                    Title = "Leaves and Wonders",
                    Author = "Laura Phantom",
                    Description = "<p><span style=\"font-family: 'book antiqua', palatino, serif;\">Pulvinar <em>vivamus fringilla</em> lacus nec metus bibendum egestas. Iaculis massa nisl malesuada lacinia integer nunc posuere. Ut hendrerit semper vel class aptent taciti sociosqu. <em>Ad litora</em> torquent per conubia nostra inceptos himenaeos.</span></p>\r\n<p><span style=\"font-family: 'book antiqua', palatino, serif;\">Lorem ipsum dolor sit amet <strong>consectetur </strong>adipiscing elit. Quisque faucibus ex sapien vitae <span style=\"text-decoration: underline;\">pellentesque</span> sem placerat. In id cursus mi pretium tellus duis convallis.</span></p>",
                    ISBN = "FOT000000001",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                    CategoryId = 3,
                    ImageUrl = "\\images\\product\\49ae40be-2f0a-4b4c-9381-341d8df9b4d7.jpg"
                }
             );
        }
    }
}
