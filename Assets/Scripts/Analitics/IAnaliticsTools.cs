public interface IAnaliticsTools
{
    void SendMessage(string nameEvent);
    void SendMessage(string nameEvent, (string, object) data);
}
