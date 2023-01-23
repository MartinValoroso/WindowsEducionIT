namespace WindowsEducionIT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Detalles", "Planilla_IdPlanilla", "dbo.Planillas");
            DropIndex("dbo.Detalles", new[] { "Planilla_IdPlanilla" });
            DropColumn("dbo.Detalles", "Planilla_IdPlanilla");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Detalles", "Planilla_IdPlanilla", c => c.Int());
            CreateIndex("dbo.Detalles", "Planilla_IdPlanilla");
            AddForeignKey("dbo.Detalles", "Planilla_IdPlanilla", "dbo.Planillas", "IdPlanilla");
        }
    }
}
