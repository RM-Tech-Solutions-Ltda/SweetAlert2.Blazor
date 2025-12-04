namespace SweetAlert2.Blazor.Models;

/// <summary>
/// Classe que representa as opções de um alerta SweetAlert2. 
/// Oferece a configuração de título, texto, ícone, botões de confirmação/cancelamento, e outras opções de comportamento.
/// </summary>
public class SweetAlert2Model
{
    /// <summary>
    /// Construtor padrão que inicializa uma nova instância de um alerta SweetAlert2 sem configurações iniciais.
    /// </summary>
    public SweetAlert2Model() { }

    /// <summary>
    /// Construtor privado que cria uma instância de um alerta SweetAlert2 com título, texto e ícone fornecidos.
    /// Este construtor é utilizado internamente para inicializar os valores básicos de um alerta.
    /// </summary>
    /// <param name="titulo">Título do alerta.</param>
    /// <param name="texto">Texto do alerta.</param>
    /// <param name="icone">Ícone do alerta (ex: 'success', 'error', 'warning').</param>
    private SweetAlert2Model(string titulo, string texto, string icone)
    {
        Titulo = titulo;
        Texto = texto;
        Icone = icone;
    }

    /// <summary>
    /// Construtor que cria uma instância de SweetAlert2 usando as opções fornecidas através de um objeto SweetAlert2Options.
    /// Este construtor inicializa todos os campos da classe com base nas propriedades definidas em SweetAlert2Options.
    /// </summary>
    /// <param name="options">Objeto de opções contendo as configurações do alerta SweetAlert2.</param>
    public SweetAlert2Model(SweetAlert2Options options)
        : this(options.Titulo, options.Texto, options.Icone)
    {
        MostrarBotaoConfirmar = options.MostrarBotaoConfirmar;
        MostrarBotaoFechar = options.MostrarBotaoFechar;
        MostrarBotaoCancelar = options.MostrarBotaoCancelar;
        TextoDoBotaoConfirmar = options.TextoDoBotaoConfirmar;
        TextoDoBotaoCancelar = options.TextoDoBotaoCancelar;
        Rodape = options.Rodape;
        PermitirClicarFora = options.PermitirClicarFora;
    }

    /// <summary>
    /// Título do alerta.
    /// </summary>
    public string Titulo { get; set; } = string.Empty;

    /// <summary>
    /// Texto do alerta, fornecendo mais detalhes sobre a ação ou informação.
    /// </summary>
    public string Texto { get; set; } = string.Empty;

    /// <summary>
    /// Ícone do alerta. Este valor pode ser um dos ícones predefinidos do SweetAlert2: 
    /// 'success', 'error', 'warning', 'info', ou 'question'.
    /// </summary>
    public string Icone { get; set; } = string.Empty;

    /// <summary>
    /// Define se o botão de confirmação será exibido. 
    /// O botão de confirmação é exibido quando a propriedade de texto do botão de confirmação não é nula ou vazia.
    /// </summary>
    public bool MostrarBotaoConfirmar { get; set; } = false;

    /// <summary>
    /// Define se o botão de fechar (X) será exibido no alerta.
    /// </summary>
    public bool MostrarBotaoFechar { get; set; } = false;

    /// <summary>
    /// Define se o botão de cancelamento será exibido. 
    /// O botão de cancelamento é exibido quando a propriedade de texto do botão de cancelamento não é nula ou vazia.
    /// </summary>
    public bool MostrarBotaoCancelar { get; set; } = false;

    /// <summary>
    /// Texto do botão de confirmação. Caso não seja fornecido, o botão de confirmação não será exibido.
    /// </summary>
    public string? TextoDoBotaoConfirmar { get; set; } = null;

    /// <summary>
    /// Texto do botão de cancelamento. Caso não seja fornecido, o botão de cancelamento não será exibido.
    /// </summary>
    public string? TextoDoBotaoCancelar { get; set; } = null;

    /// <summary>
    /// Texto opcional para o rodapé do alerta. Pode ser usado para informações adicionais ou notas.
    /// </summary>
    public string? Rodape { get; set; } = null;

    /// <summary>
    /// Define se o alerta permite que o usuário feche o alerta clicando fora da caixa de alerta.
    /// O clique fora do alerta é permitido quando nenhum dos botões de confirmação ou cancelamento é fornecido.
    /// </summary>
    public bool PermitirClicarFora { get; set; } = true;
}
