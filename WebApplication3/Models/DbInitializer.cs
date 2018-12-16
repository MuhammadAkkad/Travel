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
            TripDbContext context = app.ApplicationServices.GetRequiredService<TripDbContext>();

            context.Database.Migrate();
            if (context.Categories.Any() == false)
            {

                var categories = new[]
                {
                    new Category() {  Continent = "Dram", },
                    new Category() {  Continent = "Komedi", },
                    new Category() {   Continent = "Macera", } };
                context.Categories.AddRange(
               categories
             );

                var trips = new[] // movies
                {
                       new Trip() {  City = "muhammad", Desc = "orem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur." ,Country="Asia" , Price=250,Famous="Name of the famouse thing" ,FamousSubTitle="1most famous thing there EX: Adana kebab..." },
                       new Trip() { City = "The Godfather", Desc = "orem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur." ,Country="Asia2" , Price=250, Famous="Name of the famouse thing" ,FamousSubTitle="2most famous thing there EX: Adana kebab..." },
                       new Trip() { City = "Star Wars", Desc = "orem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur." ,Country="Asia3" , Price=250, Famous="Name of the famouse thing" ,FamousSubTitle="m3ost famous thing there EX: Adana kebab..."},
                       new Trip() { City = "The Dark Knight", Desc = "orem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur." ,Country="Asia4" , Price=250, Famous="Name of the famouse thing" ,FamousSubTitle="4most famous thing there EX: Adana kebab..."},
                       new Trip() { City = "The Shawshank Redemption", Desc = "orem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur." ,Country="Asia5" , Price=250, Famous="Name of the famouse thing" ,FamousSubTitle="5most famous thing there EX: Adana kebab..."},
                       new Trip() { City = "Pulp Fiction ", Desc = "orem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur." ,Country="Asia6" , Price=250, Famous="Name of the famouse thing" ,FamousSubTitle="5most famous thing there EX: Adana kebab..."},
                       new Trip() { City = "Fight Club ", Desc = "orem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur." ,Country="Asia7" , Price=250, Famous="Name of the famouse thing" ,FamousSubTitle="6most famous thing there EX: Adana kebab..."},
                       new Trip() { City = "Inception", Desc = "orem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur." ,Country="Asia8" , Price=250, Famous="Name of the famouse thing" ,FamousSubTitle="8most famous thing there EX: Adana kebab..."},
                       new Trip() { City = "Die Hard", Desc = "orem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur." ,Country="Asia9" , Price=250, Famous="Name of the famouse thing" ,FamousSubTitle="9most famous thing there EX: Adana kebab..."}
                };

                context.Trips.AddRange(trips); // Movies - movies
                var tripCategory = new[]  // movieCategory
                {
                    new TripCategory{ Trip=trips[0], Category=categories[0]}, // MovieCategory - Movies - movies
                    new TripCategory{ Trip=trips[1], Category=categories[1]}, // MovieCategory - Movies - movies
                    new TripCategory{ Trip=trips[2], Category=categories[2]}, // MovieCategory - Movies - movies
                    new TripCategory{ Trip=trips[3], Category=categories[1]}, // MovieCategory - Movies - movies
                    new TripCategory{ Trip=trips[4], Category=categories[2]}, // MovieCategory - Movies - movies
                    new TripCategory{ Trip=trips[5], Category=categories[0]}, // MovieCategory - Movies - movies
                    new TripCategory{ Trip=trips[6], Category=categories[1]}, // MovieCategory - Movies - movies
                    new TripCategory{ Trip=trips[7], Category=categories[2]}, // MovieCategory - Movies - movies
                    new TripCategory{ Trip=trips[8], Category=categories[0]}, // MovieCategory - Movies - movies
                    //new TripCategory{ TripId=1, CategoryId=1 }, // MovieCategory - MovieId
                    //new TripCategory{ TripId=2, CategoryId=1 }, // MovieCategory - MovieId
                    //new TripCategory{ TripId=3, CategoryId=2 }  // MovieCategory - MovieId
                };
                context.TripCategories.AddRange(tripCategory); // MovieCategories - movieCategory
                context.SaveChanges();
            }
        }
    }
}