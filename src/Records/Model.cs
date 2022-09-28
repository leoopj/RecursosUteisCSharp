public record Documento
{
	public long Numero { get; init; }
}

public record RG : Documento
{
	public long Numero { get; init; }
	public string OrgaoExpeditor { get; init; }
}

public record PrevisaoTempo
{
    public decimal Temperatura { get; init; }
    public decimal Umidade { get; init; }

    public PrevisaoTempo(decimal temperatura, decimal umidade) =>
        (Temperatura, Umidade) = (temperatura, umidade);

    public void Deconstruct(out decimal temperatura, out decimal umidade) =>
        (temperatura, umidade) = (Temperatura, Umidade);
}