namespace AppMusei
{
    public static class MuseiData
    {
        public static List<Museo> Elenco { get; set; } = [];

        public static Museo? GetById(string id) => Elenco.FirstOrDefault(m => m.Id == id);
    }
}
