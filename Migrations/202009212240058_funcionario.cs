namespace TemplateBootstrap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class funcionario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.funcionarioModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Endereco = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.funcionarioModels");
        }
    }
}
