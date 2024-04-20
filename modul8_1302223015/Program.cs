namespace modul8_1302223015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UIConfig uiConfig = new UIConfig();
            int jumlahTF, biayaTF;
            string metode, confirm;

            if (uiConfig.bankConfig.lang == "en")
            {
                Console.Write("Please insert the amount of money to transfer: ");
                jumlahTF = Convert.ToInt32(Console.ReadLine());
                biayaTF = jumlahTF <= uiConfig.bankConfig.transfer.treshhold ? uiConfig.bankConfig.transfer.low_fee : uiConfig.bankConfig.transfer.high_fee;
                Console.WriteLine($"Transfer fee = {biayaTF}");
                Console.WriteLine($"Total amount = {jumlahTF + biayaTF}");
                Console.WriteLine("Select transfer method:");
                for (int i = 0; i < uiConfig.bankConfig.method.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {uiConfig.bankConfig.method[i]}");
                }
                Console.Write("Your choice = ");
                metode = Console.ReadLine();
                Console.Write($"Please type {uiConfig.bankConfig.confirmation.en} to confirm the transaction: ");
                confirm = Console.ReadLine();
                if (!uiConfig.bankConfig.method.Contains(metode) || confirm != uiConfig.bankConfig.confirmation.en)
                {
                    Console.WriteLine("The transfer is cancelled");
                }
                else
                {
                    Console.WriteLine("Transfer is completed");
                }
            }
            else if (uiConfig.bankConfig.lang == "id")
            {
                Console.Write("\nMasukkan jumlah uang yang akan di-transfer: ");
                jumlahTF = Convert.ToInt32(Console.ReadLine());
                biayaTF = jumlahTF <= uiConfig.bankConfig.transfer.treshhold ? uiConfig.bankConfig.transfer.low_fee : uiConfig.bankConfig.transfer.high_fee;
                Console.WriteLine($"Biaya transfer = {biayaTF}");
                Console.WriteLine($"Total biaya = {jumlahTF + biayaTF}");
                Console.WriteLine("Pilih metode transfer: ");
                for (int i = 0; i < uiConfig.bankConfig.method.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {uiConfig.bankConfig.method[i]}");
                }
                Console.Write("Pilihan anda =  ");
                metode = Console.ReadLine();
                Console.Write($"Ketik {uiConfig.bankConfig.confirmation.id} untuk mengkonfirmasi transaksi: ");
                confirm = Console.ReadLine();
                if (!uiConfig.bankConfig.method.Contains(metode) || confirm != uiConfig.bankConfig.confirmation.id)
                {
                    Console.WriteLine("Transfer dibatalkan");
                }
                else
                {
                    Console.WriteLine("Transfer berhasil");
                }
            }
        }
    }
}
