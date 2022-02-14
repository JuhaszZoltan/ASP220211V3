namespace ASP220211V3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddElufizetesTipus : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ElofizetesTipusok");
        }
    }
}
