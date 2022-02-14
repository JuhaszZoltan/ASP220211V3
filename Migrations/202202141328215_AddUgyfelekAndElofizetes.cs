namespace ASP220211V3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUgyfelekAndElofizetes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ElofizetesTipusok",
                c => new
                    {
                        EloofizetesTipusId = c.Int(nullable: false, identity: true),
                        Nev = c.String(nullable: false, maxLength: 10, unicode: false),
                        Ar = c.Int(nullable: false),
                        HonapokSzama = c.Int(nullable: false),
                        TermekKedvezmeny = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EloofizetesTipusId);
            
            CreateTable(
                "dbo.Ugyfelek",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nev = c.String(nullable: false, maxLength: 60, unicode: false),
                        Szul = c.DateTime(nullable: false, storeType: "date"),
                        HirleveletKap = c.Boolean(nullable: false),
                        ElofizetesKezdete = c.DateTime(storeType: "date"),
                        ElofizetesTipus_EloofizetesTipusId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ElofizetesTipusok", t => t.ElofizetesTipus_EloofizetesTipusId)
                .Index(t => t.ElofizetesTipus_EloofizetesTipusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ugyfelek", "ElofizetesTipus_EloofizetesTipusId", "dbo.ElofizetesTipusok");
            DropIndex("dbo.Ugyfelek", new[] { "ElofizetesTipus_EloofizetesTipusId" });
            DropTable("dbo.Ugyfelek");
            DropTable("dbo.ElofizetesTipusok");
        }
    }
}
