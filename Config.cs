namespace ConfManager
{
    public class Config
    {
        public string Id;
        public string Value;
        public int Layer;
        public Config(string id, string value, int layer = 0) {
            this.Id = id;
            this.Value = value;
            this.Layer = layer;
        }
    }
}
