namespace SpecGenerator;

internal class MenuItem : ListBox
{
    public string ItemName { get; set; } = string.Empty;
    public List<MenuItem> ChildItems { get; set; } = new List<MenuItem>();
}
