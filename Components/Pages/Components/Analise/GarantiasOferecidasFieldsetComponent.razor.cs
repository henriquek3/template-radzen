using Microsoft.AspNetCore.Components;

namespace Front.Components.Pages.Components.Analise;

public partial class GarantiasOferecidasFieldsetComponent : ComponentBase
{
    private List<string> simNao = new()
    {
        "Sim",
        "Não"
    };
    
    private DadosCredito dados = new DadosCredito();

    public class Garantia
    {
        public string TipoGarantia { get; set; }
        public bool Penhoravel { get; set; }
        public string Matricula { get; set; }
        public double? Area { get; set; }
        public int? AnoSafra { get; set; }
        public string Produto { get; set; }
        public string TipoSolo { get; set; }
        public DateTime? Vencimento { get; set; }
        public decimal? Valor { get; set; }
        public bool EstaOnerado { get; set; }
        public bool AnexouDocumento { get; set; }
    }

    // Dados para a tabela
    private List<Garantia> _garantias = new()
    {
        new Garantia
        {
            TipoGarantia = "Alienação Fiduciária", Penhoravel = true, Matricula = "12345", Area = 50.5, AnoSafra = 2024,
            Produto = "Soja", TipoSolo = "Argiloso", Vencimento = DateTime.Now.AddMonths(12), Valor = 100000,
            EstaOnerado = false, AnexouDocumento = true
        },
        new Garantia
        {
            TipoGarantia = "Aval", Penhoravel = false, Matricula = null, Area = null, AnoSafra = null, Produto = null,
            TipoSolo = null, Vencimento = null, Valor = 50000, EstaOnerado = false, AnexouDocumento = false
        },
        new Garantia
        {
            TipoGarantia = "CPRF com Hipoteca", Penhoravel = true, Matricula = "67890", Area = 30.2, AnoSafra = 2023,
            Produto = "Milho", TipoSolo = "Arenoso", Vencimento = DateTime.Now.AddMonths(8), Valor = 75000,
            EstaOnerado = true, AnexouDocumento = true
        },
        new Garantia
        {
            TipoGarantia = "CPRF com Penhor", Penhoravel = true, Matricula = "11223", Area = 20.0, AnoSafra = 2022,
            Produto = "Trigo", TipoSolo = "Argiloso", Vencimento = DateTime.Now.AddMonths(6), Valor = 50000,
            EstaOnerado = false, AnexouDocumento = true
        },
        new Garantia
        {
            TipoGarantia = "Hipoteca Rotativa", Penhoravel = true, Matricula = "44556", Area = 40.7, AnoSafra = 2021,
            Produto = "Cana-de-açúcar", TipoSolo = "Arenoso", Vencimento = DateTime.Now.AddMonths(24), Valor = 150000,
            EstaOnerado = false, AnexouDocumento = false
        },
        new Garantia
        {
            TipoGarantia = "NP", Penhoravel = false, Matricula = null, Area = null, AnoSafra = null, Produto = null,
            TipoSolo = null, Vencimento = null, Valor = 30000, EstaOnerado = false, AnexouDocumento = false
        },
        new Garantia
        {
            TipoGarantia = "NPR", Penhoravel = false, Matricula = null, Area = null, AnoSafra = null, Produto = null,
            TipoSolo = null, Vencimento = null, Valor = 40000, EstaOnerado = false, AnexouDocumento = true
        },
        new Garantia
        {
            TipoGarantia = "Produção em depósito na Lar", Penhoravel = true, Matricula = "99999", Area = 60.0,
            AnoSafra = 2025, Produto = "Soja", TipoSolo = "Argiloso", Vencimento = DateTime.Now.AddMonths(36),
            Valor = 200000, EstaOnerado = false, AnexouDocumento = true
        },
        new Garantia
        {
            TipoGarantia = "Reserva de domínio", Penhoravel = false, Matricula = null, Area = null, AnoSafra = null,
            Produto = null, TipoSolo = null, Vencimento = null, Valor = 0, EstaOnerado = false, AnexouDocumento = false
        },
        new Garantia
        {
            TipoGarantia = "Seguro Agrícola", Penhoravel = false, Matricula = null, Area = null, AnoSafra = null,
            Produto = null, TipoSolo = null, Vencimento = null, Valor = 10000, EstaOnerado = false,
            AnexouDocumento = true
        },
    };
}

internal class DadosCredito
{
}