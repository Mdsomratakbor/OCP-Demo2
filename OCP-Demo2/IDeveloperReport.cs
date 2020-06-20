namespace OCP_Demo2
{
    public interface IDeveloperReport
    {
        double HourlyRate { get; set; }
        int ID { get; set; }
        string Level { get; set; }
        string Name { get; set; }
        string WorkingHours { get; set; }
    }
}