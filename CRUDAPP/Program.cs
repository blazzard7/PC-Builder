var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
List<PC> repo = [];

app.MapGet("/", () => "Hello World!");

app.Run();

class PC{
    public int Id{get; set;}
    public string Screen{get; set;}
    public string Keyboard{get; set;}
    public string Mouse{get; set;}
    public string Processor{get;set;}
    public string VideoCard{get; set;}
}