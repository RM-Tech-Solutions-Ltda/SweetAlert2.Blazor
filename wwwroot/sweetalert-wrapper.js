export function sweetAlert(options) {
    return Swal.fire({
        title: options.titulo,
        text: options.texto,
        icon: options.icone,
        showConfirmButton: options.mostrarBotaoConfirmar,
        showCancelButton: options.mostrarBotaoCancelar,
        showCloseButton: options.mostrarBotaoFechar,
        confirmButtonText: options.textoDoBotaoConfirmar,
        cancelButtonText: options.textoDoBotaoCancelar,
        footer: options.rodape,
        allowOutsideClick: options.permitirClicarFora,
    });
}
