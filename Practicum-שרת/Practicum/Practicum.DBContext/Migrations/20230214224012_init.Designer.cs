// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Practicum.DBContext;

#nullable disable

namespace Practicum.DBContext.Migrations
{
    [DbContext(typeof(PracticumContext))]
    [Migration("20230214224012_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Practicum.Repository.Entities.HMO", b =>
                {
                    b.Property<int>("IdHMO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdHMO"));

                    b.Property<string>("HMOName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdHMO");

                    b.ToTable("HMOs");
                });

            modelBuilder.Entity("Practicum.Repository.Entities.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HMOId")
                        .HasColumnType("int");

                    b.Property<string>("IdNumber")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<bool>("IsMale")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("PersonId");

                    b.HasIndex("HMOId");

                    b.HasIndex("ParentId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("Practicum.Repository.Entities.Person", b =>
                {
                    b.HasOne("Practicum.Repository.Entities.HMO", "HMO")
                        .WithMany()
                        .HasForeignKey("HMOId");

                    b.HasOne("Practicum.Repository.Entities.Person", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.Navigation("HMO");

                    b.Navigation("Parent");
                });
#pragma warning restore 612, 618
        }
    }
}
