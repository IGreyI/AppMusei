using System.Net.Http.Json;
using System.Text.Json;

namespace AppMusei
{
    public class Museo
    {
        public string Id { get; set; } = "";
        public string Nome { get; set; } = "";
        public string Descrizione { get; set; } = "";
        public string ImmagineUrl { get; set; } = "";
        public Valutazione[]? Valutazioni { get; set; }

        public Museo() { }
    }
}
