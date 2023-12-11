using System.Management;

Console.WriteLine("Usuarios conectados a las impresoras en la red:");

            foreach (var printerJob in GetAllPrinterJobs())
            {
                Console.WriteLine("Nombre de la impresora: " + printerJob.PrinterName);
                Console.WriteLine("Usuario: " + printerJob.Owner);
                Console.WriteLine("Documento: " + printerJob.Document);
                Console.WriteLine("------------------------------------------------");
            }
static List<PrinterJobInfo> GetAllPrinterJobs()
{
    List<PrinterJobInfo> printerJobs = new List<PrinterJobInfo>();

    ManagementScope scope = new ManagementScope(@"\\.\root\cimv2");
    ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_PrintJob");

    using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query))
    {
        ManagementObjectCollection jobCollection = searcher.Get();

        foreach (ManagementObject job in jobCollection)
        {
            string printerName = job["Name"] as string;
            string owner = job["Owner"] as string;
            string document = job["Document"] as string;

            printerJobs.Add(new PrinterJobInfo { PrinterName = printerName, Owner = owner, Document = document });
        }
    }

    return printerJobs;
}

    class PrinterJobInfo
{
    public string PrinterName { get; set; }
    public string Owner { get; set; }
    public string Document { get; set; }
}
