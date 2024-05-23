namespace Segundo_Parcial
{
    public class Revista:Libro
    {
        public string Volumen {  get; set; }
        public string NoEjemplar { get; set; }

        public Revista()
        {
            Volumen= string.Empty;
            NoEjemplar= string.Empty;
        }
    }
}
