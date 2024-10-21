namespace MessageHandlerDataAccess
{
    public record Body : ICustomData
    {
        public string Content => $"<content property1=\"{Property1}\" property2=\"{Property2}\" property=\"{Property3}\" ></content>";
        public string? Property1 { get; set; }
        public string? Property2 { get; set; }
        public string? Property3 { get; set; }
    }
}
