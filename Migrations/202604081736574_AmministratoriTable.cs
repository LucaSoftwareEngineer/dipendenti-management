namespace dipendenti_management.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AmministratoriTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.amministatori",
                c => new
                    {
                        amm_id = c.Int(nullable: false, identity: true),
                        amm_username = c.String(),
                        amm_password = c.String(),
                    })
                .PrimaryKey(t => t.amm_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.amministatori");
        }
    }
}
