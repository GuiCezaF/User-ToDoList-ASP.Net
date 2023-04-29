using System.ComponentModel;

namespace SistemaDeTarefas.Enums
{
    public enum StatusTarefa
    {
        [Description("A fazer")]
        AFaser = 1,

        [Description("Em Andamento")]
        EmAndamento = 2,

        [Description("Concluido")]
        Concluido = 3
    }
}