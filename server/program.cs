Console.WriteLine("Приветствую вас.");
string? fio = "Селиванов П.А. Беляев В.А.";
string? group = "ИСП-233";
string time = DateTime.Now.ToString();
Console.Write("Введите число от 1 до 4: ");
string? input = Console.ReadLine();
int peak = Convert.ToInt32(input);
switch (peak)
{
    case 1:
        Console.WriteLine(fio); break;
    case 2:
        Console.WriteLine(group); break;
    case 3:
        Console.WriteLine(time); break;
    case 4: Console.WriteLine("Exit"); break;
}