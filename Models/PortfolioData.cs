namespace Portfolio.Models;

// ---------- Section record types ----------
public record EducationItem(string Period, string Degree, string Institution, string Detail);
public record CpProfile(string Platform, string Handle, string Rating, string Url, string Note);
public record CpAchievement(string Title, string Detail, string? Url);
public record SkillGroup(string Category, string[] Items);
public record Project(string Name, string Description, string[] Tech, string? DemoUrl, string? CodeUrl);
public record ResearchItem(string Title, string Venue, string Status, string? Url, string Description);
public record ActivityItem(string Title, string Role, string Period, string Description);
public record ContactLink(string Label, string Value, string Url, string Icon);

public class PortfolioModel
{
    // ----- Hero / identity -----
    public string Name { get; set; } = "";
    public string Tagline { get; set; } = "";
    public string Intro { get; set; } = "";
    public string Location { get; set; } = "";
    public string? PhotoUrl { get; set; }
    public string? ResumeUrl { get; set; }

    // ----- Sections -----
    public List<EducationItem> Education { get; set; } = new();
    public List<CpProfile> CompetitiveProgramming { get; set; } = new();
    public List<CpAchievement> CpAchievements { get; set; } = new();
    public string CpSummary { get; set; } = "";
    public List<SkillGroup> Skills { get; set; } = new();
    public List<Project> Projects { get; set; } = new();
    public List<ResearchItem> Research { get; set; } = new();
    public List<ActivityItem> Activities { get; set; } = new();
    public List<ContactLink> Contacts { get; set; } = new();
}

// ==========================================================
//  ALL CONTENT — Halima Khatun Meem
// ==========================================================
public static class PortfolioData
{
    public static PortfolioModel Current { get; } = new()
    {
        Name = "Halima Khatun Meem",
        Tagline = "Undergraduate CSE Student · Competitive Programmer · ASP.NET Developer",
        Intro = "I build practical software solutions and enjoy exploring technology, " +
                "solving problems, and continuously learning new things.",
        Location = "Dhaka, Bangladesh",

        Education = new()
        {
            new("May 2023 — Present", "B.Sc. in Computer Science & Engineering",
                "International University of Business Agriculture and Technology (IUBAT)",
                "CGPA: 3.70 / 4.00"),
            new("2021", "Higher Secondary Certificate (Science)",
                "Shaheed Bir Uttam Lt. Anwar Girls College",
                "GPA: 5.00 / 5.00"),
            new("2019", "Secondary School Certificate (Science)",
                "Monipur High School",
                "GPA: 5.00 / 5.00"),
        },

        CompetitiveProgramming = new()
        {
            new("Codeforces", "__snowy__", "Rating 1068 · max 1072", "https://codeforces.com/profile/__snowy__/", ""),
            new("CodeChef", "snow_y", "", "https://www.codechef.com/users/snow_y/", ""),
            new("LeetCode", "Sn-O-WY", "", "https://leetcode.com/u/Sn-O-WY/", ""),
            new("Toph", "SnO_OwY", "", "https://toph.co/u/SnO_OwY", ""),
            new("VJudge", "S_n_O_w_Y", "", "https://vjudge.net/user/S_n_O_w_Y", ""),
        },
        CpSummary = "ICPC Dhaka Regional 2024 contestant, active on five online judges, " +
                    "with top finishes in university programming contests.",

        CpAchievements = new()
        {
            new("ICPC Dhaka Regional 2024",
                "Team IUBAT_Wrong_Answer",
                "https://icpc.global/regionals/finder/Dhaka-2025/standings"),
            new("IUBAT CSE Battle of Intellects — Summer 2026",
                "Ranked 16 / 120",
                "https://toph.co/contests/training/7wf7nwl/standings?start=0"),
            new("IUBAT Monthly Programming Contest — April 2026",
                "Ranked 10 / 50",
                "https://codeforces.com/gym/688709/standings"),
        },

        Skills = new()
        {
            new("Languages", new[] { "C#", "C++", "JavaScript", "SQL", "Python" }),
            new("Web & Frameworks", new[] { "ASP.NET Core MVC", ".NET 9", "SignalR", "HTML5", "CSS3", "REST APIs" }),
            new("AI & Integrations", new[] { "Google Gemini API", "Machine Learning", "Payment Integration", "Email Automation" }),
            new("Tools & Practices", new[] { "Git & GitHub", "Clean Architecture", "MVC Pattern" }),
            new("CS Fundamentals", new[] { "Data Structures", "Algorithms", "OOP", "Problem Solving" }),
        },

        Projects = new()
        {
            new("HireNest — Smart Internship Management Platform",
                "A full-stack ASP.NET Core MVC application that streamlines the internship lifecycle: " +
                "intelligent skill-based matching, application tracking, CV management, freemium payment " +
                "integration, automated email notifications, and an AI-powered assistant using the Google Gemini API.",
                new[] { "ASP.NET Core MVC", "C#", "Google Gemini API", "Payments", "Email Automation" },
                null, "https://github.com/Meem-001/HireNest"),
            new("SafeCity — AI-Powered Public Safety Platform (MVP)",
                "A hackathon-driven collaborative civic-tech MVP for real-time public safety reporting and " +
                "location-based civic information, built with ASP.NET Core 9.0, Clean Architecture and SignalR, " +
                "with AI integration using the Google Gemini API.",
                new[] { "ASP.NET Core 9.0", "Clean Architecture", "SignalR", "Google Gemini API" },
                null, "https://github.com/tabassumnazifa/lavendar_logic"),
        },

        Research = new()
        {
            new("Predicting the Thermal Comfort of Non-Academic Workers at University: A Machine Learning-Based Approach",
                "NOUS 2026 — International Conference (ACM Proceedings)",
                "Published",
                "https://doi.org/10.1145/3793828.3793840",
                "Conference publication applying machine learning to predict the thermal comfort of " +
                "non-academic workers at university. DOI: 10.1145/3793828.3793840"),
        },

        Activities = new()
        {
            new("Hult Prize Campus Round 2025–2026",
                "1st Runner-up",
                "2025 — 2026",
                "Secured 1st Runner-up at the campus round of the Hult Prize, the world's largest " +
                "student social entrepreneurship competition."),
            new("SympSIST 2025 — IEEE IUBAT Student Branch",
                "Organizer",
                "2025",
                "Organized the International Symposium on Social Implication of Sustainable Technology " +
                "(SympSIST 2025), hosted by the IEEE IUBAT Student Branch."),
        },

        Contacts = new()
        {
            new("Email", "meemhalima02@gmail.com", "mailto:meemhalima02@gmail.com", "mail"),
            new("GitHub", "github.com/Meem-001", "https://github.com/Meem-001", "github"),
            new("LinkedIn", "linkedin.com/in/halima-khatun-meem", "https://www.linkedin.com/in/halima-khatun-meem/", "linkedin"),
        },
    };
}
