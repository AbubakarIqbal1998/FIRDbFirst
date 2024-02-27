using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Services.Feature.Admins.Core.DataModel;
using Services.Feature.ComplaintTypes.Core.DataModel;
using Services.Feature.Designations.Core.DataModel;
using Services.Feature.Districts.Core.DataModel;
using Services.Feature.Firs.Core.DataModel;
using Services.Feature.Messages.Core.DataModel;
using Services.Feature.PoliceStations.Core.DataModel;
using Services.Feature.Provinces.Core.DataModel;
using Services.Feature.PublicServices.Core.DataModel;
using Services.Feature.Sections.Core.DataModel;
using Services.Feature.Units.Core.DataModel;

namespace Services.Context;

public partial class FirContext : DbContext
{
    public FirContext()
    {
    }

    public FirContext(DbContextOptions<FirContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<ComplaintType> ComplaintTypes { get; set; }

    public virtual DbSet<Designation> Designations { get; set; }

    public virtual DbSet<District> Districts { get; set; }

    public virtual DbSet<Fir> Firs { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<PoliceStation> PoliceStations { get; set; }

    public virtual DbSet<Province> Provinces { get; set; }

    public virtual DbSet<PublicService> PublicServices { get; set; }

    public virtual DbSet<Section> Sections { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=abubakariqbal;DataBase=FIR;Trusted_Connection=true;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.AdminId).HasName("PK__Admin__719FE4E81090EBE1");

            entity.ToTable("Admin");

            entity.Property(e => e.AdminId).HasColumnName("AdminID");
            entity.Property(e => e.Cnic).HasColumnName("CNIC");
            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.PoliceStationId).HasColumnName("PoliceStationID");
            entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
            entity.Property(e => e.UnitId).HasColumnName("UnitID");
        });

        modelBuilder.Entity<ComplaintType>(entity =>
        {
            entity.HasKey(e => e.ComplainttypeId).HasName("PK__Complain__1747CC46F2197ACE");

            entity.ToTable("ComplaintType");

            entity.Property(e => e.ComplainttypeId).HasColumnName("ComplainttypeID");
        });

        modelBuilder.Entity<Designation>(entity =>
        {
            entity.HasKey(e => e.DesignationId).HasName("PK__Designat__BABD603ECF4958A7");

            entity.ToTable("Designation");

            entity.Property(e => e.DesignationId).HasColumnName("DesignationID");
            entity.Property(e => e.Designation1).HasColumnName("Designation");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
        });

        modelBuilder.Entity<District>(entity =>
        {
            entity.HasKey(e => e.DistrictId).HasName("PK__District__85FDA4A61A836226");

            entity.ToTable("District");

            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.District1).HasColumnName("District");
            entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
        });

        modelBuilder.Entity<Fir>(entity =>
        {
            entity.HasKey(e => e.Firid).HasName("PK__FIR__66D37DC26F7FA9DE");

            entity.ToTable("FIR");

            entity.Property(e => e.Firid).HasColumnName("FIRID");
            entity.Property(e => e.AccussedCnic).HasColumnName("AccussedCNIC");
            entity.Property(e => e.ComplainttypeId).HasColumnName("ComplainttypeID");
            entity.Property(e => e.Dateofincident).HasColumnType("datetime");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.Firdescription).HasColumnName("FIRDescription");
            entity.Property(e => e.PolicestationId).HasColumnName("PolicestationID");
            entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.VisitedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.MessageId).HasName("PK__Message__C87C037CAC2C3D8C");

            entity.ToTable("Message");

            entity.Property(e => e.MessageId).HasColumnName("MessageID");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.Message1).HasColumnName("Message");
            entity.Property(e => e.PolicestationId).HasColumnName("PolicestationID");
            entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
        });

        modelBuilder.Entity<PoliceStation>(entity =>
        {
            entity.HasKey(e => e.PolicestationId).HasName("PK__PoliceSt__AFBC5D3774327258");

            entity.ToTable("PoliceStation");

            entity.Property(e => e.PolicestationId).HasColumnName("PolicestationID");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.Policestation1).HasColumnName("Policestation");
            entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
        });

        modelBuilder.Entity<Province>(entity =>
        {
            entity.HasKey(e => e.ProvinceId).HasName("PK__Province__FD0A6FA3BFDA3707");

            entity.ToTable("Province");

            entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
            entity.Property(e => e.Province1).HasColumnName("Province");
        });

        modelBuilder.Entity<PublicService>(entity =>
        {
            entity.HasKey(e => e.PublicServiceId).HasName("PK__PublicSe__5307F0221888D4EC");

            entity.ToTable("PublicService");

            entity.Property(e => e.PublicServiceId).HasColumnName("PublicServiceID");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.PolicestationId).HasColumnName("PolicestationID");
        });

        modelBuilder.Entity<Section>(entity =>
        {
            entity.HasKey(e => e.SectionId).HasName("PK__Section__80EF08928EC971DC");

            entity.ToTable("Section");

            entity.Property(e => e.SectionId).HasColumnName("SectionID");
            entity.Property(e => e.Section1).HasColumnName("Section");
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.HasKey(e => e.UnitId).HasName("PK__Unit__44F5EC955227FE1B");

            entity.ToTable("Unit");

            entity.Property(e => e.UnitId).HasColumnName("UnitID");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
            entity.Property(e => e.Unit1).HasColumnName("Unit");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
