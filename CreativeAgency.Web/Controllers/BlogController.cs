using CreativeAgency.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace CreativeAgency.Web.Controllers
{
    public class BlogController : Controller
    {
        private List<BlogPostModel> GetSamplePosts()
        {
            return new List<BlogPostModel>
        {
            new BlogPostModel { Title = "How SEO Can Transform Your Business", Description = "Discover how optimizing for search engines can bring in more traffic and conversions.", Slug = "seo-transform-business", PublishedDate = new DateTime(2025, 6, 10), Category = "Marketing" },
            new BlogPostModel { Title = "Content is Still King in 2025", Description = "Great content continues to be the cornerstone of online marketing strategies.", Slug = "content-king-2025", PublishedDate = new DateTime(2025, 5, 22), Category = "Strategy" },
            new BlogPostModel { Title = "Top 5 Social Media Trends This Year", Description = "Stay ahead with these hot trends shaping social media engagement and reach.", Slug = "social-trends-2025", PublishedDate = new DateTime(2025, 6, 1), Category = "Social Media" },
            new BlogPostModel { Title = "Building Modern Websites That Convert", Description = "Learn about UX/UI strategies that lead to higher engagement and conversions.", Slug = "modern-websites", PublishedDate = new DateTime(2025, 6, 15), Category = "Design" },
            new BlogPostModel { Title = "Mastering the Art of Branding", Description = "Learn how consistent visuals and messaging can establish lasting brand identity.", Slug = "branding-mastery", PublishedDate = new DateTime(2025, 6, 20), Category = "Branding" },
            new BlogPostModel { Title = "Email Marketing Hacks for Higher CTR", Description = "Simple yet powerful tactics to boost your email campaign click-through rates.", Slug = "email-marketing-hacks", PublishedDate = new DateTime(2025, 6, 18), Category = "Marketing" },
            new BlogPostModel { Title = "Minimalist Web Design Trends", Description = "Explore the elegance and usability behind the minimalist movement in design.", Slug = "minimalist-web-design", PublishedDate = new DateTime(2025, 6, 12), Category = "Design" },
            new BlogPostModel { Title = "Why Storytelling Works in Advertising", Description = "How emotional storytelling connects brands with consumers on a deeper level.", Slug = "storytelling-in-ads", PublishedDate = new DateTime(2025, 6, 5), Category = "Strategy" },
            new BlogPostModel { Title = "The Psychology of Color in UI Design", Description = "Tap into how colors affect user decisions and enhance visual communication.", Slug = "color-psychology-ui", PublishedDate = new DateTime(2025, 5, 30), Category = "Design" },
            new BlogPostModel { Title = "Influencer Collaborations That Convert", Description = "Find out how to team up with the right influencers for authentic engagement.", Slug = "influencer-collab-success", PublishedDate = new DateTime(2025, 5, 25), Category = "Social Media" }

        };
        }

        public IActionResult Index(string sortOrder = "newest", string category = null, int page = 1)
        {
            var posts = GetSamplePosts();

            if (!string.IsNullOrEmpty(category))
            {
                posts = posts.Where(p => p.Category == category).ToList();
            }

            posts = sortOrder == "oldest"
                ? posts.OrderBy(p => p.PublishedDate).ToList()
                : posts.OrderByDescending(p => p.PublishedDate).ToList();

            int pageSize = 4;
            int totalPosts = posts.Count();
            int totalPages = (int)Math.Ceiling(totalPosts / (double)pageSize);
            var pagedPosts = posts.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.CurrentSort = sortOrder;
            ViewBag.SelectedCategory = category;
            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;

            return View(pagedPosts);
        }

     
        public IActionResult Detail(string slug)
        {
            var post = GetSamplePosts().FirstOrDefault(p => p.Slug == slug);
            return View(post);
        }
    }
}

