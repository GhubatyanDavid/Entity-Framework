using ComputerDatabase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System.Diagnostics.Metrics;

class Programm
{
    static async Task Main(string[] args)
    {
        using (DatabaseContext db = new DatabaseContext())
        {
            //1 /*Найдите номер модели, скорость и размер жесткого диска для всех ПК стоимостью менее 500 дол. Вывести: model, speed и hd*/
            //var comp =  db.Pc
            //    .Where(pcs => pcs.Price >= 500)
            //    .Select(pcs=> new {pcs.Model,pcs.Speed,pcs.Hd})
            //    .ToList();
            //foreach (var pcs in comp)
            //{
            //    Console.WriteLine($"Model Number`{pcs.Model},Speed`{pcs.Speed},HDD Length`{pcs.Hd}");
            //}

            //2 /*Найдите производителей принтеров.Вывести: maker*/ //sxal-erevi
            //var Print = db.Printer;
            //var Products = db.Product
            //    .Where(print => print.Type == "Printer")
            //    .Select(Prod => Prod.Maker)
            //    .ToList();
            //foreach (var Prod in Products)
            //{
            //    Console.WriteLine($"Model Number`{Prod.Maker}");
            //}

            //3 /*Найдите номер модели, объем памяти и размеры экранов ПК-блокнотов, цена которых превышает 1000 дол.   model,ram,screen*/
            //var laptops =  db.Laptop
            //    .Where(laptops => laptops.Price > 1000)
            //    .Select(laptops => new { laptops.Model, laptops.Ram, laptops.Screen })
            //    .ToList();
            //foreach (var laptop in laptops)
            //{
            //    Console.WriteLine($"{laptop.Model}");
            //}

            //4 /*Найдите все записи таблицы Printer для цветных принтеров.*/
            //var printers = db.Printer
            //    .Where(printers => printers.Color == "y")
            //    .ToList();
            //foreach (var printer in printers)
            //{
            //    Console.WriteLine($"{printer.Code}, {printer.Color}, {printer.Price} {printer.Model}");
            //}

            //5 /*Найдите номер модели, скорость и размер жесткого диска ПК, имеющих 12x или 24x CD и цену менее 600 дол.*/
            //var pcs = db.Pc
            //  .Where(pcs=> pcs.Cd=="12x" | pcs.Cd=="24x" & pcs.Price < 600)
            //  .Select(pcs => new {pcs.Model,pcs.Speed,pcs.Hd})
            //  .ToList();
            //foreach(var pc in pcs)
            //{
            //  Console.WriteLine(pc.Model,pc.Speed,pc.Hd);
            //}
            //6 /*Для каждого производителя, выпускающего ПК-блокноты c объёмом жесткого диска не менее 10 Гбайт, найти скорости таких ПК-блокнотов. Вывод: производитель, скорость.*/

            //var laptops = from Laptop in db.Laptop
            //              join model in db.Product on Laptop.Model equals model.Model
            //              select new
            //              {
            //                  Maker = model.Maker,
            //                  Speed = Laptop.Speed,

            //              };
            //foreach (var laptop in laptops)
            //{
            //    Console.WriteLine(laptop.Maker, laptop.Speed);
            //}

            //7 /*Найдите номера моделей и цены всех имеющихся в продаже продуктов (любого типа) производителя B (латинская буква).*/
            //var product = from Product in db.Product
            //              join pc in db.Pc on product.Model equals pc.Model
            //              .Where Product.maker = "B"
            //             .Union(db.Laptop)
            //              join laptop in db.Laptop on product.Model equals laptop.Model
            //              .Where Product.maker == "B"
            //              .Union(db.Printer)
            //              join printer in db.Printer on product.Model equals printer.Model
            //              .Where Product.maker == "B";

            //              select new
            //              {
            //                  pcModel = pc.model,
            //                  pcPrice = pc.price,
            //                  laptopModel = laptop.model,
            //                  latopPrice = laptop.price,
            //                  printerModel = printer.model,
            //                  printerPrice = printer.price,
            //              };

            //8 /*Найдите производителя, выпускающего ПК, но не ПК-блокноты.*/
            //var firstProducts = db.Product.Where(firstProducts => firstProducts.Type == "PC")
            //var secondProducts=db.Product.Where(firstProducts=>firstProducts.Type == "Laptop")
            //var except = firstproducts.Except(secondProducts).ToList();

            //9 /*Найдите производителей ПК с процессором не менее 450 Мгц. Вывести: Maker */
            //var products = from Product in db.Product.Where(products => products.Speed>=450)
            //               join pc in db.Pc on products.Model == pc.Model

            //10 /*Найдите модели принтеров, имеющих самую высокую цену. Вывести: model, price */
            //SELECT DISTINCT model, price FROM Printer
            //WHERE price = (SELECT MAX(price) FROM Printer)
            //var printers = db.Printer
            //int maxPrice = db.Printer.Max(max => max.Price);
            //select new
            //{
            //    model = printers.Model,
            //    price = maxPrice,
            //}

        }
    }
}


