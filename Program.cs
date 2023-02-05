//cwiczenie tablice
string[] mounth = new string[12];
mounth[0] = "-styczeń";
mounth[1] = "-luty";
mounth[2] = "-marzec";
mounth[3] = "-kwiecień";
mounth[4] = "-maj";
mounth[5] = "-czerwiec";
mounth[6] = "-lipiec";
mounth[7] = "-sierpień";
mounth[8] = "-wrzesień";
mounth[9] = "-październik";
mounth[10] = "-listopad";
mounth[11] = "-grudzień";

for (var i = 0; i < mounth.Length; i=i+2)
{
    Console.WriteLine(mounth[i]);
}

//cwiczenie listy,
List<string> mounth1 = new List<string>();
mounth1.Add ("1 styczeń");
mounth1.Add ("1 luty");
mounth1.Add ("1 marzec");
mounth1.Add ("1 kwiecień");
mounth1.Add ("1 maj");
mounth1.Add ("1 czerwiec");
mounth1.Add ("1 lipiec");
mounth1.Add ("1 sierpień");
mounth1.Add ("1 październik");
mounth1.Add ("1 listopad");
mounth1.Add ("1 grudzień");

for (var i=0; i < mounth1.Count; i = i + 2)
{
    Console.WriteLine(mounth1[i]);
}