//listy:
List<string> dayOfWeeks4 = new List<string>();
dayOfWeeks4.Add("poniedziałek");
dayOfWeeks4.Add("wtorek");
dayOfWeeks4.Add("środa");
dayOfWeeks4.Add("czwarterk");
dayOfWeeks4.Add("piątek");
dayOfWeeks4.Add("sobota");
dayOfWeeks4.Add("niedziela");
for (var i = 0; i < dayOfWeeks4.Count; i++)
{
    Console.WriteLine(dayOfWeeks4[i]);
}


//tablice
string[] mounth = new string[12];
mounth[0] = "styczeń";
mounth[1] = "luty";
mounth[2] = "marzec";
mounth[3] = "kwiecien";
mounth[4] = "maj";
mounth[5] = "czerwiec";
mounth[6] = "lipiec";
mounth[7] = "sierpien";
mounth[8] = "wrzesien";
mounth[9] = "pażdziernik";
mounth[10] = "listopad";
mounth[11] = "grudzień";

for (var i = 0; i < mounth.Length; i++)
{
    Console.WriteLine(mounth[i]);
}


//listy:
List<string> coulors = new List<string>();
coulors.Add("black");
coulors.Add("blue");
coulors.Add("green");
coulors.Add("yelow");
coulors.Add("red");
coulors.Add("vaylet");
coulors.Add("braun");
coulors.Add("orange");
coulors.Add("gold");
coulors.Add("silver");
coulors.Add("pink");
coulors.Add("white");

Console.WriteLine(coulors[0]);

for (var i = 0; i < coulors.Count; i = i + 1)
{
    Console.WriteLine(coulors[i]);
}



foreach (var nic in coulors)
{
    Console.WriteLine(nic);
}

string[] mounthh = new string[12];
mounthh[0] = "styczeń";
mounthh[1] = "luty";
mounthh[2] = "marzec";
mounthh[3] = "kwiecien";
mounthh[4] = "maj";
mounthh[5] = "czerwiec";
mounthh[6] = "lipiec";
mounthh[7] = "sierpien";
mounthh[8] = "wrzesien";
mounthh[9] = "pażdziernik";
mounthh[10] = "listopad";
mounthh[11] = "grudzień";

foreach (var mount in mounthh)
{
    Console.WriteLine(mount);
}



return 0;