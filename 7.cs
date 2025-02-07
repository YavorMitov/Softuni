double metri=double.Parse(Console.ReadLine());
double cena=metri*7.61;
double otstupka=0.18*cena;
double krainacena=cena-otstupka;
string str=("The final price is: ")+krainacena+" lv.";
string str2=("The discount is: ")+otstupka+" lv.";
Console.WriteLine(str);
Console.WriteLine(str2);