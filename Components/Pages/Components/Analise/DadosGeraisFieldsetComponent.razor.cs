using Microsoft.AspNetCore.Components;

namespace Front.Components.Pages.Components.Analise;

public partial class DadosGeraisFieldsetComponent : ComponentBase
{
    private DadosCredito dados = new DadosCredito();

    private List<string> maquinario = new()
    {
        "Sim, totalmente",
        "Sim, parcialmente",
        "Não possui"
    };

    private List<string> grau = new()
    {
        "Alto",
        "Médio",
        "Baixo"
    };

    private List<string> conceitos = new()
    {
        "Excelente",
        "Bom",
        "Regular",
        "Ruim"
    };

    private List<string> indivGrupoFam = new()
    {
        "Individual",
        "Grupo Familiar"
    };

    private List<string> simNao = new()
    {
        "Sim",
        "Não"
    };

    List<string> finalidadeAnalise = new List<string>
    {
        "Custeio Bancario",
        "Renegociacao Dividas",
        "Analise Complementar",
        "Analise Com Insumos Entregues",
        "Adto Destino Credi",
        "Lar Credi X Brde X Lar",
        "Vendas De Insumos",
        "Adiantamento",
        "Limite De Credito Mensal",
        "Maquinas Agricolas",
        "Convenio Lar Credi X Safra"
    };

    public class DadosCredito
    {
        public string Cliente { get; set; }
        public string TipoCliente { get; set; }
        public string EstadoCivil { get; set; }
        public string RegimeCasamento { get; set; }
        public int? ExperienciaAgricultura { get; set; }
        public bool MaquinarioProprio { get; set; }
        public int? GrauTecnificacao { get; set; }
        public double? DistanciaUnidade { get; set; }
        public double? PercentualTravaCustos { get; set; }
        public string ConceitoComunidade { get; set; }
        public string ConceitoComercial { get; set; }
        public double? ValorSolicitado { get; set; }
    }

    void Submit(DadosCredito arg)
    {
        //
    }

    void Cancel()
    {
        //
    }
}