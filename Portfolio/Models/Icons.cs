namespace Portfolio.Models;

// Small inline SVG icon set (feather-style, stroke = currentColor)
public static class Icons
{
    public static string Get(string name) => name switch
    {
        "mail" => Svg("<rect x='2' y='4' width='20' height='16' rx='2'/><path d='m22 7-10 6L2 7'/>"),
        "github" => Svg("<path d='M9 19c-5 1.5-5-2.5-7-3m14 6v-3.87a3.37 3.37 0 0 0-.94-2.61c3.14-.35 6.44-1.54 6.44-7A5.44 5.44 0 0 0 20 4.77 5.07 5.07 0 0 0 19.91 1S18.73.65 16 2.48a13.38 13.38 0 0 0-7 0C6.27.65 5.09 1 5.09 1A5.07 5.07 0 0 0 5 4.77a5.44 5.44 0 0 0-1.5 3.78c0 5.42 3.3 6.61 6.44 7A3.37 3.37 0 0 0 9 18.13V22'/>"),
        "linkedin" => Svg("<path d='M16 8a6 6 0 0 1 6 6v7h-4v-7a2 2 0 0 0-4 0v7h-4V8h4v2a6 6 0 0 1 2-2z'/><rect x='2' y='9' width='4' height='12'/><circle cx='4' cy='4' r='2'/>"),
        "external" => Svg("<path d='M18 13v6a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V8a2 2 0 0 1 2-2h6'/><path d='M15 3h6v6'/><path d='M10 14 21 3'/>"),
        "code" => Svg("<path d='m16 18 6-6-6-6'/><path d='m8 6-6 6 6 6'/>"),
        "trophy" => Svg("<path d='M6 9a6 6 0 0 0 12 0V3H6z'/><path d='M6 5H3v2a4 4 0 0 0 4 4'/><path d='M18 5h3v2a4 4 0 0 1-4 4'/><path d='M12 15v3'/><path d='M8 21h8'/><path d='M10 18h4v3h-4z'/>"),
        "cap" => Svg("<path d='m22 9-10-5L2 9l10 5 10-5z'/><path d='M6 11.5V16c0 1.5 2.7 3 6 3s6-1.5 6-3v-4.5'/><path d='M22 9v6'/>"),
        "flask" => Svg("<path d='M10 2v6L4.5 18a2 2 0 0 0 1.8 3h11.4a2 2 0 0 0 1.8-3L14 8V2'/><path d='M8.5 2h7'/><path d='M7 15h10'/>"),
        "star" => Svg("<path d='m12 2 3.09 6.26L22 9.27l-5 4.87 1.18 6.88L12 17.77l-6.18 3.25L7 14.14 2 9.27l6.91-1.01L12 2z'/>"),
        "pin" => Svg("<path d='M20 10c0 6-8 12-8 12s-8-6-8-12a8 8 0 0 1 16 0z'/><circle cx='12' cy='10' r='3'/>"),
        "file" => Svg("<path d='M14 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V8z'/><path d='M14 2v6h6'/>"),
        _ => Svg("<circle cx='12' cy='12' r='10'/>")
    };

    private static string Svg(string inner) =>
        $"<svg class='icon' viewBox='0 0 24 24' fill='none' stroke='currentColor' stroke-width='1.8' stroke-linecap='round' stroke-linejoin='round' aria-hidden='true'>{inner}</svg>";
}
