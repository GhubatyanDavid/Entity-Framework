using ComputerDatabase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System.Diagnostics.Metrics;
using System.Linq;

class Programm
{
    static void Main(string[] args)
    {
        using (DatabaseContext db = new DatabaseContext())
        {
            //1 /*Найдите номер модели, скорость и размер жесткого диска для всех ПК стоимостью менее 500 дол. Вывести: model, speed и hd*/
            {

                var comp = db.Pcs
                    .Where(pcs => pcs.Price >= 500)
                    .Select(pcs => new { pcs.Model, pcs.Speed, pcs.Hd })
                    .ToList();
                foreach (var pc in comp)
                {
                    Console.WriteLine($"Model Number`{pc.Model},Speed`{pc.Speed},HDD Length`{pc.Hd}");
                }
            }
            //2 /*Найдите производителей принтеров.Вывести: maker*/
            {

                var printers = from p in db.Printers
                               join products in db.Products on p.Type equals products.Type
                               where (p.Type == "Printer")
                               select (products.Maker);
            }
            //3 /*Найдите номер модели, объем памяти и размеры экранов ПК-блокнотов, цена которых превышает 1000 дол.   model,ram,screen*/
            {
                var laptops = db.Laptops
                    .Where(l => l.Price > 1000)
                    .Select(l => new { l.Model, l.Ram, l.Screen })
                    .ToList();
                foreach (var laptop in laptops)
                {
                    Console.WriteLine($"{laptop.Model}");
                }
            }
            //4 /*Найдите все записи таблицы Printer для цветных принтеров.*/
            {
                var printers = db.Printers
                    .Where(p => p.Color == "y")
                    .ToList();
                foreach (var printer in printers)
                {
                    Console.WriteLine($"{printer.Code}, {printer.Color}, {printer.Price} {printer.Model}");
                }
            }
            //5 /*Найдите номер модели, скорость и размер жесткого диска ПК, имеющих 12x или 24x CD и цену менее 600 дол.*/
            {
                var pcs = db.Pcs
                  .Where(p => p.Cd == "12x" | p.Cd == "24x" & p.Price < 600)
                  .Select(p => new { p.Model, p.Speed, p.Hd })
                  .ToList();
                foreach (var pc in pcs)
                {
                    Console.WriteLine(pc.Model, pc.Speed, pc.Hd);
                }
            }
            //6 /*Для каждого производителя, выпускающего ПК-блокноты c объёмом жесткого диска не менее 10 Гбайт, найти скорости таких ПК-блокнотов. Вывод: производитель, скорость.*/
            {
                var laptops = from l in db.Laptops
                              join p in db.Products on l.Model equals p.Model
                              select new
                              {
                                  Maker = p.Maker,
                                  Speed = l.Speed,

                              };
                foreach (var laptop in laptops)
                {
                    Console.WriteLine(laptop.Maker, laptop.Speed);
                }
            }
            //7 /*Найдите номера моделей и цены всех имеющихся в продаже продуктов (любого типа) производителя B (латинская буква).*/  /ERROR
            {
                var product = from p in db.Products
                              join pc in db.Pcs on p.Model equals pc.Model
                              where p.Maker = "B"
                             .Union(db.Laptops)
                              join l in db.Laptops on p.Model equals l.Model
                              where p.maker == "B"
                             .Union(db.Printers)
                              join printers in db.Printers on p.Model equals printers.Model
                              where printers.maker == "B"

                              select new
                              {
                                  pcModel = pc.model,
                                  pcPrice = pc.price,
                                  laptopModel = l.model,
                                  latopPrice = l.price,
                                  printerModel = printers.model,
                                  printerPrice = printers.price,
                              };
            }
            //8 /*Найдите производителя, выпускающего ПК, но не ПК-блокноты.*/
            {
                var firstProducts = db.Products.Where(p => p.Type == "PC");
                var secondProducts = db.Products.Where(p => p.Type == "Laptop");
                var except = firstProducts.Except(secondProducts).ToList();



            }
            //9 /*Найдите производителей ПК с процессором не менее 450 Мгц. Вывести: Maker */
            {
                var products = from p in db.Products
                               join pc in db.Pcs on p.Model equals pc.Model
                               where pc.Speed >= 450
                               select new
                               {
                                   pMaker = p.Maker
                               };
            }
            //10 /*Найдите модели принтеров, имеющих самую высокую цену. Вывести: model, price */
            {
                var maxPrice = db.Printers.Max(max => max.Price);
                var printers = from p in db.Printers

                               select new
                               {
                                   model = p.Model,
                                   price = maxPrice,
                               };
            }
            //12 /*Найдите среднюю скорость ПК.*/
            {
                var avgSpeed = db.Pcs.Average(avgSpeed => avgSpeed.Price);
            }
            //13 /* Найдите среднюю скорость ПК-блокнотов, цена которых превышает 1000 дол.*/
            {
                var avgSpeed = db.Laptops.Where(avgSpeed => avgSpeed.Price > 1000).Average(avgSpeed => avgSpeed.Price);
            }
            //14 /* Найдите среднюю скорость ПК, выпущенных производителем A.*/
            {
                var pcs = from p in db.Pcs
                          join products in db.Products on p.Model equals products.Model
                          where products.Maker == "A"
                          select new
                          {
                              avgSpeed = db.Pcs.Average(avgspeed => avgspeed.Price)
                          };

            }
            //15 /*Найдите размеры жестких дисков, совпадающих у двух и более PC. Вывести: HD  */
            {

            }

            //16 /*Найдите модели ПК-блокнотов, скорость которых меньше скорости каждого из ПК. Вывести: type, model, speed*/
            {

            }

            //17 /*Найдите производителей самых дешевых цветных принтеров. Вывести: maker, price*/
            {

            }

            //18 /*Для каждого производителя, имеющего модели в таблице Laptop, найдите средний размер экрана выпускаемых им ПК-блокнотов.Вывести: maker, средний размер экрана.*/
            {

            }
        }
    }
}



