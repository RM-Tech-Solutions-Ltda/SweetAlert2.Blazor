namespace SweetAlert2.Blazor.Models;

/// <summary>
/// Representa a resposta de um alerta do SweetAlert2.
/// Esta classe encapsula os diferentes estados de resposta possíveis que um usuário pode fornecer a um alerta.
/// </summary>
public class SweetAlert2Return
{
    /// <summary>
    /// Indica se o alerta foi confirmado pelo usuário.
    /// Geralmente é utilizado quando o usuário clica em um botão de confirmação (exemplo: "OK" ou "Sim").
    /// </summary>
    public bool IsConfirmed { get; set; }

    /// <summary>
    /// Indica se o alerta foi negado pelo usuário.
    /// Geralmente é utilizado quando o usuário clica em um botão de negação (exemplo: "Cancelar" ou "Não").
    /// </summary>
    public bool IsDenied { get; set; }

    /// <summary>
    /// Indica se o alerta foi descartado (fechado) pelo usuário sem tomar uma ação explícita.
    /// Pode ocorrer, por exemplo, quando o usuário clica fora do alerta ou pressiona a tecla "Esc".
    /// </summary>
    public bool IsDismissed { get; set; }
}
