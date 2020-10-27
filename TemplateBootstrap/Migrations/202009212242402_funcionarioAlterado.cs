namespace TemplateBootstrap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class funcionarioAlterado : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.funcionarioModels", "Sexo");
            DropColumn("dbo.funcionarioModels", "Idade");
        }
        
        public override void Down()
        {
            AddColumn("dbo.funcionarioModels", "Idade", c => c.Int(nullable: false));
            AddColumn("dbo.funcionarioModels", "Sexo", c => c.String());
        }
    }
}
