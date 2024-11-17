namespace MauiAppEventos.Model
{
    internal class Cadastro
    {

      public  string NomeEvento { get; set; }
      public DateTime DataInicio {  get; set; }
      public DateTime DataTermino {  get; set; }
      public int NumeroParticipantes {  get; set; }
      public  string LocalEvento {  get; set; }
      public decimal CustoPorParticipante {  get; set; }

    }
}
