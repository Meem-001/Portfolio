#!/usr/bin/env bash
# ============================================================
# Exports the running ASP.NET Core MVC site to static files
# in ./docs — ready for GitHub Pages (Settings → Pages →
# Deploy from branch → main /docs).
#
# Usage:  1) run the site:  dotnet run
#         2) then:          bash export-static.sh
# ============================================================
set -euo pipefail
cd "$(dirname "$0")"

URL="${1:-http://localhost:5000/}"

mkdir -p docs
# Fetch the rendered page; make asset paths relative so it works
# under https://<user>.github.io/<repo>/ and strip cache-busting versions.
curl -sf "$URL" \
  | sed -E 's#(href|src)="/(css|js)/#\1="\2/#g; s#\?v=[A-Za-z0-9_-]+##g' \
  > docs/index.html

cp -r wwwroot/css wwwroot/js docs/
touch docs/.nojekyll   # tell GitHub Pages to serve files as-is

echo "✔ Static site exported to ./docs — push to GitHub and enable Pages."
