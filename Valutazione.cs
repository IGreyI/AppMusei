namespace AppMusei
{
    public enum Quality
    {
        ASSENTE = 0,
        SCARSO = 1,
        SUFFICIENTE = 2,
        OTTIMO = 3
    }

    public class Valutazione
    {
        public double PunteggioGenerale { get; set; }
        public bool PostPNRR { get; set; }

        // N ingressi accessibili || Numero
        public int Ningressi { get; set; }

        // Segnaletica in Braille - pittogrammi || %
        public int SegnaleticaBraille { get; set; }

        // % spazi accessibile da tutti || % 
        public int PercSpazi { get; set; }

        // Canali digitali/assistenza disponibili || 0-3
        public Quality CanaliDig { get; set; }

        //Superficie spazi dedicati ad altre attività || %
        public int SpaziAtt { get; set; }

        // N lingue supportate in audio e pannelli || Numero
        public int Nlingue { get; set; }

        // Presenza mappa || Si/No
        public bool Mappa { get; set; }

        // App fruibile con screen reader / UX semplificata || Si/No
        public bool AppScreenReader { get; set; }

        // Segnaletica sonora/tattile || 0-3
        public Quality SegnaleticaSonora { get; set; }

        // Presenza di audiodescrizione/sottotitoli/LIS || 0-3
        public Quality Audiodescrizione { get; set; }

        // N ore di formazione del personale all'anno || Numero stringa
        public string FormazionePersonale { get; set; }

        // Disponibilità uscite d'emergenza accessibili || %
        public int UsciteEmergenza { get; set; }

        // Distribuzione delle sedute || %
        public int DistrSedute { get; set; }

        // N bagni accessibili || Numero
        public int NBagni { get; set; }

        // Larghezza percorsi dimensione media || metri
        public double LarghezzaPercorsi { get; set; }

        // % aree visitabili senza ostacoli o con chiara segnalazione || %
        public int AreeVisitabili { get; set; }

        // Piano di emergenza che contempli i diversamente abili || Si/No
        public bool PianoEmergenza { get; set; }


        public Valutazione() { }
    }
}
