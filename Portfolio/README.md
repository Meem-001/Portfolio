# Portfolio — ASP.NET Core MVC

A responsive, single-page portfolio (light & minimal theme) built with
**ASP.NET Core MVC**, hand-written **HTML/CSS**, and **vanilla JavaScript**.
Sections: Education · Competitive Programming · Skills · Projects · Research ·
Co-curricular Activities · Contact.

## Project structure

```
Portfolio/
├── Program.cs                  # App entry: registers MVC, static files, routing
├── Controllers/
│   └── HomeController.cs       # GET / → renders the single page
├── Models/
│   ├── PortfolioData.cs        # ★ ALL CONTENT lives here — edit this file
│   └── Icons.cs                # Inline SVG icon set
├── Views/
│   ├── Shared/_Layout.cshtml   # Navbar, footer, <head>
│   └── Home/Index.cshtml       # All page sections (Razor)
├── wwwroot/
│   ├── css/site.css            # Theme + responsive styles
│   └── js/site.js              # Menu, scrollspy, reveal animations
├── export-static.sh            # Exports rendered site → ./docs for GitHub Pages
└── docs/                       # Static build served by GitHub Pages
```

## Run locally

```bash
dotnet run          # requires .NET 8 SDK → http://localhost:5000
```

Windows (PowerShell):

```powershell
dotnet run          # then open http://localhost:5000 in your browser
```

## Edit content

Everything (name, education, CP handles, skills, projects, research,
activities, contact links) is in **`Models/PortfolioData.cs`**.
Change a value, refresh the page — done.

## Deploy to GitHub Pages

GitHub Pages hosts static files only, so we export the rendered MVC page:

```bash
dotnet run &                # 1. start the site
bash export-static.sh       # 2. export → ./docs (index.html + css + js)
```

Windows (PowerShell, while `dotnet run` is running in another terminal):

```powershell
powershell -ExecutionPolicy Bypass -File export-static.ps1
```

Then:

```bash
git init && git add -A && git commit -m "Portfolio"
git remote add origin https://github.com/<username>/<repo>.git
git push -u origin main
```

On GitHub: **Settings → Pages → Build and deployment → Deploy from a branch →
`main` / `docs`** → Save.

Your live URL will be `https://<username>.github.io/<repo>/` — add it to your
LinkedIn (Featured / Contact info), GitHub profile README, and email signature.

Re-run the export script and push whenever you change content:

```bash
# after editing Models/PortfolioData.cs, with dotnet run active:
bash export-static.sh                      # or the .ps1 on Windows
git add -A && git commit -m "Update content" && git push
```

GitHub Pages rebuilds automatically within ~1 minute.
