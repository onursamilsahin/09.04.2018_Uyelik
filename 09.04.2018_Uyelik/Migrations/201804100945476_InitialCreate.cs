namespace _09._04._2018_Uyelik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Makale",
                c => new
                    {
                        MakaleId = c.Int(nullable: false, identity: true),
                        Baslik = c.String(),
                        Aciklama = c.String(),
                        EklenmeTarihi = c.DateTime(nullable: false),
                        YorumID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MakaleId);
            
            CreateTable(
                "dbo.Yorum",
                c => new
                    {
                        YorumId = c.Int(nullable: false, identity: true),
                        Icerik = c.String(nullable: false),
                        Tarih = c.DateTime(nullable: false),
                        Makale_MakaleId = c.Int(),
                    })
                .PrimaryKey(t => t.YorumId)
                .ForeignKey("dbo.Makale", t => t.Makale_MakaleId)
                .Index(t => t.Makale_MakaleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Yorum", "Makale_MakaleId", "dbo.Makale");
            DropIndex("dbo.Yorum", new[] { "Makale_MakaleId" });
            DropTable("dbo.Yorum");
            DropTable("dbo.Makale");
        }
    }
}
