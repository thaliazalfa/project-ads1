using System;

namespace ya_Allah_gumoh_ni_ak
{
    class Program
    {
        static void Didi()
        {
            Console.WriteLine("\nSelamat datang di Dana Darurat! ");
            Console.WriteLine("\nPenasaran kenapa dana darurat penting?");
            Console.WriteLine("Jawabannya karena bisa membantu Anda memenuhi berbagai kebutuhan hidup. \nSaat terjadi PHK yang tidak terduga atau Anda menderita penyakit yang membuat tidak bisa bekerja.");

            Console.WriteLine("\n--------------------------------------------------------------------------------");
            Console.WriteLine("MASUKAN NOMINAL UANG ANDA. \nmasukan hanya angka atau gunakan koma jika ingin memisahkan digit");
            Console.Write("\nMasukan pengeluaran tetap perbulan : ");
            float out_tetap = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Masukan pengeluaran tambahan perbulan : ");
            float out_tambahan = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("lajang \nmenikah \nmenikah dan punya anak");
            Console.Write("Masukan status anda : ");
            String status = Console.ReadLine().ToLower();

            float kali3, kali4, kali6;
            kali3 = (out_tetap+out_tambahan)*3;
            kali4 = (out_tetap+out_tambahan)*4;
            kali6 = (out_tetap+out_tambahan)*6;

            Console.WriteLine("\n--------------------------------------------------------------------------------");

             
            while(status != "lajang" && status != "menikah" && status != "menikah dan punya anak")
            {
                Console.WriteLine("\nOpsi tidak tersedia!");
                Console.Write("Masukan status anda : ");
                status = Console.ReadLine().ToLower();
                Console.WriteLine("\n--------------------------------------------------------------------------------");
            }

            switch (status)
            {
                case "lajang":
                    Console.WriteLine("Status Anda : " + status);
                    Console.WriteLine("Dana Darurat yang dibutuhkan minimal : " + kali3);
                    Console.WriteLine("\nSaran : ");
                    Console.WriteLine("Untuk menghindari perialku konsumtif yang berlebihan, amankan 50% dana darurat Anda di Reksadana Pasar Uang.\nKarena nilai investasi Anda pasti akan selalu naik dan Anda akan mendapat bunga tahunan 7-8%.\nDengan begitu, Anda akan lebih bijak dalam mengeluarkan uang.");
                    break;
                case "menikah":
                    Console.WriteLine("Status Anda : " + status);
                    Console.WriteLine("Dana Darurat yang dibutuhkan minimal : " + kali4);
                    Console.WriteLine("Jika anda sudah menikah dan hendak memiliki anak, lebih disarankan memiliki Dana Darurat sebanyak " + kali6);
                    Console.WriteLine("\nSaran : ");
                    Console.WriteLine("Untuk menghindari perialku konsumtif yang berlebihan, amankan 50% dana darurat Anda di Reksadana Pasar Uang.\nKarena nilai investasi Anda pasti akan selalu naik dan Anda akan mendapat bunga tahunan 7-8%.\nDengan begitu, Anda akan lebih bijak dalam mengeluarkan uang.");
                    break;
                case "menikah dan punya anak":
                    Console.WriteLine("Status Anda : " + status);
                    Console.WriteLine("Dana Darurat yang dibutuhkan minimal : " + kali6);
                    Console.WriteLine("\nSaran : ");
                    Console.WriteLine("Untuk menghindari perialku konsumtif yang berlebihan, amankan 50% dana darurat Anda di Reksadana Pasar Uang.\nKarena nilai investasi Anda pasti akan selalu naik dan Anda akan mendapat bunga tahunan 7-8%.\nDengan begitu, Anda akan lebih bijak dalam mengeluarkan uang.");
                    break;
            }

            Console.WriteLine("\nTerimakasih telah menggunakan Personal Money Plan ! ");
            Console.WriteLine("\nKetik salah satu dari opsi ini untuk selanjutnya. \nBack To Home || Done : ");
            String choose = Console.ReadLine().ToLower();

            while(choose != "back to home" && choose != "done")
            {
                Console.WriteLine("Opsi yang anda masukan tidak tersedia!");
                Console.Write("\nKetik salah satu dari opsi ini untuk selanjutnya. \n Back To Home || Done : ");
                choose = Console.ReadLine().ToLower();
            }
            
            switch (choose)
            {
                case "back to home" :
                    Main();
                    break;
                case "done" :
                    Console.WriteLine("GOOD BYE! HAVE A NICE DAY");
                    break;
            }
        }
        
         static void Perencanaan()
         {
            Console.WriteLine("\nSelamat datang di Perencanaan Bulanan!");
            Console.WriteLine("\nPenasaran kenapa perencanaan uang bulanan itu penting?"); 
            Console.WriteLine("Karena selain hemat, jika dapat mengelola keuangan dengan baik, hidup Anda akan lebih tertib dan teratur.");
            
            Console.WriteLine("\n--------------------------------------------------------------------------------");
            Console.WriteLine("MASUKAN NOMINAL UANG ANDA. \nmasukan hanya angka atau gunakan koma jika ingin memisahkan digit");

            Console.Write("\nMasukan pendapatan tetap perbulan : ");
            float p_tetap = Convert.ToSingle(Console.ReadLine());

            Console.Write("\nMasukan pendapatan tambahan perbulan : ");
            float p_tambahan = Convert.ToSingle(Console.ReadLine());

            
            float sepuluh, duapuluh, tigapuluh, empatpuluh, limapuluh;

            sepuluh = (p_tambahan+p_tetap)*10/100;
            duapuluh = (p_tambahan+p_tetap)*20/100;
            tigapuluh = (p_tambahan+p_tetap)*30/100;
            empatpuluh = (p_tambahan+p_tetap)*40/100;
            limapuluh = (p_tambahan+p_tetap)*50/100;
            
            Console.WriteLine("\n--------------------------------------------------------------------------------");
           
            Console.WriteLine("\nMETODE 20/30/50");
            Console.WriteLine("\n20% --> untuk tabungan atau investasi = Rp." + duapuluh + "\n(Kategori ini termasuk tabungan likuid seperti dana darurat)");
            Console.WriteLine("\n30% --> untuk keinginan anda = Rp." + tigapuluh + "\n(cicilan dan hutang-hutang yang lain)");
            Console.WriteLine("\n50% --> untuk kebutuhan sehari-hari = Rp." + limapuluh + "\n(biaya makan, transportasi, pulsa, listrik, dsb)");

            Console.WriteLine("\n--------------------------------------------------------------------------------"); 

            Console.WriteLine("\nMETODE 10/20/30/40");
            Console.WriteLine("\n10% --> untuk amal dan berbagi kepada yang lain = Rp." + sepuluh);
            Console.WriteLine("\n20% --> untuk tabungan, investasi, dan simpanan = Rp." + duapuluh + "\n(Kategori ini termasuk tabungan likuid seperti dana darurat)");
            Console.WriteLine("\n30% --> untuk membayar cicilan = Rp." + tigapuluh + "\n(cicilan dan hutang-hutang yang lain)");
            Console.WriteLine("\n40% --> untuk biaya hidup dan pengeluaran bulanan rutin = Rp." + empatpuluh + "\n(biaya makan, transportasi, pulsa, listrik, dsb)");

            Console.WriteLine("\nTerimakasih telah menggunakan Personal Money Plan ! ");
            Console.Write("\nKetik salah satu dari opsi ini untuk selanjutnya. \nBack To Home || Done : ");
            String choose = Console.ReadLine().ToLower();

            while(choose != "back to home" && choose != "done")
            {
                Console.WriteLine("Opsi yang anda masukan tidak tersedia!");
                Console.Write("\nKetik salah satu dari opsi ini untuk selanjutnya. \nBack To Home || Done : ");
                choose = Console.ReadLine().ToLower();
            }
            
            switch (choose)
            {
                case "back to home" :
                    Main();
                    break;
                case "done" :
                    Console.WriteLine("GOOD BYE! HAVE A NICE DAY");
                    break;
            }

         }
         
        static void Main()
        {
            Console.Write("\nMasukan Nama Pengguna : ");
            String nama = Console.ReadLine();

            Console.Write("\nHi, selamat datang " + nama + "!");
            Console.WriteLine("\nDisini kami akan membantu kamu untuk mengelola dan mengatur keuangan bulananmu untuk  mencapai kebebasan finansial.");

            Console.WriteLine("\nPilih “Perencanaan Bulanan” untuk mengetahui pembagian dana perbulan.\nPilih “Dana Darurat” untuk mengetahui jumlah dana darurat yang harus dimiliki.");
            Console.Write("\nMasukan jawaban anda : ");
            string jawaban = Console.ReadLine().ToLower();
            Console.WriteLine("\n===============================================================================");
            
            
            while(jawaban != "perencanaan bulanan" && jawaban != "dana darurat")
            {
                Console.WriteLine("Opsi yang anda masukan tidak tersedia!");
                Console.Write("\nMasukan jawaban anda : ");
                jawaban = Console.ReadLine();
            }
            switch (jawaban)
            {
                case "perencanaan bulanan" :
                    Perencanaan();
                    break;
                case "dana darurat" :
                    Didi();
                    break;
            }
            

        }
    }
}
