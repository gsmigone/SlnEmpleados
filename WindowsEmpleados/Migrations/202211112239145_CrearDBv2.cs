namespace WindowsEmpleados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearDBv2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Clientes", newName: "Persona");
            RenameTable(name: "dbo.Departamentoes", newName: "Departamento");
            RenameTable(name: "dbo.Empleadoes", newName: "Empleado");
            DropForeignKey("dbo.Empleadoes", "Departamento_Id", "dbo.Departamentoes");
            DropIndex("dbo.Empleado", new[] { "Departamento_Id" });
            RenameColumn(table: "dbo.Empleado", name: "Departamento_Id", newName: "IdDepartamento");
            AddColumn("dbo.Departamento", "IdEmpleado", c => c.Int(nullable: false));
            AlterColumn("dbo.Persona", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Persona", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Departamento", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Empleado", "Legajo", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Empleado", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Empleado", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Empleado", "IdDepartamento", c => c.Int(nullable: false));
            CreateIndex("dbo.Empleado", "IdDepartamento");
            AddForeignKey("dbo.Empleado", "IdDepartamento", "dbo.Departamento", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Empleado", "IdDepartamento", "dbo.Departamento");
            DropIndex("dbo.Empleado", new[] { "IdDepartamento" });
            AlterColumn("dbo.Empleado", "IdDepartamento", c => c.Int());
            AlterColumn("dbo.Empleado", "Apellido", c => c.String());
            AlterColumn("dbo.Empleado", "Nombre", c => c.String());
            AlterColumn("dbo.Empleado", "Legajo", c => c.String());
            AlterColumn("dbo.Departamento", "Nombre", c => c.String());
            AlterColumn("dbo.Persona", "Apellido", c => c.String());
            AlterColumn("dbo.Persona", "Nombre", c => c.String());
            DropColumn("dbo.Departamento", "IdEmpleado");
            RenameColumn(table: "dbo.Empleado", name: "IdDepartamento", newName: "Departamento_Id");
            CreateIndex("dbo.Empleado", "Departamento_Id");
            AddForeignKey("dbo.Empleadoes", "Departamento_Id", "dbo.Departamentoes", "Id");
            RenameTable(name: "dbo.Empleado", newName: "Empleadoes");
            RenameTable(name: "dbo.Departamento", newName: "Departamentoes");
            RenameTable(name: "dbo.Persona", newName: "Clientes");
        }
    }
}
