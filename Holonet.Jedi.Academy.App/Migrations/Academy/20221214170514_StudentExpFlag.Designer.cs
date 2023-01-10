﻿// <auto-generated />
using System;
using Holonet.Jedi.Academy.BL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Holonet.Jedi.Academy.App.Migrations.Academy
{
    [DbContext(typeof(AcademyContext))]
    [Migration("20221214170514_StudentExpFlag")]
    partial class StudentExpFlag
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("App")
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.ForcePower", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("ForcePowers", "App");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.ForcePowerXP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ForcePowerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("GainedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ForcePowerId");

                    b.HasIndex("StudentId");

                    b.ToTable("ForcePowerXP", "App");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.Knowledge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("ExperienceToGain")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("KnowledgeOpportunities", "App");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.KnowledgeXP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("AddedToStudent")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CompletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("KnowledgeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KnowledgeId");

                    b.HasIndex("StudentId");

                    b.ToTable("KnowledgeXP", "App");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.Planet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Planets", "App");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.Quest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Archived")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("ExperienceToGain")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("RankId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RankId");

                    b.ToTable("Quests", "App");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.QuestDestination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PlanetId")
                        .HasColumnType("int");

                    b.Property<int>("QuestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlanetId");

                    b.HasIndex("QuestId");

                    b.ToTable("QuestDestinations", "App");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.QuestXP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("AddedToStudent")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CompletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("QuestId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestId");

                    b.HasIndex("StudentId");

                    b.ToTable("QuestXP", "App");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.Rank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Maximum")
                        .HasColumnType("int");

                    b.Property<int>("Minimum")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("RankLevel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ranks", "App");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.Species", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Species", "App");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("InitiatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("LeftOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("PlanetId")
                        .HasColumnType("int");

                    b.Property<int>("RankId")
                        .HasColumnType("int");

                    b.Property<int?>("ReasonForTerminationId")
                        .HasColumnType("int");

                    b.Property<int>("SpeciesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlanetId");

                    b.HasIndex("RankId");

                    b.HasIndex("ReasonForTerminationId");

                    b.HasIndex("SpeciesId");

                    b.ToTable("Students", "App");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.TerminationReason", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("TerminationReasons", "App");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("UserProfiles", "App");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.ForcePowerXP", b =>
                {
                    b.HasOne("Holonet.Jedi.Academy.Entities.App.ForcePower", "ForcePower")
                        .WithMany()
                        .HasForeignKey("ForcePowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Holonet.Jedi.Academy.Entities.App.Student", "Student")
                        .WithMany("ForcePowers")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ForcePower");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.KnowledgeXP", b =>
                {
                    b.HasOne("Holonet.Jedi.Academy.Entities.App.Knowledge", "Knowledge")
                        .WithMany()
                        .HasForeignKey("KnowledgeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Holonet.Jedi.Academy.Entities.App.Student", "Student")
                        .WithMany("Knowledge")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Knowledge");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.Quest", b =>
                {
                    b.HasOne("Holonet.Jedi.Academy.Entities.App.Rank", "Rank")
                        .WithMany()
                        .HasForeignKey("RankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rank");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.QuestDestination", b =>
                {
                    b.HasOne("Holonet.Jedi.Academy.Entities.App.Planet", "Planet")
                        .WithMany()
                        .HasForeignKey("PlanetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Holonet.Jedi.Academy.Entities.App.Quest", "Quest")
                        .WithMany("Destinations")
                        .HasForeignKey("QuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Planet");

                    b.Navigation("Quest");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.QuestXP", b =>
                {
                    b.HasOne("Holonet.Jedi.Academy.Entities.App.Quest", "Quest")
                        .WithMany()
                        .HasForeignKey("QuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Holonet.Jedi.Academy.Entities.App.Student", "Student")
                        .WithMany("Quests")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quest");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.Student", b =>
                {
                    b.HasOne("Holonet.Jedi.Academy.Entities.App.Planet", "Planet")
                        .WithMany()
                        .HasForeignKey("PlanetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Holonet.Jedi.Academy.Entities.App.Rank", "Rank")
                        .WithMany()
                        .HasForeignKey("RankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Holonet.Jedi.Academy.Entities.App.TerminationReason", "ReasonForTermination")
                        .WithMany()
                        .HasForeignKey("ReasonForTerminationId");

                    b.HasOne("Holonet.Jedi.Academy.Entities.App.Species", "Species")
                        .WithMany()
                        .HasForeignKey("SpeciesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Planet");

                    b.Navigation("Rank");

                    b.Navigation("ReasonForTermination");

                    b.Navigation("Species");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.UserProfile", b =>
                {
                    b.HasOne("Holonet.Jedi.Academy.Entities.App.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.Quest", b =>
                {
                    b.Navigation("Destinations");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.Student", b =>
                {
                    b.Navigation("ForcePowers");

                    b.Navigation("Knowledge");

                    b.Navigation("Quests");
                });
#pragma warning restore 612, 618
        }
    }
}
