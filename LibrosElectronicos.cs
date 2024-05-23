namespace Segundo_Parcial
{
    public class LibrosElectronicos:Libro
    {
        public string Formato {  get; set; }
        public int TamañoArchivo { get; set; }

        public LibrosElectronicos()
        {
            Formato = string.Empty;
            TamañoArchivo = 0;
        }
    }
}
