using Infrastructure.Context;
using Infrastructure.Entities;
using System;
using System.Collections.Specialized;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

class Programm
{
    static void Main(string[] args)
    {
        using (DatabaseContext db = new DatabaseContext())
        {
            ////            //1 /*Найдите номер модели, скорость и размер жесткого диска для всех ПК стоимостью менее 500 дол. Вывести: model, speed и hd*/
            //{

            //    var comp = db.Pc
            //        .Where(pcs => pcs.Price >= 500)
            //        .Select(pcs => new { pcs.Model, pcs.Speed, pcs.Hd })
            //        .ToList();
            //    foreach (var pc in comp)
            //    {
            //        Console.WriteLine($"Model Number`{pc.Model},Speed`{pc.Speed},HDD Length`{pc.Hd}");
            //    }
            //}
            ////            //2 /*Найдите производителей принтеров.Вывести: maker*/
            //{

            //    var printers = from p in db.Printer
            //                   join products in db.Product on p.Type equals products.Type
            //                   where (p.Type == "Printer")
            //                   select (products.Maker);
            //}
            ////            //3 /*Найдите номер модели, объем памяти и размеры экранов ПК-блокнотов, цена которых превышает 1000 дол.   model,ram,screen*/
            //{
            //    var laptops = from l in db.Laptop
            //                  where (l.Price > 1000)
            //                  select new
            //                  {
            //                      l.Model,
            //                      l.Ram,
            //                      l.Screen
            //                  };
            //    foreach (var laptop in laptops)
            //    {
            //        Console.WriteLine($"{laptop.Model}");
            //    }
            //}
            ////            //4 /*Найдите все записи таблицы Printer для цветных принтеров.*/
            //{
            //    var printers = db.Printer
            //        .Where(p => p.Color == "y")
            //        .ToList();
            //    foreach (var printer in printers)
            //    {
            //        Console.WriteLine($"{printer.Code}, {printer.Color}, {printer.Price} {printer.Model}");
            //    }
            //}
            ////            //5 /*Найдите номер модели, скорость и размер жесткого диска ПК, имеющих 12x или 24x CD и цену менее 600 дол.*/
            //{
            //    var pcs = db.Pc
            //      .Where(p => p.Cd == "12x" | p.Cd == "24x" & p.Price < 600)
            //      .Select(p => new { p.Model, p.Speed, p.Hd })
            //      .ToList();
            //    foreach (var pc in pcs)
            //    {
            //        Console.WriteLine(pc.Model, pc.Speed, pc.Hd);
            //    }
            //}
            ////            //6 /*Для каждого производителя, выпускающего ПК-блокноты c объёмом жесткого диска не менее 10 Гбайт, найти скорости таких ПК-блокнотов. Вывод: производитель, скорость.*/
            //{
            //    var laptops = from l in db.Laptop
            //                  join p in db.Product on l.Model equals p.Model
            //                  select new
            //                  {
            //                      Maker = p.Maker,
            //                      Speed = l.Speed,

            //                  };
            //    foreach (var laptop in laptops)
            //    {
            //        Console.WriteLine(laptop.Maker, laptop.Speed);
            //    }
            //}
            ////            //7 /*Найдите номера моделей и цены всех имеющихся в продаже продуктов (любого типа) производителя B (латинская буква).*/  /ERROR
            //{
            //    var product = (from p in db.Product
            //                   join pc in db.Pc on p.Model equals pc.Model
            //                   where p.Maker == "B"
            //                   select new
            //                   {
            //                       pc.Model,
            //                       pc.Price
            //                   })
            //                   .Union(
            //                  from p in db.Product
            //                  join l in db.Laptop on p.Model equals l.Model
            //                  where p.Maker == "B"
            //                  select new
            //                  {
            //                      l.Model,
            //                      l.Price
            //                  })
            //                  .Union(
            //                    from p in db.Product
            //                    join printers in db.Printer on p.Model equals printers.Model
            //                    where p.Maker == "B"

            //                    select new
            //                    {
            //                        printers.Model,
            //                        printers.Price
            //                    });
            //}
            ////            //8 /*Найдите производителя, выпускающего ПК, но не ПК-блокноты.*/
            //{
            //    var firstProducts = (from fP in db.Product
            //                         where fP.Type == "PC"
            //                         select fP.Maker)
            //                         .Except(
            //                        from sP in db.Product
            //                        where sP.Type == "Laptop"
            //                        select sP.Maker);
            //    foreach (var items in firstProducts)
            //    {
            //        Console.WriteLine(items);
            //    }
            //}
            ////            //9 /*Найдите производителей ПК с процессором не менее 450 Мгц. Вывести: Maker */
            //{
            //    var products = from p in db.Product
            //                   join pc in db.Pc on p.Model equals pc.Model
            //                   where pc.Speed >= 450
            //                   select new
            //                   {
            //                       pMaker = p.Maker
            //                   };
            //}
            ////            //10 /*Найдите модели принтеров, имеющих самую высокую цену. Вывести: model, price */
            //{


            //    var maxPrice = db.Printer.Max(max => max.Price);
            //    var printers = from p in db.Printer
            //                   where p.Price == maxPrice
            //                   select new
            //                   {
            //                       model = p.Model,
            //                       price = p.Price,
            //                   };

            //}
            ////            //12 /*Найдите среднюю скорость ПК.*/
            //{
            //    var avgSpeed = db.Pc.Average(avgSpeed => avgSpeed.Price);
            //}
            ////            //13 /* Найдите среднюю скорость ПК-блокнотов, цена которых превышает 1000 дол.*/
            //{
            //    var avgSpeed = db.Laptop.Where(avgSpeed => avgSpeed.Price > 1000).Average(avgSpeed => avgSpeed.Price);
            //}
            ////            //14 /* Найдите среднюю скорость ПК, выпущенных производителем A.*/
            //{
            //    var query = (from pc in db.Pc
            //                 join product in db.Product on pc.Model equals product.Model
            //                 where product.Maker == "A"
            //                 select pc.Speed);

            //    var avgSpeed = query.Average(speed => speed);
            //}
            ////            //15 /*Найдите размеры жестких дисков, совпадающих у двух и более PC. Вывести: HD  */
            //{
            //    var lengths = from pc in db.Pc
            //                  .GroupBy(pc => pc.Hd)
            //                  .Where(hd => hd.Count() > 1)
            //                  select pc;
            //}
            ////            //16 /*Найдите модели ПК-блокнотов, скорость которых меньше скорости каждого из ПК. Вывести: type, model, speed*/
            //{
            //    var minSpeed = db.Pc.Min(min => min.Speed);
            //    var laptops = from lp in db.Laptop
            //                  join p in db.Product on lp.Model equals p.Model
            //                  where lp.Speed < minSpeed
            //                  select new
            //                  {
            //                      p.Type,
            //                      lp.Speed,
            //                      lp.Model
            //                  };
            //}
            ////            //17 /*Найдите производителей самых дешевых цветных принтеров. Вывести: maker, price*/
            //{
            //    var minPrice = db.Printer.Min(min => min.Price);
            //    var products = from p in db.Product
            //                   join printer in db.Printer on p.Model equals printer.Model
            //                   where printer.Color == "y" & printer.Price == minPrice
            //                   select new
            //                   {
            //                       p.Maker,
            //                       printer.Price,
            //                   };
            //}
            ////            //18 /*Для каждого производителя, имеющего модели в таблице Laptop, найдите средний размер экрана выпускаемых им ПК-блокнотов.Вывести: maker, средний размер экрана.*/
            //{
            //    var averageScreen = db.Laptop.Average(avg => avg.Screen);
            //    var products = from p in db.Product
            //                   join l in db.Laptop on p.Model equals l.Model
            //                   where p.Type == "Laptop"
            //                   group p by p.Maker into p
            //                   select new
            //                   {
            //                       averageScreen,
            //                       //p.Maker
            //                   };
            //}
            ////            //19 /*Найдите максимальную цену ПК, выпускаемых каждым производителем, у которого есть модели в таблице PC. Вывести: maker, максимальная цена.*/
            {

                var pcs = (from pc in db.Pc
                          join product in db.Product on pc.Model equals product.Model
                          group pc by product.Maker into p
                          select new
                          {
                              Maker = p.Key,
                              MaxPrice = p.Average(i => i.Price)

                          }).ToList();
            }


            //           //20 /*Для каждого значения скорости ПК, превышающего 600 МГц, определите среднюю цену ПК с такой же скоростью. Вывести: speed, средняя цена. */ 
            {
                var avgPrice = db.Pc.Average(avg => avg.Price);
                var pcs = from p in db.Pc
                          where p.Speed > 600
                          group p by p.Speed;
            }
        }
    }
}


public static class Extention
{
    public static double OrderBy_V2(this IQueryable<short> array)
    {
        double sum = 0;

        foreach (var speed in array)
        {
            sum += speed;
        }

        return sum / array.Count();
    }

    public static double Average_V2(this IQueryable<short> array)
    {
        double sum = 0;

        foreach (var speed in array)
        {
            sum += speed;
        }

        return sum / array.Count();
    }

    public static double Average_V2(this IEnumerable<short> array)
    {
        double sum = 0;

        foreach (var speed in array)
        {
            sum += speed;
        }

        return sum / array.Count() / array.Sum(s => s);
    }
}




