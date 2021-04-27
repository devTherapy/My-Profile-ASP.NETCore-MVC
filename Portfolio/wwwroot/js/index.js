class UI {
    addEventListeners() {
        const navBtn = select(".nav-btn");
        const navBar = select(".navbar");
        const overlay = select(".overlay");
        navBtn.addEventListener("click", (e) => {
            navBar.classList.toggle("open");
            overlay.classList.toggle("show");
            console.log("yeah");
        })
    }
}
function init() {
    const ui = new UI();
    ui.addEventListeners();
}
function select(s) {
    return document.querySelector(s);
}

document.addEventListener('DOMContentLoaded', init);