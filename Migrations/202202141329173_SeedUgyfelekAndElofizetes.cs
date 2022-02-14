namespace ASP220211V3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUgyfelekAndElofizetes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ElofizetesTipusok VALUES ('Bronze', 0, 0, 0);");
            Sql("INSERT INTO ElofizetesTipusok VALUES ('Silver', 1500, 1, 5);");
            Sql("INSERT INTO ElofizetesTipusok VALUES ('Gold', 8000, 6, 10);");
            Sql("INSERT INTO ElofizetesTipusok VALUES ('Platinum', 15000, 12, 20);");

            Sql("INSERT INTO Ugyfelek VALUES ('Csorba Edina',       '1985-11-15', 1, null,         1);");
            Sql("INSERT INTO Ugyfelek VALUES ('Gárdonyi Cili',      '1987-11-30', 1, null,         1);");
            Sql("INSERT INTO Ugyfelek VALUES ('Seres Krisztofer',   '1989-06-06', 1, '2021-10-02', 2);");
            Sql("INSERT INTO Ugyfelek VALUES ('Bartha Ödön',        '1994-09-06', 0, null,         1);");
            Sql("INSERT INTO Ugyfelek VALUES ('Bognár Vivien',      '1996-07-08', 0, '2021-12-21', 4);");
            Sql("INSERT INTO Ugyfelek VALUES ('Sólyom András ',     '1999-08-06', 1, '2022-01-15', 3);");
            Sql("INSERT INTO Ugyfelek VALUES ('Jakab Mari',         '2001-12-14', 0, null,         1);");
            Sql("INSERT INTO Ugyfelek VALUES ('Fehér Alexander',    '2009-02-20', 1, '2022-01-22', 3);");
            Sql("INSERT INTO Ugyfelek VALUES ('Gáspár Szilveszter', '2010-10-16', 0, null,         1);");
            Sql("INSERT INTO Ugyfelek VALUES ('Mátyás Virág',       '2011-11-07', 1, '2022-02-05', 2);");

        }

        public override void Down()
        {
        }
    }
}
