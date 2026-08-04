// Smooth Scrolling Script
document.querySelectorAll('a[href^="#"]').forEach(anchor => {
    anchor.addEventListener('click', function (e) {
        e.preventDefault();
        document.querySelector(this.getAttribute('href')).scrollIntoView({
            behavior: 'smooth'
        });
    });
});

// Mobile Menu Toggle Script
const menuBtn = document.getElementById('mobile-menu-btn');
const navLinks = document.getElementById('nav-links');
const navItems = navLinks.querySelectorAll('a');

// Open/Close menu when clicking the hamburger icon
menuBtn.addEventListener('click', () => {
    navLinks.classList.toggle('active');
});

// Automatically close the menu when a link is clicked
navItems.forEach(item => {
    item.addEventListener('click', () => {
        navLinks.classList.remove('active');
    });
});