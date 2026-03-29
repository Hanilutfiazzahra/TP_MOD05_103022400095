static void Main(string[] args)
{
    HaloGeneric halo = new HaloGeneric();
    halo.SapaUser<string>("Hani");

    DataGeneric<string> data = new DataGeneric<string>("103022400095");
    data.PrintData();

    Console.ReadLine();
}
