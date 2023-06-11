using System;
using DBSample.EF;


namespace DBSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleDbContext contexts = new ExampleDbContext();

            foreach(var ShohinModel in contexts.shohinModel)
            {
                Console.WriteLine("shohin_id:{0}, shohin_mei:{1}, shohin_bunrui:{2}, hanbai_tanka:{3}, shiire_tanka:{4}, torokubi:{5}", 
                                        ShohinModel.Shohin_Id, ShohinModel.Shohin_Mei, ShohinModel.Shohin_Bunrui, ShohinModel.Hanbai_Tanka, ShohinModel.Shiire_Tanka, ShohinModel.Torokubi);
            }
        }
    }
}


