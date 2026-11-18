// ============================================================
// Portfolio interactions (vanilla JavaScript — no libraries)
// 1. Mobile hamburger menu
// 2. Sticky header shadow on scroll
// 3. Scrollspy — highlights the nav link of the visible section
// 4. Reveal-on-scroll animations
// 5. Auto-updating footer year
// ============================================================

document.addEventListener("DOMContentLoaded", () => {
    // ----- 1. Mobile menu -----
    const toggle = document.getElementById("navToggle");
    const menu = document.getElementById("navMenu");

    const closeMenu = () => {
        menu.classList.remove("open");
        toggle.setAttribute("aria-expanded", "false");
    };

    toggle.addEventListener("click", () => {
        const open = menu.classList.toggle("open");
        toggle.setAttribute("aria-expanded", String(open));
    });

    // Close the menu after choosing a section, or when tapping outside
    menu.querySelectorAll("a").forEach(a => a.addEventListener("click", closeMenu));
    document.addEventListener("click", e => {
        if (!menu.contains(e.target) && !toggle.contains(e.target)) closeMenu();
    });
    document.addEventListener("keydown", e => { if (e.key === "Escape") closeMenu(); });

    // ----- 2. Header shadow -----
    const header = document.getElementById("siteHeader");
    const onScroll = () => header.classList.toggle("scrolled", window.scrollY > 8);
    onScroll();
    window.addEventListener("scroll", onScroll, { passive: true });

    // ----- 3. Scrollspy -----
    const links = [...document.querySelectorAll(".nav-link")];
    const sections = links
        .map(l => document.querySelector(l.getAttribute("href")))
        .filter(Boolean);

    const spy = new IntersectionObserver(entries => {
        entries.forEach(entry => {
            if (!entry.isIntersecting) return;
            links.forEach(l =>
                l.classList.toggle("active", l.getAttribute("href") === "#" + entry.target.id));
        });
    }, { rootMargin: "-40% 0px -55% 0px" });

    sections.forEach(s => spy.observe(s));

    // ----- 4. Reveal on scroll -----
    const revealer = new IntersectionObserver(entries => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.classList.add("visible");
                revealer.unobserve(entry.target); // animate once
            }
        });
    }, { threshold: 0.12 });

    document.querySelectorAll(".reveal").forEach(el => revealer.observe(el));

    // ----- 5. Footer year -----
    document.getElementById("year").textContent = new Date().getFullYear();
});
