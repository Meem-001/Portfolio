# ============================================================
# Exports the running ASP.NET Core MVC site to static files
# in ./docs — ready for GitHub Pages.  (Windows / PowerShell)
#
# Usage:  1) run the site:   dotnet run
#         2) then:           powershell -ExecutionPolicy Bypass -File export-static.ps1
# ============================================================
param([string]$Url = "http://localhost:5000/")
$ErrorActionPreference = "Stop"
Set-Location $PSScriptRoot

New-Item -ItemType Directory -Force -Path docs | Out-Null

# Fetch the rendered page; make asset paths relative so it works
# under https://<user>.github.io/<repo>/ and strip cache-busting versions.
$html = (Invoke-WebRequest -Uri $Url -UseBasicParsing).Content
$html = $html -replace '(href|src)="/(css|js)/', '$1="$2/'
$html = $html -replace '\?v=[A-Za-z0-9_-]+', ''
Set-Content -Path docs/index.html -Value $html -Encoding UTF8

Copy-Item -Recurse -Force wwwroot/css docs/
Copy-Item -Recurse -Force wwwroot/js  docs/
New-Item -ItemType File -Force -Path docs/.nojekyll | Out-Null

Write-Host "Static site exported to ./docs - push to GitHub and enable Pages." -ForegroundColor Green
