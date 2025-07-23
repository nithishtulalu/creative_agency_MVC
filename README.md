
# Creative Agency Website – ASP.NET MVC 

## 📁 Project Structure
├── Controllers/
├── Models/
├── Views/
├── wwwroot/
└── appsettings.json

## 🚀 Features

- Home, About, Services, Blog, and Contact pages
- Blog listing and dynamic detail page using slug routing
- Razor View Engine with shared layout and components
- Dynamic navigation menu with active link highlighting
- Contact form with validation and submission (Option: Save to Database)
- SEO-friendly meta tags and titles per page
- Bootstrap and jQuery integrated via CDN/local fallback
- Organized static files under `wwwroot/`

## 🌐 Routing Plan

| URL             | Controller / Action           | Description           |
|-----------------|-------------------------------|-----------------------|
| `/`             | `HomeController.Index()`       | Home Page             |
| `/about`        | `HomeController.About()`       | About Page            |
| `/services`     | `HomeController.Services()`    | Services Page         |
| `/contact`      | `ContactController.Index()`    | Contact Form Page     |
| `/blog`         | `BlogController.Index()`       | Blog Listing Page     |
| `/blog/{slug}`  | `BlogController.Detail(slug)`  | Blog Detail Page      |

## 🧩 Technologies Used

- ASP.NET MVC (Razor View Engine)
- Entity Framework Core (Contact form DB save)
- Bootstrap 5
- SQL Server
- C#

## 🧾 Contact Form Handling

- Fields: First Name, Last Name, Email, Enquiry Type, Summary
- Validation: Client-side + Server-side
- Submission Method: **Saved to SQL Server Database** using Entity Framework Core
- Displays Success/Error message on submission

## 📂 Static Assets

- All CSS, JS, and images are placed under `wwwroot/`
- Uses Razor helpers for file linking: `~/css/style.css`

## 🎯 How to Run

1. Clone the repository
2. Open in Visual Studio
3. Update `appsettings.json` with your SQL Server connection string
4. Run EF Migrations if needed
5. Press F5 to build and run the site

## 💡 Future Improvements 

- Add blog management via Admin panel
- Integrate CAPTCHA for the contact form
- Enable email sending via SMTP (Option 3)


## 📬 Contact

For any queries or feedback, please reach out at:
**Name:** Nithish Tulalu  
**Email:** nithishtulalu121@gmail.com  
**LinkedIn:** (https://www.linkedin.com/in/nithish-tulalu-58382a31a/)

---




