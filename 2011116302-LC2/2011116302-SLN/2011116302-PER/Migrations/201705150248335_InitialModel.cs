namespace _2011116302_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdministradorEquipoes",
                c => new
                    {
                        AdministradorEquipoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.AdministradorEquipoId);
            
            CreateTable(
                "dbo.EquipoCelulars",
                c => new
                    {
                        EquipoCelularId = c.Int(nullable: false, identity: true),
                        CodigoCelular = c.Int(nullable: false),
                        Marca = c.String(),
                        Modelo = c.String(),
                        Imei = c.String(),
                        Color = c.String(),
                        Precio = c.Double(nullable: false),
                        Stock = c.Int(nullable: false),
                        AdministradorEquipo_AdministradorEquipoId = c.Int(),
                    })
                .PrimaryKey(t => t.EquipoCelularId)
                .ForeignKey("dbo.AdministradorEquipoes", t => t.AdministradorEquipo_AdministradorEquipoId)
                .Index(t => t.AdministradorEquipo_AdministradorEquipoId);
            
            CreateTable(
                "dbo.AdministradorLineas",
                c => new
                    {
                        AdministradorLineaId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.AdministradorLineaId);
            
            CreateTable(
                "dbo.LineaTelefonicas",
                c => new
                    {
                        LineaTelefonicaId = c.Int(nullable: false, identity: true),
                        NumeroTelefonico = c.String(),
                        IcciaTelefonico = c.String(),
                        TipoLinea_TipoLineaId = c.Int(),
                        AdministradorLinea_AdministradorLineaId = c.Int(),
                        Evaluacion_EvaluacionId = c.Int(),
                    })
                .PrimaryKey(t => t.LineaTelefonicaId)
                .ForeignKey("dbo.TipoLineas", t => t.TipoLinea_TipoLineaId)
                .ForeignKey("dbo.AdministradorLineas", t => t.AdministradorLinea_AdministradorLineaId)
                .ForeignKey("dbo.Evaluacions", t => t.Evaluacion_EvaluacionId)
                .Index(t => t.TipoLinea_TipoLineaId)
                .Index(t => t.AdministradorLinea_AdministradorLineaId)
                .Index(t => t.Evaluacion_EvaluacionId);
            
            CreateTable(
                "dbo.TipoLineas",
                c => new
                    {
                        TipoLineaId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.TipoLineaId);
            
            CreateTable(
                "dbo.CentroAtencions",
                c => new
                    {
                        CentroAtencionId = c.Int(nullable: false, identity: true),
                        CodigoCentroAtencion = c.Int(nullable: false),
                        NombreCentroAtencion = c.String(),
                        CodDireccion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CentroAtencionId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        CodigoCliente = c.Int(nullable: false),
                        NombreCliente = c.String(),
                        ApePaternoCliente = c.String(),
                        ApeMaternoCliente = c.String(),
                        DNICliente = c.String(),
                        FecNacimientoCliente = c.String(),
                        SueldoCliente = c.Double(nullable: false),
                        CorreoCliente = c.String(),
                        DireccionCliente = c.String(),
                        Evaluacion_EvaluacionId = c.Int(),
                    })
                .PrimaryKey(t => t.ClienteId)
                .ForeignKey("dbo.Evaluacions", t => t.Evaluacion_EvaluacionId)
                .Index(t => t.Evaluacion_EvaluacionId);
            
            CreateTable(
                "dbo.Contratoes",
                c => new
                    {
                        ContratoId = c.Int(nullable: false, identity: true),
                        NumeroContrato = c.Int(nullable: false),
                        Plazo = c.String(),
                        FormaContrato = c.String(),
                    })
                .PrimaryKey(t => t.ContratoId);
            
            CreateTable(
                "dbo.Departamentoes",
                c => new
                    {
                        DepartamentoId = c.Int(nullable: false, identity: true),
                        CodigoDepartamento = c.Int(nullable: false),
                        NombreDepartamento = c.String(),
                        CodProvincia_ProvinciaId = c.Int(),
                        Ubigeo_UbigeoId = c.Int(),
                    })
                .PrimaryKey(t => t.DepartamentoId)
                .ForeignKey("dbo.Provincias", t => t.CodProvincia_ProvinciaId)
                .ForeignKey("dbo.Ubigeos", t => t.Ubigeo_UbigeoId)
                .Index(t => t.CodProvincia_ProvinciaId)
                .Index(t => t.Ubigeo_UbigeoId);
            
            CreateTable(
                "dbo.Provincias",
                c => new
                    {
                        ProvinciaId = c.Int(nullable: false, identity: true),
                        CodigoProvincia = c.Int(nullable: false),
                        NombreProvincia = c.String(),
                        CodigoDistrito_DistritoId = c.Int(),
                        Ubigeo_UbigeoId = c.Int(),
                    })
                .PrimaryKey(t => t.ProvinciaId)
                .ForeignKey("dbo.Distritoes", t => t.CodigoDistrito_DistritoId)
                .ForeignKey("dbo.Ubigeos", t => t.Ubigeo_UbigeoId)
                .Index(t => t.CodigoDistrito_DistritoId)
                .Index(t => t.Ubigeo_UbigeoId);
            
            CreateTable(
                "dbo.Distritoes",
                c => new
                    {
                        DistritoId = c.Int(nullable: false, identity: true),
                        CodigoDistrito = c.Int(nullable: false),
                        NombreDistrito = c.String(),
                        Ubigeo_UbigeoId = c.Int(),
                    })
                .PrimaryKey(t => t.DistritoId)
                .ForeignKey("dbo.Ubigeos", t => t.Ubigeo_UbigeoId)
                .Index(t => t.Ubigeo_UbigeoId);
            
            CreateTable(
                "dbo.Direccions",
                c => new
                    {
                        DireccionId = c.Int(nullable: false, identity: true),
                        CodigoDireccion = c.Int(nullable: false),
                        NombreDireccion = c.String(),
                        CodigoUbigeo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DireccionId);
            
            CreateTable(
                "dbo.EstadoEvaluacions",
                c => new
                    {
                        EstadoEvaluacionId = c.Int(nullable: false, identity: true),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.EstadoEvaluacionId);
            
            CreateTable(
                "dbo.Evaluacions",
                c => new
                    {
                        EvaluacionId = c.Int(nullable: false, identity: true),
                        TipoDocumento = c.String(),
                        FecNacimiento = c.String(),
                        NumeroDocumento = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EvaluacionId);
            
            CreateTable(
                "dbo.Plans",
                c => new
                    {
                        PlanId = c.Int(nullable: false, identity: true),
                        CodigoPlan = c.Int(nullable: false),
                        TopeConsumo = c.String(),
                        CargoFijo = c.String(),
                        CaracteristicasPlan = c.String(),
                        Evaluacion_EvaluacionId = c.Int(),
                    })
                .PrimaryKey(t => t.PlanId)
                .ForeignKey("dbo.Evaluacions", t => t.Evaluacion_EvaluacionId)
                .Index(t => t.Evaluacion_EvaluacionId);
            
            CreateTable(
                "dbo.TipoEvaluacions",
                c => new
                    {
                        TipoEvaluacionId = c.Int(nullable: false, identity: true),
                        DescripTipEvaluacion = c.String(),
                    })
                .PrimaryKey(t => t.TipoEvaluacionId);
            
            CreateTable(
                "dbo.TipoPagoes",
                c => new
                    {
                        TipoPagoId = c.Int(nullable: false, identity: true),
                        FormaPago = c.String(),
                    })
                .PrimaryKey(t => t.TipoPagoId);
            
            CreateTable(
                "dbo.TipoPlans",
                c => new
                    {
                        TipoPlanId = c.Int(nullable: false, identity: true),
                        DescripcionTipoPlan = c.String(),
                    })
                .PrimaryKey(t => t.TipoPlanId);
            
            CreateTable(
                "dbo.TipoTrabajadors",
                c => new
                    {
                        TipoTrabajadorId = c.Int(nullable: false, identity: true),
                        CodigoTipoTrabajor = c.Int(nullable: false),
                        DescripTipoTrabajador = c.String(),
                    })
                .PrimaryKey(t => t.TipoTrabajadorId);
            
            CreateTable(
                "dbo.Trabajadors",
                c => new
                    {
                        TrabajadorId = c.Int(nullable: false, identity: true),
                        CodigoTrabajador = c.Int(nullable: false),
                        NombreTrabajador = c.String(),
                        ApellidoPaTrabajador = c.String(),
                        ApellidoMaTrabajador = c.String(),
                        NumtipoTrabajador = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TrabajadorId);
            
            CreateTable(
                "dbo.Ubigeos",
                c => new
                    {
                        UbigeoId = c.Int(nullable: false, identity: true),
                        CodigoUbigeo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UbigeoId);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        VentaId = c.Int(nullable: false, identity: true),
                        CodigoVenta = c.Int(nullable: false),
                        Modalidad = c.String(),
                        FechaVanta = c.String(),
                        MontoTotal = c.Double(nullable: false),
                        TiposPagos_TipoPagoId = c.Int(),
                    })
                .PrimaryKey(t => t.VentaId)
                .ForeignKey("dbo.TipoPagoes", t => t.TiposPagos_TipoPagoId)
                .Index(t => t.TiposPagos_TipoPagoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "TiposPagos_TipoPagoId", "dbo.TipoPagoes");
            DropForeignKey("dbo.Provincias", "Ubigeo_UbigeoId", "dbo.Ubigeos");
            DropForeignKey("dbo.Distritoes", "Ubigeo_UbigeoId", "dbo.Ubigeos");
            DropForeignKey("dbo.Departamentoes", "Ubigeo_UbigeoId", "dbo.Ubigeos");
            DropForeignKey("dbo.Plans", "Evaluacion_EvaluacionId", "dbo.Evaluacions");
            DropForeignKey("dbo.LineaTelefonicas", "Evaluacion_EvaluacionId", "dbo.Evaluacions");
            DropForeignKey("dbo.Clientes", "Evaluacion_EvaluacionId", "dbo.Evaluacions");
            DropForeignKey("dbo.Departamentoes", "CodProvincia_ProvinciaId", "dbo.Provincias");
            DropForeignKey("dbo.Provincias", "CodigoDistrito_DistritoId", "dbo.Distritoes");
            DropForeignKey("dbo.LineaTelefonicas", "AdministradorLinea_AdministradorLineaId", "dbo.AdministradorLineas");
            DropForeignKey("dbo.LineaTelefonicas", "TipoLinea_TipoLineaId", "dbo.TipoLineas");
            DropForeignKey("dbo.EquipoCelulars", "AdministradorEquipo_AdministradorEquipoId", "dbo.AdministradorEquipoes");
            DropIndex("dbo.Ventas", new[] { "TiposPagos_TipoPagoId" });
            DropIndex("dbo.Plans", new[] { "Evaluacion_EvaluacionId" });
            DropIndex("dbo.Distritoes", new[] { "Ubigeo_UbigeoId" });
            DropIndex("dbo.Provincias", new[] { "Ubigeo_UbigeoId" });
            DropIndex("dbo.Provincias", new[] { "CodigoDistrito_DistritoId" });
            DropIndex("dbo.Departamentoes", new[] { "Ubigeo_UbigeoId" });
            DropIndex("dbo.Departamentoes", new[] { "CodProvincia_ProvinciaId" });
            DropIndex("dbo.Clientes", new[] { "Evaluacion_EvaluacionId" });
            DropIndex("dbo.LineaTelefonicas", new[] { "Evaluacion_EvaluacionId" });
            DropIndex("dbo.LineaTelefonicas", new[] { "AdministradorLinea_AdministradorLineaId" });
            DropIndex("dbo.LineaTelefonicas", new[] { "TipoLinea_TipoLineaId" });
            DropIndex("dbo.EquipoCelulars", new[] { "AdministradorEquipo_AdministradorEquipoId" });
            DropTable("dbo.Ventas");
            DropTable("dbo.Ubigeos");
            DropTable("dbo.Trabajadors");
            DropTable("dbo.TipoTrabajadors");
            DropTable("dbo.TipoPlans");
            DropTable("dbo.TipoPagoes");
            DropTable("dbo.TipoEvaluacions");
            DropTable("dbo.Plans");
            DropTable("dbo.Evaluacions");
            DropTable("dbo.EstadoEvaluacions");
            DropTable("dbo.Direccions");
            DropTable("dbo.Distritoes");
            DropTable("dbo.Provincias");
            DropTable("dbo.Departamentoes");
            DropTable("dbo.Contratoes");
            DropTable("dbo.Clientes");
            DropTable("dbo.CentroAtencions");
            DropTable("dbo.TipoLineas");
            DropTable("dbo.LineaTelefonicas");
            DropTable("dbo.AdministradorLineas");
            DropTable("dbo.EquipoCelulars");
            DropTable("dbo.AdministradorEquipoes");
        }
    }
}
