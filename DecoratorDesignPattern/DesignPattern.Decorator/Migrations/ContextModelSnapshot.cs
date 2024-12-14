﻿// <auto-generated />
using DesignPattern.Decorator.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DesignPattern.Decorator.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DesignPattern.Decorator.DAL.Message", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MessageID"));

                    b.Property<string>("MessageContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageReciver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageSender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageSubjcet")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MessageID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("DesignPattern.Decorator.DAL.Notifier", b =>
                {
                    b.Property<int>("NotifierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotifierID"));

                    b.Property<string>("NotifierChannel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotifierCreator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotifierSubject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotifierType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NotifierID");

                    b.ToTable("Notifiers");
                });
#pragma warning restore 612, 618
        }
    }
}
