var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
List<PC> repo = [];

app.MapGet("/", () => "Hello World!");

app.Run();
List<PC> GetPC() => repo;
void CreatePC(PC pc)=> repo.Add(pc);
PC FindPC(int id)=> repo.Find(x => x.Id == id);
void UpdatePC(PC dto)




{
    foreach (var i in repo)
        if(i.Id == dto.Id)
        {
            if(i.Screen!= dto.Screen && dto.Screen != "")
                i.Screen = dto.Screen;
            if(i.Keyboard!= dto.Keyboard && dto.Keyboard != "")
                i.Keyboard = dto.Keyboard;
            if(i.Mouse!= dto.Mouse && dto.Mouse != "")
                i.Mouse = dto.Mouse;
            if(i.Processor!= dto.Processor && dto.Processor != "")
                i.Processor = dto.Processor;
            if(i.VideoCard!= dto.VideoCard && dto.VideoCard != "")
                i.VideoCard = dto.VideoCard;
        }
}
void DeletePC(int id)=> repo.Remove(FindPC(id));
class PC{
    public int Id{get; set;}
    public string Screen{get; set;}
    public string Keyboard{get; set;}
    public string Mouse{get; set;}
    public string Processor{get;set;}
    public string VideoCard{get; set;}
}