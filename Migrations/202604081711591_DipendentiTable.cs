namespace dipendenti_management.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DipendentiTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.dipendenti",
                c => new
                    {
                        dip_id = c.Int(nullable: false, identity: true),
                        dip_nome = c.String(),
                        dip_cognome = c.String(),
                        dip_data_nascita = c.DateTime(nullable: false),
                        dip_luogo_nascita = c.String(),
                    })
                .PrimaryKey(t => t.dip_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.dipendenti");
        }
    }
}
