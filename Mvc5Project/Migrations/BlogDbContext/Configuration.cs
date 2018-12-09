namespace Mvc5Project.Migrations.BlogDbContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.BlogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\BlogDbContext";
        }

        protected override void Seed(Models.BlogDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Categories.AddOrUpdate(new Models.Category{ Id = "cat1", Name = "C++", UrlSeo = "C++", Description = "C++ Category" });
            context.Categories.AddOrUpdate(new Models.Category { Id = "cat2", Name = "C#", UrlSeo = "C#", Description = "C# Category" });
            context.Categories.AddOrUpdate(new Models.Category { Id = "cat3", Name = "Java", UrlSeo = "Java", Description = "Java Category" });
            context.Categories.AddOrUpdate(new Models.Category { Id = "cat4", Name = "Python", UrlSeo = "Python", Description = "Python Category" });

            context.Posts.AddOrUpdate(new Models.Post
            {
                Id = "1",
                Title = "History C++",
                Body = "In 1979, Bjarne Stroustrup, a Danish computer scientist," +
                " began work on 'C with Classes', the predecessor to C++. The motivation for creating a new language originated from" +
                " Stroustrup's experience in programming for his Ph.D. thesis. Stroustrup found that Simula had features that were very helpful for " +
                "large software development, but the language was too slow for practical use, while BCPL was fast but too low-level to be suitable for" +
                " large software development. When Stroustrup started working in AT&T Bell Labs, he had the problem of analyzing the UNIX kernel with" +
                " respect to distributed computing. Remembering his Ph.D. experience, Stroustrup set out to enhance the C language with Simula-like" +
                " features.C was chosen because it was general-purpose, fast, portable and widely used. As well as C and Simula's influences, other" +
                " languages also influenced C++, including ALGOL 68, Ada, CLU and ML.",
                ShortDescription = "In 1979, Bjarne Stroustrup, a Danish computer scientist," +
                " began work on 'C with Classes', the predecessor to C++.",
                PostedOn = DateTime.Now,
                Meta = "History C++",
                UrlSeo = "C++",
                Published = true
            });
            context.Posts.AddOrUpdate(new Models.Post
            {
                Id = "2",
                Title = "History C#",
                Body = "During the development of the .NET Framework, the class libraries were originally written using a managed code compiler system" +
                " called Simple Managed C (SMC). In January 1999, Anders Hejlsberg formed a team to build a new language at the time called Cool, which" +
                " stood for 'C - like Object Oriented Language'. Microsoft had considered keeping the name 'Cool' as the final name of the language," +
                " but chose not to do so for trademark reasons. By the time the .NET project was publicly announced at the July 2000 Professional" +
                " Developers Conference, the language had been renamed C#, and the class libraries and ASP.NET runtime had been ported to C#.",
                ShortDescription = "During the development of the .NET Framework, the class libraries were originally written using a managed code compiler system" +
                " called Simple Managed C (SMC).",
                PostedOn = DateTime.Now,
                Meta = "History C#",
                UrlSeo = "C#",
                Published = true
            });
            context.Posts.AddOrUpdate(new Models.Post
            {
                Id = "3",
                Title = "History Java",
                Body = "James Gosling, Mike Sheridan, and Patrick Naughton initiated the Java language project in June 1991. Java was originally " +
                "designed for interactive television, but it was too advanced for the digital cable television industry at the time. The language was " +
                "initially called Oak after an oak tree that stood outside Gosling's office. Later the project went by the name Green and was finally" +
                " renamed Java, from Java coffee. Gosling designed Java with a C/C++-style syntax that system and application programmers would find " +
                "familiar.",
                ShortDescription = "James Gosling, Mike Sheridan, and Patrick Naughton initiated the Java language project in June 1991.",
                PostedOn = DateTime.Now,
                Meta = "History Java",
                UrlSeo = "Java",
                Published = true
            });
            context.Posts.AddOrUpdate(new Models.Post
            {
                Id = "4",
                Title = "History Python",
                Body = "Python was conceived in the late 1980s, and its implementation began in December 1989[29] by Guido van Rossum at Centrum" +
                " Wiskunde & Informatica (CWI) in the Netherlands as a successor to the ABC language (itself inspired by SETL) capable of exception " +
                "handling and interfacing with the Amoeba operating system. Van Rossum remains Python's principal author. His continuing central role" +
                " in Python's development is reflected in the title given to him by the Python community: Benevolent Dictator For Life (BDFL) ­– a post" +
                " from which he gave himself permanent vacation on July 12, 2018.",
                ShortDescription = "Python was conceived in the late 1980s, and its implementation began in December 1989[29] by Guido van Rossum at Centrum",
                PostedOn = DateTime.Now,
                Meta = "History Python",
                UrlSeo = "Python",
                Published = true
            });
            context.PostCategories.AddOrUpdate(new Models.PostCategory { PostId = "1", CategoryId = "cat1" });
            context.PostCategories.AddOrUpdate(new Models.PostCategory { PostId = "2", CategoryId = "cat2" });
            context.PostCategories.AddOrUpdate(new Models.PostCategory { PostId = "3", CategoryId = "cat3" });
            context.PostCategories.AddOrUpdate(new Models.PostCategory { PostId = "4", CategoryId = "cat4" });

            context.PostVideos.AddOrUpdate(new Models.PostVideo
            {
                Id = 1,
                PostId = "1",
                VideoSiteName = "Youtube",
                VideoUrl = "https://www.youtube.com/watch?v=UnlC7Xp4KxI",
                VideoThumbnail = "https://image.slidesharecdn.com/historyofcbyihsanwassan-160502190625/95/history-of-c-5-638.jpg"
            });
            context.PostVideos.AddOrUpdate(new Models.PostVideo
            {
                Id = 2,
                PostId = "2",
                VideoSiteName = "Youtube",
                VideoUrl = "https://www.youtube.com/watch?v=T72Azg7IwUY",
                VideoThumbnail = "https://www.javatpoint.com/csharp/images/csharp-history2.png"
            });
            context.PostVideos.AddOrUpdate(new Models.PostVideo
            {
                Id = 3,
                PostId = "3",
                VideoSiteName = "Youtube",
                VideoUrl = "https://www.youtube.com/watch?v=C5cOuGPL1yE",
                VideoThumbnail = "https://dzone.com/storage/temp/5326984-java-version-history.jpg"
            });
            context.PostVideos.AddOrUpdate(new Models.PostVideo
            {
                Id = 4,
                PostId = "4",
                VideoSiteName = "Youtube",
                VideoUrl = "https://www.youtube.com/watch?v=ualxVE4YOjc",
                VideoThumbnail = "https://image.slidesharecdn.com/combined-150417081442-conversion-gate02/95/python-for-scientific-computing-6-638.jpg"
            });
        }
    
    }
}
