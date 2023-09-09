int[] grades = new int[365];
List<string> dayOfWeeks = new List<string>();
dayOfWeeks.Add("poniedziałek");
dayOfWeeks.Add("wtorek");
dayOfWeeks.Add("środa");
dayOfWeeks.Add("czwartek");
dayOfWeeks.Add("piątek");
dayOfWeeks.Add("sobota");
dayOfWeeks.Add("niedziela");


for (var i=0; i<dayOfWeeks.Count ;i++)
{
    Console.WriteLine(dayOfWeeks[i]);
}

