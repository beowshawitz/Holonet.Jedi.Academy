﻿// <auto-generated />
using System;
using Holonet.Jedi.Academy.BL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Holonet.Jedi.Academy.App.Migrations.Academy
{
    [DbContext(typeof(AcademyContext))]
    partial class AcademyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("App")
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.CompletedObjective", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CompletedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("ObjectiveId")
                        .HasColumnType("int");

                    b.Property<int>("QuestXPId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ObjectiveId");

                    b.HasIndex("QuestXPId");

                    b.ToTable("CompletedObjectives", "App");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.ForcePower", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Archived")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("MinimumRankId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("MinimumRankId");

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

                    b.Property<int>("ExperienceToGain")
                        .HasColumnType("int");

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

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Acknowledged")
                        .HasColumnType("bit");

                    b.Property<DateTime>("AcknowledgedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("SentOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Notifications", "App");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.Objective", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Archived")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Objectives", "App");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.ObjectiveDestination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ObjectiveId")
                        .HasColumnType("int");

                    b.Property<int>("PlanetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ObjectiveId");

                    b.HasIndex("PlanetId");

                    b.ToTable("ObjectiveDestinations", "App");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.Planet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Archived")
                        .HasColumnType("bit");

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

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.QuestObjective", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ObjectiveId")
                        .HasColumnType("int");

                    b.Property<int>("QuestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ObjectiveId");

                    b.HasIndex("QuestId");

                    b.ToTable("QuestObjectives", "App");
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

                    b.Property<int>("ExperienceToGain")
                        .HasColumnType("int");

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

                    b.Property<bool>("Archived")
                        .HasColumnType("bit");

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

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.RewardPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("KnowledgeId")
                        .HasColumnType("int");

                    b.Property<int?>("QuestId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KnowledgeId");

                    b.HasIndex("QuestId");

                    b.HasIndex("StudentId");

                    b.ToTable("RewardPoints", "App");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.Species", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Archived")
                        .HasColumnType("bit");

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

                    b.Property<bool>("Archived")
                        .HasColumnType("bit");

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

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.CompletedObjective", b =>
                {
                    b.HasOne("Holonet.Jedi.Academy.Entities.App.Objective", "Objective")
                        .WithMany()
                        .HasForeignKey("ObjectiveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Holonet.Jedi.Academy.Entities.App.QuestXP", "QuestXP")
                        .WithMany("CompletedObjectives")
                        .HasForeignKey("QuestXPId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Objective");

                    b.Navigation("QuestXP");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.ForcePower", b =>
                {
                    b.HasOne("Holonet.Jedi.Academy.Entities.App.Rank", "MinimumRank")
                        .WithMany()
                        .HasForeignKey("MinimumRankId");

                    b.Navigation("MinimumRank");
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

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.Notification", b =>
                {
                    b.HasOne("Holonet.Jedi.Academy.Entities.App.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.ObjectiveDestination", b =>
                {
                    b.HasOne("Holonet.Jedi.Academy.Entities.App.Objective", "Objective")
                        .WithMany("Destinations")
                        .HasForeignKey("ObjectiveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Holonet.Jedi.Academy.Entities.App.Planet", "Planet")
                        .WithMany()
                        .HasForeignKey("PlanetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Objective");

                    b.Navigation("Planet");
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

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.QuestObjective", b =>
                {
                    b.HasOne("Holonet.Jedi.Academy.Entities.App.Objective", "Objective")
                        .WithMany()
                        .HasForeignKey("ObjectiveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Holonet.Jedi.Academy.Entities.App.Quest", "Quest")
                        .WithMany("Objectives")
                        .HasForeignKey("QuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Objective");

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

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.RewardPoint", b =>
                {
                    b.HasOne("Holonet.Jedi.Academy.Entities.App.Knowledge", "Knowledge")
                        .WithMany()
                        .HasForeignKey("KnowledgeId");

                    b.HasOne("Holonet.Jedi.Academy.Entities.App.Quest", "Quest")
                        .WithMany()
                        .HasForeignKey("QuestId");

                    b.HasOne("Holonet.Jedi.Academy.Entities.App.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Knowledge");

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

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.Objective", b =>
                {
                    b.Navigation("Destinations");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.Quest", b =>
                {
                    b.Navigation("Objectives");
                });

            modelBuilder.Entity("Holonet.Jedi.Academy.Entities.App.QuestXP", b =>
                {
                    b.Navigation("CompletedObjectives");
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
