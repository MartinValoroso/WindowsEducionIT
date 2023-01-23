namespace WindowsEducionIT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carreras",
                c => new
                    {
                        IDCarrera = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IDCarrera);
            
            CreateTable(
                "dbo.Planillas",
                c => new
                    {
                        IdPlanilla = c.Int(nullable: false, identity: true),
                        IDCarrera = c.Int(nullable: false),
                        IDMateria = c.Int(nullable: false),
                        IDProfesor = c.Int(nullable: false),
                        IDCurso = c.Int(nullable: false),
                        Fecha = c.DateTime(),
                    })
                .PrimaryKey(t => t.IdPlanilla)
                .ForeignKey("dbo.Carreras", t => t.IDCarrera, cascadeDelete: true)
                .ForeignKey("dbo.Cursoes", t => t.IDCurso, cascadeDelete: true)
                .ForeignKey("dbo.Profesors", t => t.IDProfesor, cascadeDelete: true)
                .ForeignKey("dbo.Materias", t => t.IDMateria, cascadeDelete: true)
                .Index(t => t.IDCarrera)
                .Index(t => t.IDMateria)
                .Index(t => t.IDProfesor)
                .Index(t => t.IDCurso);
            
            CreateTable(
                "dbo.Cursoes",
                c => new
                    {
                        IDCurso = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IDCurso);
            
            CreateTable(
                "dbo.Detalles",
                c => new
                    {
                        IdDetalle = c.Int(nullable: false, identity: true),
                        IDEstado = c.Int(nullable: false),
                        Planilla_IdPlanilla = c.Int(),
                    })
                .PrimaryKey(t => t.IdDetalle)
                .ForeignKey("dbo.Estadoes", t => t.IDEstado, cascadeDelete: true)
                .ForeignKey("dbo.Planillas", t => t.Planilla_IdPlanilla)
                .Index(t => t.IDEstado)
                .Index(t => t.Planilla_IdPlanilla);
            
            CreateTable(
                "dbo.Estadoes",
                c => new
                    {
                        IdEstado = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IdEstado);
            
            CreateTable(
                "dbo.Evaluacions",
                c => new
                    {
                        IDEvaluacion = c.Int(nullable: false, identity: true),
                        IDTipo = c.Int(nullable: false),
                        IDEstudiante = c.Int(nullable: false),
                        IDDetalle = c.Int(nullable: false),
                        Nota = c.String(),
                    })
                .PrimaryKey(t => t.IDEvaluacion)
                .ForeignKey("dbo.Detalles", t => t.IDDetalle, cascadeDelete: true)
                .ForeignKey("dbo.Estudiantes", t => t.IDEstudiante, cascadeDelete: true)
                .ForeignKey("dbo.Tipoes", t => t.IDTipo, cascadeDelete: true)
                .Index(t => t.IDTipo)
                .Index(t => t.IDEstudiante)
                .Index(t => t.IDDetalle);
            
            CreateTable(
                "dbo.Estudiantes",
                c => new
                    {
                        IDEstudiante = c.Int(nullable: false, identity: true),
                        IDLocalidad = c.Int(nullable: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Telefono = c.String(),
                        Calle = c.String(),
                        Numero = c.String(),
                    })
                .PrimaryKey(t => t.IDEstudiante)
                .ForeignKey("dbo.Localidads", t => t.IDLocalidad, cascadeDelete: true)
                .Index(t => t.IDLocalidad);
            
            CreateTable(
                "dbo.Localidads",
                c => new
                    {
                        IDLocalidad = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IDLocalidad);
            
            CreateTable(
                "dbo.Profesors",
                c => new
                    {
                        IDProfesor = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        IDLocalidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDProfesor)
                .ForeignKey("dbo.Localidads", t => t.IDLocalidad, cascadeDelete: true)
                .Index(t => t.IDLocalidad);
            
            CreateTable(
                "dbo.Tipoes",
                c => new
                    {
                        IDTipo = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IDTipo);
            
            CreateTable(
                "dbo.Materias",
                c => new
                    {
                        IDMateria = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IDMateria);
            
            CreateTable(
                "dbo.Plans",
                c => new
                    {
                        IDPlan = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        IDCarrera = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDPlan)
                .ForeignKey("dbo.Carreras", t => t.IDCarrera, cascadeDelete: true)
                .Index(t => t.IDCarrera);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Plans", "IDCarrera", "dbo.Carreras");
            DropForeignKey("dbo.Planillas", "IDMateria", "dbo.Materias");
            DropForeignKey("dbo.Detalles", "Planilla_IdPlanilla", "dbo.Planillas");
            DropForeignKey("dbo.Evaluacions", "IDTipo", "dbo.Tipoes");
            DropForeignKey("dbo.Planillas", "IDProfesor", "dbo.Profesors");
            DropForeignKey("dbo.Profesors", "IDLocalidad", "dbo.Localidads");
            DropForeignKey("dbo.Estudiantes", "IDLocalidad", "dbo.Localidads");
            DropForeignKey("dbo.Evaluacions", "IDEstudiante", "dbo.Estudiantes");
            DropForeignKey("dbo.Evaluacions", "IDDetalle", "dbo.Detalles");
            DropForeignKey("dbo.Detalles", "IDEstado", "dbo.Estadoes");
            DropForeignKey("dbo.Planillas", "IDCurso", "dbo.Cursoes");
            DropForeignKey("dbo.Planillas", "IDCarrera", "dbo.Carreras");
            DropIndex("dbo.Plans", new[] { "IDCarrera" });
            DropIndex("dbo.Profesors", new[] { "IDLocalidad" });
            DropIndex("dbo.Estudiantes", new[] { "IDLocalidad" });
            DropIndex("dbo.Evaluacions", new[] { "IDDetalle" });
            DropIndex("dbo.Evaluacions", new[] { "IDEstudiante" });
            DropIndex("dbo.Evaluacions", new[] { "IDTipo" });
            DropIndex("dbo.Detalles", new[] { "Planilla_IdPlanilla" });
            DropIndex("dbo.Detalles", new[] { "IDEstado" });
            DropIndex("dbo.Planillas", new[] { "IDCurso" });
            DropIndex("dbo.Planillas", new[] { "IDProfesor" });
            DropIndex("dbo.Planillas", new[] { "IDMateria" });
            DropIndex("dbo.Planillas", new[] { "IDCarrera" });
            DropTable("dbo.Plans");
            DropTable("dbo.Materias");
            DropTable("dbo.Tipoes");
            DropTable("dbo.Profesors");
            DropTable("dbo.Localidads");
            DropTable("dbo.Estudiantes");
            DropTable("dbo.Evaluacions");
            DropTable("dbo.Estadoes");
            DropTable("dbo.Detalles");
            DropTable("dbo.Cursoes");
            DropTable("dbo.Planillas");
            DropTable("dbo.Carreras");
        }
    }
}
