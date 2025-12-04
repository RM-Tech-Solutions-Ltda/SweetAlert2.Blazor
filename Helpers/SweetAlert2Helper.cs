using SweetAlert2.Blazor.Models;

namespace SweetAlert2.Blazor.Helpers;

/// <summary>
/// Classe utilitária que fornece métodos estáticos para criar alertas personalizados utilizando o SweetAlert2.
/// Facilita a criação de alertas com diferentes tipos de ícones, como sucesso, erro, aviso, e confirmação.
/// </summary>
public static class SweetAlert2Helper
{
    /// <summary>
    /// Método privado que cria um alerta SweetAlert2 básico, utilizando o título, texto e ícone fornecidos.
    /// Este método é usado internamente para evitar repetição de código na criação de alertas.
    /// </summary>
    /// <param name="titulo">Título do alerta.</param>
    /// <param name="texto">Texto do alerta.</param>
    /// <param name="icone">Ícone do alerta (como 'success', 'error', 'warning', 'info').</param>
    /// <returns>Uma instância de SweetAlert2 com as opções fornecidas.</returns>
    private static SweetAlert2Model CreateAlert(string titulo, string texto, string icone)
        => new(new SweetAlert2Options(titulo, texto, icone, "Ok", null));

    /// <summary>
    /// Cria um alerta SweetAlert2 a partir das opções fornecidas.
    /// Este método facilita a criação de alertas com base em um conjunto centralizado de opções.
    /// </summary>
    /// <param name="options">Objeto contendo as opções de configuração do alerta, como título, texto, ícone e botões.</param>
    /// <returns>Uma instância do tipo SweetAlert2, configurada conforme as opções fornecidas.</returns>
    public static SweetAlert2Model CreateAlert(SweetAlert2Options options)
        => new(options);

    /// <summary>
    /// Cria um alerta de sucesso.
    /// O ícone de sucesso é exibido junto com um botão de confirmação ("Ok").
    /// </summary>
    /// <param name="titulo">Título do alerta.</param>
    /// <param name="texto">Texto do alerta.</param>
    /// <returns>Uma instância de SweetAlert2 configurada para mostrar um alerta de sucesso.</returns>
    public static SweetAlert2Model CreateSuccessAlert(string titulo, string texto)
        => CreateAlert(titulo, texto, ESweetAlert2Icone.SUCCESS);

    /// <summary>
    /// Cria um alerta informativo.
    /// O ícone de informação é exibido junto com um botão de confirmação ("Ok").
    /// </summary>
    /// <param name="titulo">Título do alerta.</param>
    /// <param name="texto">Texto do alerta.</param>
    /// <returns>Uma instância de SweetAlert2 configurada para mostrar um alerta informativo.</returns>
    public static SweetAlert2Model CreateInfoAlert(string titulo, string texto)
        => CreateAlert(titulo, texto, ESweetAlert2Icone.INFO);

    /// <summary>
    /// Cria um alerta de confirmação.
    /// O ícone de pergunta (question) é exibido junto com um botão de confirmação ("Ok").
    /// </summary>
    /// <param name="titulo">Título do alerta.</param>
    /// <param name="texto">Texto do alerta.</param>
    /// <returns>Uma instância de SweetAlert2 configurada para mostrar um alerta de confirmação.</returns>
    public static SweetAlert2Model CreateConfirmAlert(string titulo, string texto)
        => CreateAlert(titulo, texto, ESweetAlert2Icone.QUESTION);

    /// <summary>
    /// Cria um alerta de confirmação com opções "Sim" e "Não".
    /// O ícone de pergunta (question) é exibido junto com os botões "Sim" e "Não".
    /// </summary>
    /// <param name="titulo">Título do alerta.</param>
    /// <param name="texto">Texto do alerta.</param>
    /// <returns>Uma instância de SweetAlert2 configurada para mostrar um alerta de confirmação com os botões "Sim" e "Não".</returns>
    public static SweetAlert2Model CreateConfirmYNAlert(string titulo, string texto)
        => new(new SweetAlert2Options(titulo, texto, ESweetAlert2Icone.QUESTION, "Sim", "Não"));

    /// <summary>
    /// Cria um alerta de aviso.
    /// O ícone de aviso é exibido junto com um botão de confirmação ("Ok").
    /// </summary>
    /// <param name="titulo">Título do alerta.</param>
    /// <param name="texto">Texto do alerta.</param>
    /// <returns>Uma instância de SweetAlert2 configurada para mostrar um alerta de aviso.</returns>
    public static SweetAlert2Model CreateWarningAlert(string titulo, string texto)
        => CreateAlert(titulo, texto, ESweetAlert2Icone.WARNING);

    /// <summary>
    /// Cria um alerta de erro.
    /// O ícone de erro é exibido junto com um botão de confirmação ("Ok").
    /// </summary>
    /// <param name="titulo">Título do alerta.</param>
    /// <param name="texto">Texto do alerta.</param>
    /// <returns>Uma instância de SweetAlert2 configurada para mostrar um alerta de erro.</returns>
    public static SweetAlert2Model CreateErrorAlert(string titulo, string texto)
        => CreateAlert(titulo, texto, ESweetAlert2Icone.ERROR);
}
