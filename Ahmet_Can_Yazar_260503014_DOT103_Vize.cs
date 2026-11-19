using System;

class Program
{
    static void Main()
    {
        int can = 100;
        int oda = 1;
        bool kurtulduMu = false;

        Console.WriteLine("=== YALINDAN KAÇIŞ ===");
        Console.WriteLine("Karanlık bir zindanda uyandın. Arkandan korkunç bir kükreme sesleri geliyor! Sanırım Yalına ait");
        Console.WriteLine("Yalına yakalanmadan çıkışı bulmalısın.");

        while (can > 0 && kurtulduMu == false)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Mevcut Can: " + can + " HP");

            switch (oda)
            {
                case 1:
                    Console.WriteLine("1. Oda: Taş bir koridordasın. Karşında 2 tane kapi var.");
                    Console.WriteLine("1 - Sol kapıdan git (bi ışık geliyor)");
                    Console.WriteLine("2 - Sağ kapıdan git (baya baya karanlık)");
                    break;
                case 2:
                    Console.WriteLine("2. Oda: Kocaman bir salona geldin Ayaka sesleri geliyor");
                    Console.WriteLine("1 - Görkemin heykelinin arkasına saklan");
                    Console.WriteLine("2 - Hemen karşıdaki merdivenlere doğru hızla koş");
                    break;
                case 3:
                    Console.WriteLine("3. Oda: Merdivenlerden çıkınca eski bir mutfağına girdin. Masada yeşil bir şişe parlıyor.");
                    Console.WriteLine("1 - Şişedeki şüpheli iksiri dik kafaya (ya herro ya merro)");
                    Console.WriteLine("2 - Hiç bulaşmadan kiler kapısından sıvış");
                    break;
                case 4:
                    Console.WriteLine("4. Oda: Paslı kılıçlar ve eski kalkanların olduğu bir mahzendesin.");
                    Console.WriteLine("1 - Yerdeki paslı kılıcı kapıp Yalın'a kafa tut (deli misin?)");
                    Console.WriteLine("2 - Kalkanı sırtına alıp masaların altından sürün( pek güvenilir durmuyo ama sen dene)");
                    break;
                case 5:
                    Console.WriteLine("5. Oda: Karanlık bir köprüden geçiyorsun. Altında bir uçurum var Yalının nefesini ensende hissediyorsun!");
                    Console.WriteLine("1 - Köprüden parmak ucunda sessizce yürü (yalın fark etmesin)");
                    Console.WriteLine("2 - Gözünü kapatıp karşıya doğru depar at(şans oyunu)");
                    break;
                case 6:
                    Console.WriteLine("6. Oda: Duvarlarda meşaleler yanıyor. Loş bir ışık var ");
                    Console.WriteLine("1 - Duvardaki meşaleyi söküp Yalının üstüne fırlat (yansın diye dua et)");
                    Console.WriteLine("2 - Hiç ses çıkarmadan gölgelerin arasından son kapıya doğru yönel");
                    break;
                case 7:
                    Console.WriteLine("7. Oda: Son koridor Karşında devasa bir tahta kapı var.");
                    Console.WriteLine("1 - Kapıyı omuz atarak kırmaya çalış (o kadar kaslı mısın?)");
                    Console.WriteLine("2 - Yanda bi Vent var oraya girip sürünebilirsin");
                    break;
            }

            Console.Write("Seçim (1 veya 2): ");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (oda)
            {
                case 1:
                    switch (secim)
                    {
                        case 1:
                            Console.WriteLine("Sol kapıdan geçtin. Aydınlık ve güvenli");
                            oda = 2;
                            break;
                        case 2:
                            Console.WriteLine("Karanlıkta tuzağa bastın ve ses çıktı. YALIN SANA KOŞUYOR");
                            can -= 30;
                            oda = 2;
                            break;
                        default:
                            Console.WriteLine("Koşmaya başladın ve Kafanı duvara çarptın");
                            can -= 10;
                            break;
                    }
                    break;

                case 2:
                    switch (secim)
                    {
                        case 1:
                            Console.WriteLine("Yalın seni Görkemin heykelinin arasında fark etti ve Tekme salladı ");
                            can -= 50;
                            oda = 3;
                            break;
                        case 2:
                            Console.WriteLine("Koşa Koşa merdivene gittin. Yalın şimdilik uzakta...");
                            oda = 3;
                            break;
                        default:
                            Console.WriteLine("Yanlış tuşa bastın, ayağın takıldı ve düştün!");
                            can -= 10;
                            break;
                    }
                    break;

                case 3:
                    switch (secim)
                    {
                        case 1:
                            Console.WriteLine("Aslında sağlık iksiriymiş Kendine geldin iyisinnn (+25 HP).");
                            can += 25;
                            if (can > 100) can = 100;
                            oda = 4;
                            break;
                        case 2:
                            Console.WriteLine("Risk olmadan kazanç olmaz, kiler kapısından sessizce geçtin.");
                            oda = 4;
                            break;
                        default:
                            Console.WriteLine("Elin kolun rahat durmadığı için tencereye çarpıp ses çıkardın!");
                            can -= 10;
                            break;
                    }
                    break;

                case 4:
                    switch (secim)
                    {
                        case 1:
                            Console.WriteLine("Yalın paslı kılıcı tek hamlede kırıp sana sağlam bir OSLANMLI tokatı yapıştırdı!");
                            can -= 40;
                            oda = 5;
                            break;
                        case 2:
                            Console.WriteLine("Kalkan sırtını korudu, Yalın seni fark etmeden diğer odaya geçtin.");
                            oda = 5;
                            break;
                        default:
                            Console.WriteLine("Parmağına kıramp girdi zırh yığınına çarpıp devirdin!");
                            can -= 10;
                            break;
                    }
                    break;

                case 5:
                    switch (secim)
                    {
                        case 1:
                            Console.WriteLine("Yavaş yavaş yürürken taş kaydı son anda tutundun ama kolunu incittin.");
                            can -= 15;
                            oda = 6;
                            break;
                        case 2:
                            Console.WriteLine("Tam bir atlet gibi uçarak karşıya geçtin(Naim Süleymanoğlu musun?) Yalın arkada kaldı!");
                            oda = 6;
                            break;
                        default:
                            Console.WriteLine("uçurumun kenarında dengeni kaybedip dizini vurdun!(Kolun gibi dizin de gitti aferin)");
                            can -= 10;
                            break;
                    }
                    break;

                case 6:
                    switch (secim)
                    {
                        case 1:
                            Console.WriteLine("Yalın meşaleyi havada yakalayıp sana geri fırlattı! Fena yandın.");
                            can -= 35;
                            oda = 7;
                            break;
                        case 2:
                            Console.WriteLine("Nefesini tuttun komando misali ve sessizce geçtin.");
                            oda = 7;
                            break;
                        default:
                            Console.WriteLine("Burada da yanlış tuşa nasıl basabilirsin dostum ya");
                            can -= 10;
                            break;
                    }
                    break;

                case 7:
                    switch (secim)
                    {
                        case 1:
                            Console.WriteLine("Kapı çok sağlamdı (FBI mısın dostum kıramazdın zaten). Sen kırana kadar Yalın arkandan yetişti!");
                            can -= 100;
                            break;
                        case 2:
                            Console.WriteLine("Ventte sürünerek dışarıya çıktın. Güneş ışığını görüyorsun, Yaşadın gene iyisin.");
                            kurtulduMu = true;
                            break;
                        default:
                            Console.WriteLine("Kafanı kapıya vurdun ve burnun kanamaya başladı");
                            can -= 10;
                            break;
                    }
                    break;
            }
        }

        Console.WriteLine("\n=================================================");

        switch (kurtulduMu)
        {
            case true:
                Console.WriteLine("HELAL LAANN Zindandan ölmeeeden çıkmayı başardın");
                break;
            case false:
                Console.WriteLine("GAME OVER... Öldün dostum sonra gel");
                break;
        }

        Console.ReadLine();
    }
}