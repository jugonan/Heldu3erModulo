// Ocultar puntos del registro para clientes/vendedores
let botonComprador = document.getElementById("a-comprar");
let botonVendedor = document.getElementById("a-vender");
let puntosRegistroComprador = document.getElementById("registrousuario");
let puntosRegistroVendedor = document.getElementById("registrovendedor");

puntosRegistroComprador.setAttribute("class", "d-none");
puntosRegistroVendedor.setAttribute("class", "d-none");

botonComprador.addEventListener("click", function () {
    puntosRegistroComprador.classList.remove("d-none");
})

botonVendedor.addEventListener("click", function () {
    puntosRegistroVendedor.classList.remove("d-none");
})

