using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public static class DbInitializer
    {
        public static void InitializeDb(IApplicationBuilder app)
        {
            MovieDbContext context = app.ApplicationServices.GetRequiredService<MovieDbContext>();

            context.Database.Migrate();
            if (context.Categories.Any() == false)
            {

                var categories = new[]
                {
                    new Category() {  Name = "Dram", },
                    new Category() {  Name = "Komedi", },
                    new Category() {   Name = "Macera", } };
                context.Categories.AddRange(
               categories
             );

                var movies = new[]
                {
                new Movie() { Name = "Cape Down", Desc = "Dünyanın en güzel şehirlerinden biri olan Cape Town gerek turistik mekanları, gerek ılıman iklimi, adrenalin dolu aktiviteleri ile turistlerin uğrak yeri haline gelmiştir. Cape Town Güney Afrika Cumhuriyeti'nin üç başkentinden biridir. Nüfusu yaklaşık 3.500.000 olup yaklaşık 500 bin - 1 milyon Müslümanın yaşadığı bir şehirdir. Afrika kıtasının Avrupa'ya en uzak ucundadır. Şehirde yaklaşık 300 Türk yaşamaktadır. Cape Town, Güney Afrika'nın nüfus bakımından en büyük ikinci şehridir. Cape town, Güney Afrika'nın tam güneybatı ucunda yer alır. Cape Town'da Afrika, Hollanda ve İngiliz kültürleri harmanlanmıştır. " },
                new Movie() { Name = "Vancouver", Desc = "Bir çok ünlü film ve dizilere, olimpiyat ve  dünya şampiyonasına ev sahipliği yapan, bünyesinde farklı etnik grupları barındıran dünyanın güzel şehirleri arasında yer alan Vanouver adeta bir metropoldür. Vancouver kozmopolit bir şehir ve buradaki nüfusun %60’ı Asya kökenli.Vancouver yeni bir yerleşim.Şehirde eski tarihi binaları görmeniz pek mümkün değil. Vancouver’a geldiğinizde Granville Adasınıve köprüsünü görebilirsiniz.Burada çok büyük bir yat limanı da mevcut. Gökdelenler genellikle cam malzemeyle dizayn edilmiş." },
                new Movie() { Name = "Venedik", Desc = "Venedik için yeryüzünün en güzel şehridir desek yalan olmaz herhalde. Tarihi,doğal güzelliği ve müthiş mimarisiyle ünlü Venedik’in dünyanın en güzel şehirleri arasında olması kaçınılmazdır. Kuzeydoğu İtalya'da birbirinden kanallarla ayrılmış ve köprülerle bağlanan 118 adanın üzerine kuruludur. Şehir, kıyı şeridi boyunca uzanan Venetian Lagoon bataklığında, Po ve Piave nehirlerinin deltaları arasına kuruludur. Su üstünde yüzer gibi görünen bu şehir kanalları, gondolları ve romantik turları ile dünyanın en çok ziyaret edilen yerlerinden biridir. " },
                new Movie() { Name = "İstanbul", Desc = "Türkiye'nin ve dünyanın en güzel şehirleri arasında gösterilen İstanbul, birçok müzisyenin bestelerine, ünlü şairlerin şiirlerine konu olmuş olan  bir şehir. Tarihi yapıtları ve muhteşem boğazı ile dünyanın dört bir yanından gelen turistleri kendine hayran bıraktıran bir yer. Şehirde birçok müze, saray, sur, hisar turistik açıdan İstanbul’a katkı sağlamaktadır. Yılın her mevsimi Türkiye’den ve dünyadan birçok yerli ve yabancı turist şehri ziyarete gelerek İstanbul’a önemli miktarda turizm geliri bırakmaktadır. Geçmişte birçok toplumun hüküm sürdüğü İstanbul, her daim dünyanın en görkemli ve güzel şehirleri arasında yerini alacaktır. " },
                new Movie() { Name = "Sidney", Desc = "Tam bir kültür sentezi, stressiz rahat 7/24 eğlenceli mekanlarıyla ünlü modern hayattan nasıl keyif alınabileceğinin en güzel örneklerindendir Sidney. Avustralya'nın başkenti olmamasına rağmen, Sidney birçok açıdan ülkenin en önemli kenti sayılır. Sidney; kültürü, Dünya'nın en büyük doğal limanı olan Sidney Limanı ve sahilleriyle gidilebilecek dünyanın en güzel turistik şehirlerden biri olarak kabul edilmektedir.2000 Dünya Yaz Olimpiyatlarına da evsahipliği yaparak popülaritesini biraz daha arttırmış ve kendinden başarıyla söz ettirmeyi başarmıştır. " },
                new Movie() { Name = "San Francisco", Desc = "Şehir merkezinin sık sık sisle kaplandığı meşhur tepelerinden kentin muhteşem manzarasıyla, baş döndüren gökdelenleriyle, eski tarihi evleriyle ünlü dünyanın en güzel şehirleri arasına girmeyi başarmış dünyanın en güzel şehirlerinden bir tanesi... Günümüzde San Francisco bir uluslararası finans, ulaşım ve kültür merkezidir. Şehir ayrıca yaz sisleri, dik kayaları, ilginç tramvay sistemi, Çin mahalleleri ve içlerinde Golden Gate Köprüsü'nü de bulunduran modern ve Viktorya Mimarisi ile popüler bir turizm merkezidir." },
                new Movie() { Name = "New York", Desc = "Hiç uyumayan şehir adını almış olmasından da anlaşılacağı üzere 24 saat hayatın durmadığı, turistlere cazip gelen New York, dünyanın en güzel şehirlerinden biridir. Şehir; ticaret, finans, medya, sanat, moda, araştırma, teknoloji, eğitim ve eğlence sektöründe önemli katkı yaptığından dolayı küresel kent olarak anılmaktadır. Önemli bir uluslararası diplomasi merkezi olan kent, Birleşmiş milletler genel merkezine de ev sahipliği yapmaktadır ve dünyanın kültür başkenti olarak tanımlanır." },
                new Movie() { Name = "Tokyo", Desc = "Tokyo, dünyayı kendisine hayran bırakan şehirlerin başında gelmektedir. Öyle ki, bu şehre ziyarete, gezmeye ya da iş amaçlı gelen her kim olursa olsun, şehrin havasına kendisini kaptırmadan yapamamaktadır. Oldukça renkli olan bu şehirde çok güzel vakitler geçireceğinizden emin olabilirsiniz." },
                new Movie() { Name = "Floransa", Desc = "Sanat şehri olarak adlandırılabilecek bir çok ünlü sanatçının yaşamış olduğu dünyanın güzel şehirlerinden bir tanesi de Floransa’dır. Şehir kültürel, finansal, sanatsal ve mimari bir mücevher olarak kabul edilir. Her yıl milyonlarca turistin ziyaret ettiği dünyanın en güzel şehirlerinden bir tanesi olan Floransa, sizi kendisine aşık edecektir." }
                };

                context.Movies.AddRange(movies);
                MovieCategory[] movieCategory = new[]
                {
                    new MovieCategory{ Movie=movies[0], Category=categories[2]},
                    new MovieCategory{ Movie=movies[1], Category=categories[0]},
                    new MovieCategory{ Movie=movies[2], Category=categories[1]},
                    new MovieCategory{ Movie=movies[3], Category=categories[0]},
                    new MovieCategory{ Movie=movies[4], Category=categories[1]},
                    new MovieCategory{ Movie=movies[5], Category=categories[2]},
                    new MovieCategory{ Movie=movies[6], Category=categories[1]},
                    new MovieCategory{ Movie=movies[7], Category=categories[0]},
                    new MovieCategory{ Movie=movies[8], Category=categories[1]},
                    //new MovieCategory{ MovieId=1, CategoryId=1 },
                    //new MovieCategory{ MovieId=2, CategoryId=1 },
                    //new MovieCategory{ MovieId=3, CategoryId=2 } 
                };
                context.MovieCategories.AddRange(movieCategory);
                context.SaveChanges();
            }
        }
    }
}