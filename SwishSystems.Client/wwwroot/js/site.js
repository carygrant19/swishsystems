// function showPage(pageId) {
//     const pages = document.querySelectorAll('.page-content');
//     pages.forEach(page => page.classList.remove('active-page'));

//     const navLinks = document.querySelectorAll('.nav-link');
//     navLinks.forEach(link => link.classList.remove('active'));

//     const targetPage = document.getElementById(pageId);
//     if (targetPage) {
//         targetPage.classList.add('active-page');
//     }

//     if (event && event.currentTarget && event.currentTarget.classList && event.currentTarget.classList.contains('nav-link')) {
//         event.currentTarget.classList.add('active');
//     } else {
//         const correspondingNavLink = document.querySelector(`.nav-link[onclick="showPage('${pageId}')"]`);
//          if (correspondingNavLink) {
//             correspondingNavLink.classList.add('active');
//         }
//     }

    
// }

function goToSeasons() {
    showPage('seasons');
}

function toggleTheme() {
    const body = document.body;
    const themeBtn = document.getElementById('theme-toggle');

    body.classList.toggle('light-mode');

    if (body.classList.contains('light-mode')) {
        themeBtn.innerHTML = '🌙 Dark';
    } else {
        themeBtn.innerHTML = '☀️ Light';
    }
}