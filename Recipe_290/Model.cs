using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DBSample.MD
{
    [Table("shohin")]
    public class ShohinModel
    {
        [Key]
        [Column("shohin_id")]
        public string Shohin_Id { set; get; }
        [Column("shohin_mei")]
        public string Shohin_Mei { set; get; }
        [Column("shohin_bunrui")]
        public string Shohin_Bunrui { set; get; }
        [Column("hanbai_tanka")]
        public int? Hanbai_Tanka { set; get; }
        [Column("shiire_tanka")]
        public int? Shiire_Tanka { set; get; }
        [Column("torokubi")]
        public DateTime? Torokubi { set; get; }
    }
}
