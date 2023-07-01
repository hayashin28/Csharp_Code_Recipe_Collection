using System.Runtime.CompilerServices;
using System.Threading;
using System;
using DBSample.EF;


namespace DBSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // クエリ式のケース
            using (ExampleDbContext contexts = new ExampleDbContext())
            {
                var result =
                    from  shohin in contexts.shohinModel
                    join  tenpoShohin in contexts.tenpoShohinModel
                    on    shohin.Shohin_Id equals tenpoShohin.Shohin_Id
                    select new {
                        tenpoShohin.Tenpo_Id
                    ,   tenpoShohin.Tenpo_Mei
                    ,   tenpoShohin.Shohin_Id
                    ,   shohin.Shohin_Mei
                    ,   shohin.Shohin_Bunrui
                    ,   shohin.Shiire_Tanka
                    ,   tenpoShohin.Suryo
                    };
                    
                foreach(var item in result)
                {
                    Console.WriteLine("tenpo_id:{0}, tenpo_mei:{1}, shohin_id:{2}, shohin_mei:{3}, shohin_bunrui:{4}, shiire_tanka:{5}, suryo:{6}", 
                                        item.Tenpo_Id, item.Tenpo_Mei, item.Shohin_Id, item.Shohin_Mei, item.Shohin_Bunrui, item.Shiire_Tanka, item.Suryo);
                }
            }
        }
    }
}
