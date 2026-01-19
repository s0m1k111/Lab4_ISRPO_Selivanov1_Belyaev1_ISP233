Console.WriteLine("Приветствую вас.");
string? fio = "Селиванов П.А. Беляев В.А.";
string? group = "ИСП-233";
string? time = DateTime.Now;
int peak = Console.Write(Console.ReadLine());
switch (peak)
{
    case 1:
        Console.WriteLine(fio); break;
    case 2:
        Console.WriteLine(group); break;
    case 3:
        Console.WriteLine(time); break;
    case 4:; break;
}