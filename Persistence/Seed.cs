using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Posts.Any())
            {
                var Posts = new List<Post>
                {
                    new Post {
                        Title = "First Post",
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Convallis tellus id interdum velit laoreet id donec. Eros donec ac odio tempor orci dapibus. Tempus iaculis urna id volutpat lacus laoreet. Lorem ipsum dolor sit amet consectetur adipiscing elit. Ac felis donec et odio pellentesque. A arcu cursus vitae congue mauris rhoncus aenean vel elit. Netus et malesuada fames ac turpis egestas sed. Iaculis nunc sed augue lacus viverra. Tristique senectus et netus et. Magna fringilla urna porttitor rhoncus dolor purus non. Sodales neque sodales ut etiam sit amet. Rhoncus est pellentesque elit ullamcorper dignissim cras tincidunt lobortis.",
                        Date = DateTime.Now.AddDays(-10)
                        },
                    new Post {
                        Title = "Second Post",
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Convallis tellus id interdum velit laoreet id donec. Eros donec ac odio tempor orci dapibus. Tempus iaculis urna id volutpat lacus laoreet. Lorem ipsum dolor sit amet consectetur adipiscing elit. Ac felis donec et odio pellentesque. A arcu cursus vitae congue mauris rhoncus aenean vel elit. Netus et malesuada fames ac turpis egestas sed. Iaculis nunc sed augue lacus viverra. Tristique senectus et netus et. Magna fringilla urna porttitor rhoncus dolor purus non. Sodales neque sodales ut etiam sit amet. Rhoncus est pellentesque elit ullamcorper dignissim cras tincidunt lobortis.",
                        Date = DateTime.Now.AddDays(-7)
                        },
                    new Post {
                        Title = "Third Post",
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Convallis tellus id interdum velit laoreet id donec. Eros donec ac odio tempor orci dapibus. Tempus iaculis urna id volutpat lacus laoreet. Lorem ipsum dolor sit amet consectetur adipiscing elit. Ac felis donec et odio pellentesque. A arcu cursus vitae congue mauris rhoncus aenean vel elit. Netus et malesuada fames ac turpis egestas sed. Iaculis nunc sed augue lacus viverra. Tristique senectus et netus et. Magna fringilla urna porttitor rhoncus dolor purus non. Sodales neque sodales ut etiam sit amet. Rhoncus est pellentesque elit ullamcorper dignissim cras tincidunt lobortis.",
                        Date = DateTime.Now.AddDays(-4)
                        },
                };

                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}