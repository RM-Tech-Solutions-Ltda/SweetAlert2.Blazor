using System.ComponentModel.DataAnnotations;

namespace SweetAlert2.Blazor.Models;

/// <summary>
/// Classe que representa as opções de configuração de um alerta SweetAlert2.
/// Permite personalizar o título, texto, ícone e os botões de confirmação e cancelamento.
/// </summary>
/// <remarks>
/// Construtor padrão que cria uma instância de opções de alerta com o título, texto e ícone fornecidos.
/// </remarks>
/// <param name="titulo">Título do alerta.</param>
/// <param name="texto">Texto do alerta.</param>
/// <param name="icone">Ícone do alerta (ex: 'success', 'error', 'warning').</param>
public class SweetAlert2Options(string titulo, string texto, string icone)
{
    /// <summary>
    /// Construtor que cria uma instância de opções de alerta com título, texto, ícone e botões personalizados.
    /// </summary>
    /// <param name="titulo">Título do alerta.</param>
    /// <param name="texto">Texto do alerta.</param>
    /// <param name="icone">Ícone do alerta (ex: 'success', 'error', 'warning').</param>
    /// <param name="textoBotaoConfirmacao">Texto opcional do botão de confirmação. Se não for fornecido, o botão não será exibido.</param>
    /// <param name="textoBotaoCancelar">Texto opcional do botão de cancelamento. Se não for fornecido, o botão não será exibido.</param>
    /// <remarks>
    /// Se ambos os botões de confirmação e cancelamento não forem fornecidos, o clique fora do alerta será permitido para fechar o alerta.
    /// </remarks>
    public SweetAlert2Options(
            string titulo,
            string texto,
            string icone,
            string? textoBotaoConfirmacao,
            string? textoBotaoCancelar)
        : this(titulo, texto, icone)
    {
        MostrarBotaoConfirmar = !string.IsNullOrEmpty(textoBotaoConfirmacao);
        TextoDoBotaoConfirmar = textoBotaoConfirmacao;

        MostrarBotaoCancelar = !string.IsNullOrEmpty(textoBotaoCancelar);
        TextoDoBotaoCancelar = textoBotaoCancelar;

        // Permite clicar fora do alerta se nenhum dos botões for especificado
        PermitirClicarFora = string.IsNullOrEmpty(textoBotaoConfirmacao) || string.IsNullOrEmpty(textoBotaoCancelar);
    }

    /// <summary>
    /// Título do alerta.
    /// </summary>
    [Required]
    public string Titulo { get; set; } = titulo;

    /// <summary>
    /// Texto do alerta, fornecendo mais detalhes sobre a ação ou informação.
    /// </summary>
    [Required]
    public string Texto { get; set; } = texto;

    /// <summary>
    /// Ícone do alerta. Este valor pode ser um dos ícones predefinidos do SweetAlert2: 
    /// 'success', 'error', 'warning', 'info', ou 'question'.
    /// </summary>
    [Required]
    public string Icone { get; set; } = icone;

    /// <summary>
    /// Define se o botão de confirmação será exibido. 
    /// O botão de confirmação é exibido quando a propriedade de texto do botão de confirmação não é nula ou vazia.
    /// </summary>
    public bool MostrarBotaoConfirmar { get; set; }

    /// <summary>
    /// Define se o botão de fechar (X) será exibido no alerta.
    /// </summary>
    public bool MostrarBotaoFechar { get; set; } = false;

    /// <summary>
    /// Define se o botão de cancelamento será exibido. 
    /// O botão de cancelamento é exibido quando a propriedade de texto do botão de cancelamento não é nula ou vazia.
    /// </summary>
    public bool MostrarBotaoCancelar { get; set; }

    /// <summary>
    /// Texto do botão de confirmação. Caso não seja fornecido, o botão de confirmação não será exibido.
    /// </summary>
    public string? TextoDoBotaoConfirmar { get; set; }

    /// <summary>
    /// Texto do botão de cancelamento. Caso não seja fornecido, o botão de cancelamento não será exibido.
    /// </summary>
    public string? TextoDoBotaoCancelar { get; set; }

    /// <summary>
    /// Texto opcional para o rodapé do alerta. Pode ser usado para informações adicionais ou notas.
    /// </summary>
    public string? Rodape { get; set; }

    /// <summary>
    /// Define se o alerta permite que o usuário feche o alerta clicando fora da caixa de alerta.
    /// O clique fora do alerta é permitido quando nenhum dos botões de confirmação ou cancelamento é fornecido.
    /// </summary>
    public bool PermitirClicarFora { get; set; } = true;
}
