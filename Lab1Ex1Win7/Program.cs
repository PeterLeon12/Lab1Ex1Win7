//Ex1
//Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
//paralelipiped dreptunghic, va afisa volumul lui



.WriteLine("Introduceti latimea");
int latime = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti inaltimea");
int inaltime = int.Parse(Console.ReadLine());

Console.WriteLine("Introduceti adancimea");
int adancimea = int.Parse(Console.ReadLine());

int volumuParalelipipeduluiDreptunghic = latime * inaltime * adancimea;
Console.WriteLine(volumuParalelipipeduluiDreptunghic);