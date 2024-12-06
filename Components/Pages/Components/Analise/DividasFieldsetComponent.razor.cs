using Microsoft.AspNetCore.Components;

namespace Front.Components.Pages.Components.Analise;

public partial class DividasFieldsetComponent : ComponentBase
{
    // Classe que representa cada linha da tabela
    public class Vencimento
    {
        public string Descricao { get; set; }
        public decimal? Lar { get; set; }
        public decimal? Terceiros { get; set; }
        public decimal? Bancos { get; set; }
        public decimal DividasTotais => (Lar ?? 0) + (Terceiros ?? 0) + (Bancos ?? 0);
    }

    // Dados para a tabela
    private List<Vencimento> vencimentos = new()
    {
        new Vencimento { Descricao = "Vencidos", Lar = null, Terceiros = null, Bancos = null },
        new Vencimento { Descricao = "A vencer 1 ano", Lar = null, Terceiros = null, Bancos = null },
        new Vencimento { Descricao = "A vencer 2 anos", Lar = null, Terceiros = null, Bancos = null },
        new Vencimento { Descricao = "A vencer 3 anos", Lar = null, Terceiros = null, Bancos = null },
        new Vencimento { Descricao = "A vencer 4 anos", Lar = null, Terceiros = null, Bancos = null },
        new Vencimento { Descricao = "A vencer > 4 anos", Lar = null, Terceiros = null, Bancos = null },
        new Vencimento { Descricao = "Total", Lar = null, Terceiros = null, Bancos = null }
    };

    private void OnRowUpdate(Vencimento vencimento)
    {
        // Atualiza os valores calculados, se necessário
        StateHasChanged();
    }

    private List<string> simNao = new()
    {
        "Sim",
        "Não"
    };

    private List<string> renegociacaoVencerAnterior = new()
    {
        "Não",
        "Sim, pago em dia",
        "Sim, pago em atraso"
    };

    private List<string> restricaoSerasaAgrisk = new()
    {
        "Sem restrições",
        "Com restrições relevantes",
        "Com restrições irrelevantes"
    };
}