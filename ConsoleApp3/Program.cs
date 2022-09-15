// See https://aka.ms/new-console-template for more information

/*write();*/
/*read();*/
update();
Console.ReadLine();
const string filename = "example.txt";
static void write()
{
    StreamWriter sw = new StreamWriter(filename);
    sw.WriteLine("hello world");
    string s = "hello kutte";
    sw.WriteLine(s);
    sw.Close();
}
static void read()
{
    StreamReader sr = new StreamReader(filename);

    string s =sr.ReadToEnd();
    Console.WriteLine(s);
    sr.Close();
  /*  
   *  Or
    string s = sr.ReadToEnd();
    Console.WriteLine(s);
    sr.Close();*/
}
static void update()
{
    StreamWriter sw = new StreamWriter(filename, true);
    for(int i = 0; i < 10; i++)
    {
         sw.WriteLine(i);    
    }
    sw.Close();

}