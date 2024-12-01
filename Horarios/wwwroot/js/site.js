// Añadir interacción al botón
document.querySelector("button").addEventListener("click", () => {
    alert("¡Consultando horarios!");
});

// Animación de cambio de color en el título
document.querySelector("h2").addEventListener("mouseover", (event) => {
    event.target.style.color = "#007bff";
    setTimeout(() => {
        event.target.style.color = "#444";
    }, 500);
});
