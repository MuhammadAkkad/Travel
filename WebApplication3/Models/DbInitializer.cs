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
                    new Category() {  Name = "Asia", },
                    new Category() {  Name = "Europe", },
                    new Category() {  Name = "Africa", },
                    new Category() {  Name = "Australia", },
                    new Category() {  Name = "North America", },
                    new Category() {  Name = "South America", },
                    new Category() {  Name = "Antharctica", } };
                context.Categories.AddRange(
               categories
             );

                var movies = new[]
                {
                new Movie() { Name = "Cape Town",
                    Desc = "Cape Town, which is one of the most beautiful cities in the world, has become a popular destination for tourists with its tourist attractions, need mild climate, adrenalin filled activities. Cape Town is one of the three capitals of the Republic of South Africa. Its population is about 3,500,000 and it is a city of about 500 thousand - 1 million Muslims. It is at the far end of the continent of Africa. About 300 Turks live in the city. Cape Town is the second largest city in South Africa. It is located at the full southwest end of Cape Town, South Africa. Blended African, Dutch and British cultures in Cape Town.",
                    Country ="South Africa",
                    Price =250,
                    Famous ="Cape Town is famous for its Cape of Good Hope, Table Mountain and its harbor, the southernmost point in Africa.",
                    FamousSubTitle ="Table Mountain is named after Cape Town. With its hundreds of millions of years of interaction with the effects of natural conditions such as rain, glaciers and wind, Masadağı offers you a unique ocean and African landscape when you reach the summit. It is much easier to reach the summit of Masadağı with the cable car carrying passengers every half hour. But the number of people climbing to the top of the mountain by. Hiking “does not seem to be underestimated. However, if you want to go up the mountain, we must say that climbing over the top of the mountain above 1,000 meters (exactly 1,087 meters) is quite troublesome.",
                    Photo = "/img/capetown.jpg"},

                new Movie() { Name = "Vancouver",
                    Desc = "Vanouver is one of the most beautiful cities in the world, which hosts many famous films and serials, olympic and world championships and hosts different ethnic groups. Vancouver is a cosmopolitan city and 60% of the population here is of Asian origin. It is a new settlement in Vancouver. When you arrive in Vancouver you can see Granville Island and the bridge. There is also a very large marina. Skyscrapers are usually designed with glass material.",
                    Country ="Canada",
                    Price =1500,
                    Famous ="Capilano Suspension Bridge",
                    FamousSubTitle ="Built by the British in 1886, the Capilano Suspension Bridge is 70 meters above the Capilano River. Looking down over the 137-meter-long bridge that is difficult to walk and take photos because of the extreme swing, a wildly flowing river, giant trees and a tremendous beauty await you under your feet. If you have no fear of height - if you already have to go to the bridge is not much wisdom - I would recommend that you pump adrenaline to your body with the release of this bridge at meters height.",
                    Photo = "/img/vancouver.jpg"},

                new Movie() { Name = "Venedik",
                    Desc = "I suppose it wouldn't be the most beautiful city in Venice. Venice, famous for its history, natural beauty and awesome architecture, is inevitable among the most beautiful cities in the world. It is based on 118 islands separated by canals and connected by bridges in northeastern Italy. The city is located in the Venetian Lagoon swamp along the coastline between the deltas of the Po and Piave rivers. Floating on the water, this city is one of the most visited places in the world with its canals, gondolas and romantic tours.",
                    Country ="Italia",
                    Price =800,
                    Famous ="Palazzo Ducale",
                    FamousSubTitle ="Palazzo Ducale, which means the Palace of the Dukes, is one of the must-see places in Venice. The palace is located in San Marco Square, which is the most visited place in Venice, right next to the Basilica of San Marco, one of the oldest buildings in the city. Built in the middle of the 14th century in the Gothic architectural style. The building, which was converted into a museum in 1923, is home to a wide range of art collections as well as many exhibitions. Walk up to the giant staircase in the courtyard and visit the Duke's apartment and discover the palace from top to bottom. You can follow the steps of the ex-prisoners in Sospiri, called the Last View or the Ahlar Bridge on the road to the old prison, you can imagine the ancient city of Venice and its inhabitants and turn your tour into a unique memory.",
                    Photo="/img/venedik.jpg"},
                new Movie() { Name = "İstanbul",
                    Desc = "Turkey's one of the most beautiful cities in the world and Istanbul, with many musician's compositions, a city that has been the subject of poems of famous poets. It is a place that fascinates tourists from all over the world with its historical monuments and magnificent gorge. Many museums, palaces, fortifications and fortresses in the city contribute to Istanbul. in all seasons of the year came from Turkey and around the world to visit the city many domestic and foreign tourists, leaving significant amounts Istanbul tourism revenue. Istanbul, where many societies prevailed in the past, will always be among the most magnificent and beautiful cities of the world.",
                    Country ="Turkey",
                    Price =150,
                    Famous ="Galata Tower",
                    FamousSubTitle ="Galata Tower, one of the oldest and most beautiful towers of Istanbul, was built by the Byzantine Emperor Anastasius Oilosuz in 528 as a lighthouse tower. Of course, like many wooden structures in Istanbul, he also had his share of big fires. It was built in 1348 by the Genoese as Christea Turris (Jesus Tower). The tower was under Ottoman rule in 1453. Until that time, the tower used for defense purposes, had other tasks. For example, 16th century. Mehteran Quarry was placed in the 18th century in order to inform the midnight of the Galata Tower, the shelter of the prisoners. In 1874, due to its dominant position in the city, it was used for fire surveillance and news. He has been undergoing maintenance and repair many times. Today's shape II. Mahmut was given in the repairs.",
                    Photo="/img/istanbul.jpg"},

                new Movie() { Name = "Sydney",
                    Desc = "Sydney is one of the best examples of how to enjoy the modern life that is famous for its full cultural synthesis, stress-free and comfortable 24/7 fun venues. Although it is not the capital of Australia, Sydney is considered the most important city in many aspects of the country. Sydney; culture is considered to be one of the most beautiful tourist cities in the world, which can be visited by Sydney Harbor and its beaches, which is the biggest natural harbor of the world.",
                    Country ="Australia",
                    Price =2500,
                    Famous ="Sydney Opera House",
                    FamousSubTitle ="Finding the Lost Fish is in the background of the Sydney Opera House, which we found in Nemo, is included in the UNESCO World Heritage list. Sydney Opera House, located at the Port of Sydney, at Bennelong, is considered by many to be one of the wonders of the modern world. Designed by Jørn Utzon in a controversial setting, the hall was opened in 1973. This cultural hub is one of Sydney's most popular symbols for tourists who want to stroll from around the world and take photos and stop at this lush cultural center. The interior of the building was designed by another architect and not as impressive as the outside. The 1-hour guided lounge tour costs $ 37. Instead, we recommend that you look at the lounge from the outside with the city tour. The interior of the hall will be renewed with the ideas and designs of Utzon in its 50th year (2023).",
                    Photo ="/img/sydney3.jpg"},

                new Movie() { Name = "San Francisco",
                    Desc = "San Francisco is one of the most beautiful cities in the world, one of the most beautiful cities in the world, which is famous for its magnificent views, skyscrapers and old historical houses. The city is also a popular tourist destination with its summer fog, steep rocks, interesting tram system, Chinese neighborhoods and the modern and Victorian architecture, which also includes the Golden Gate Bridge.",
                    Country ="ABD(North America)",
                    Price =3500,
                    Famous ="Chinatown",
                    FamousSubTitle ="San Francisco Chinatown is one of the oldest Chinese neighborhoods in the United States. Since its establishment (1848), it has been able to attract attention with its Asian-specific texture, where the immigrants live, cultures, languages and worship of Chinese immigrants living in North America.",
                    Photo ="/img/sanfrancisco.jpg"},

                new Movie() { Name = "New York",
                    Desc = "New York City is one of the most beautiful cities in the world. City; it is known as a global city because it makes a significant contribution to the trade, finance, media, art, fashion, research, technology, education and entertainment industry. As an important center of international diplomacy, the city is also home to the United Nations headquarters and is defined as the cultural capital of the world.",
                    Country ="ABD(North America)",
                    Price =3000,
                    Famous ="Empire State Building",
                    FamousSubTitle ="Wherever you are in New York, you cannot miss the Empire State Building, the second highest (and certainly the most famous) building in the city. Of course, you don't have to be content with just looking away. Make sure to take a stroll away from the viewpoints of the city on the 86th and 102th floors of the building and watch the city's breathtaking view, which is definitely one of the things to be done in New York. You can be sure that you will not be the only one who wants to see this view from the building located on 5th Street, 350th. In order to avoid waiting in the long ticket queues, we recommend you to buy your ticket online in advance. Especially if you have a romantic marriage proposal with the view as many lovers do!",
                    Photo ="/img/newyork.jpg"},

                new Movie() { Name = "Tokyo",
                    Desc = "Tokyo is one of the cities that fascinated the world. So much so that this city, visiting, traveling or for business purposes, no matter who, the city can not do without being immersed in the air. You can be sure that you will have a great time in this very colorful city.",
                    Country ="Japan",
                    Price =1900,
                    Famous ="Fuji Mount",
                    FamousSubTitle ="Mount Fuji, one of the famous paintings of Hokusai, is one of the most beautiful figures in the nature of Japan. You can combine many of the lakeside lakes with the Fuji-Q Highland amusement park, where you can plan to see this mountain that hosts popular trekking routes. I recommend to the mountain enthusiasts to plan a special trekking activity and spend the whole day at the foot of the mountain.",
                    Photo ="/img/tokyo.jpg"},

                new Movie() { Name = "Floransa",
                    Desc = "Florence is one of the most beautiful cities in the world where many famous artists can be named as the city of art. The city is considered a cultural, financial, artistic and architectural gem. Florence, one of the most beautiful cities in the world, visited by millions of tourists every year, will make you fall in love with it.",
                    Country ="Italia",
                    Price =1200,
                    Famous ="Piazzale Michelangelo",
                    FamousSubTitle ="This name was given because it will be home to a museum where Michelangelo's works will be exhibited. Although the museum project was shelved in time, the area has become quite popular among travelers, as it offers unique views of the Arno River, Ponte Vecchio, the Duomo Cathedral, the Santa Croce Church and the Palazzo Vecchio. The square is a 15-minute walk from the Ponte Vecchio Bridge and is also a good shopping point because it is full of souvenir shops. Especially when you visit the area where I would advise you to watch the extraordinary view at sunrise, you can see another copy of Michelangelo's David statue.",
                    Photo ="/img/floransa.jpg"},

                new Movie() { Name = "Oslo",
                    Desc = "Oslo's history dates back a thousand years. The city, which is believed to have been founded by the 3rd Harald in the Norwegian epics, has always been an important city for Scandinavian peoples. The old name was Kristiania. The city is also the administrative capital with a population of around 1 million. The city, consisting of 15 separate districts, is also an important cultural city for Norway. The city, which has been devastated by invasions that have been invaded throughout history, is one of the most expensive capitals in the world.",
                    Country ="Norway",
                    Price =4200,
                    Famous ="The Viking Ship Museum",
                    FamousSubTitle ="The Viking Ship Museum (Vikingskipshuset), part of the Norwegian Folk Museum at the University of Oslo, is home to archaeological objects from the Oseberg, Gokstad and Tune excavations. Providing visitors with detailed information about the Viking Age, the museum attracts the greatest attention from the Oseberg ship, which has been completely removed from under the earth. Other items on display outside the ship include clothing, clothing, carriages, hand tools, and parts that shed light on the lifestyle of Vikings.",
                    Photo ="/img/oslo.jpg"},

                new Movie() { Name = "Rio de Janeiro",
                    Desc = "Rio de Janeiro is the capital of the province and the second largest city of Brazil. Rio de Janeiro (Turkish: Ocak Irmağı). The full name of the city is São Sebastião do Rio de Janeiro (Saint Sebastian's January River). After São Paulo, it is the second largest city in Brazil. Maracanã Stadium and the Christ the Redeemer are located here. Rio de Janeiro hosted the 2016 Summer Olympics and the 2012 World Youth Congress. The world's biggest carnival, 'Rio Carnival', is held in this city. Although celebrated with samba dance, it was first celebrated in 1840 by dancing polka and waltz.",
                    Country ="ABD(South America)",
                    Price =3900,
                    Famous ="Corcovado Hill - Christ the Redeemer Statue",
                    FamousSubTitle ="Corcovado Hill, the most important hill of the city, is one of the places where you can watch Rio the most beautiful. The Christ the Redeemer, built on Corcovado Hill with a height of more than 700 meters, is the most symbolic place on the list of places to visit in Rio De Janeiro. The Christ the Redeemer, which is 30 meters high, is one of the places where tourists are most interested. If you don't want to walk on the Corcovado Hill, you can also easily reach by train every day between 08.00 and 19.00. When you reach the top of the hill, you will see the city view, as well as the most beautiful scenery of Rio, such as Cut Sugar Mountain, Maracana Stadium and Guanabara Bay.",
                    Photo="/img/riodejaneiro.jpg"},

                new Movie() { Name = "Marrakech",
                    Desc = "Marrakech, the capital of Morocco, known as 'Red City' with its red color close to the land, is one of the most interesting places for travelers. This authentic city, which is considered the heart of the country, has a mystical atmosphere with its magnificent buildings, sight-seeing streets and moving everyday life. Before you go on a short trip to Morocco's impressive architecture and markets, it is much easier and easier for you to go to Morocco than you might expect." ,
                    Country ="Morocco",
                    Price =650,
                    Famous ="Djemaa El Fna",
                    FamousSubTitle ="Marrakech (Marrakech) is the historic capital of the city. Being a red city and taking its place as a remarkable city all over the world with its unique mysterious texture. The city of Marrakech is divided into two as old and new. The new city structure has been integrated without disturbing the historical texture, and it has a beautiful harmony with the botanical gardens that cannot be seen in many parts of the world. The old city is surrounded by city walls. As soon as you enter the old city, Marrakech's real environment is taken into consideration. And of course, when it is called Medina, the famous Djemaa El Fna Square, which comes to mind first, is entered here.",
                    Photo="/img/marakes.jpg"}
                };

                context.Movies.AddRange(movies);
                var movieCategory = new[]
                {
                    new MovieCategory{ Movie=movies[0], Category=categories[2]},
                    new MovieCategory{ Movie=movies[1], Category=categories[4]},
                    new MovieCategory{ Movie=movies[2], Category=categories[1]},
                    new MovieCategory{ Movie=movies[3], Category=categories[0]},
                    new MovieCategory{ Movie=movies[4], Category=categories[3]},
                    new MovieCategory{ Movie=movies[5], Category=categories[4]},
                    new MovieCategory{ Movie=movies[6], Category=categories[4]},
                    new MovieCategory{ Movie=movies[7], Category=categories[0]},
                    new MovieCategory{ Movie=movies[8], Category=categories[1]},
                    new MovieCategory{ Movie=movies[9], Category=categories[6]},
                    new MovieCategory{ Movie=movies[10], Category=categories[5]},
                    new MovieCategory{ Movie=movies[11], Category=categories[2]},
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