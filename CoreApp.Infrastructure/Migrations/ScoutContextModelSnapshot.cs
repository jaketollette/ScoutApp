﻿// <auto-generated />
using System;
using CoreApp.Infrastructure.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreApp.Infrastructure.Migrations
{
    [DbContext(typeof(ScoutContext))]
    partial class ScoutContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreApp.Core.Concrete.Badge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Deleted");

                    b.Property<int?>("IconId");

                    b.Property<string>("Name");

                    b.Property<string>("Summary");

                    b.HasKey("Id");

                    b.HasIndex("IconId");

                    b.ToTable("Badges");
                });

            modelBuilder.Entity("CoreApp.Core.Concrete.Den", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Deleted");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Dens");
                });

            modelBuilder.Entity("CoreApp.Core.Concrete.Icon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Deleted");

                    b.Property<string>("FileName");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Icons");
                });

            modelBuilder.Entity("CoreApp.Core.Concrete.Leader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active");

                    b.Property<bool?>("Deleted");

                    b.Property<int>("DenId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.HasIndex("DenId");

                    b.ToTable("Leaders");
                });

            modelBuilder.Entity("CoreApp.Core.Concrete.Rank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Deleted");

                    b.Property<int?>("IconId");

                    b.Property<string>("Name");

                    b.Property<int>("Order");

                    b.HasKey("Id");

                    b.HasIndex("IconId");

                    b.ToTable("Ranks");
                });

            modelBuilder.Entity("CoreApp.Core.Concrete.Scout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active");

                    b.Property<DateTime?>("Birthday");

                    b.Property<bool?>("Deleted");

                    b.Property<int>("DenId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("RankId");

                    b.Property<DateTime?>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("DenId");

                    b.HasIndex("RankId");

                    b.ToTable("Scouts");
                });

            modelBuilder.Entity("CoreApp.Core.Concrete.ScoutBadge", b =>
                {
                    b.Property<int>("BadgeId");

                    b.Property<int>("ScoutId");

                    b.Property<int?>("IconId");

                    b.HasKey("BadgeId", "ScoutId");

                    b.HasIndex("IconId");

                    b.HasIndex("ScoutId");

                    b.ToTable("ScoutBadges");
                });

            modelBuilder.Entity("CoreApp.Core.Concrete.Badge", b =>
                {
                    b.HasOne("CoreApp.Core.Concrete.Icon", "Icon")
                        .WithMany()
                        .HasForeignKey("IconId");
                });

            modelBuilder.Entity("CoreApp.Core.Concrete.Leader", b =>
                {
                    b.HasOne("CoreApp.Core.Concrete.Den", "Den")
                        .WithMany("Leader")
                        .HasForeignKey("DenId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreApp.Core.Concrete.Rank", b =>
                {
                    b.HasOne("CoreApp.Core.Concrete.Icon", "Icon")
                        .WithMany()
                        .HasForeignKey("IconId");
                });

            modelBuilder.Entity("CoreApp.Core.Concrete.Scout", b =>
                {
                    b.HasOne("CoreApp.Core.Concrete.Den", "Den")
                        .WithMany()
                        .HasForeignKey("DenId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoreApp.Core.Concrete.Rank", "Rank")
                        .WithMany()
                        .HasForeignKey("RankId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreApp.Core.Concrete.ScoutBadge", b =>
                {
                    b.HasOne("CoreApp.Core.Concrete.Badge", "Badge")
                        .WithMany("ScoutBadges")
                        .HasForeignKey("BadgeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoreApp.Core.Concrete.Icon", "Icon")
                        .WithMany()
                        .HasForeignKey("IconId");

                    b.HasOne("CoreApp.Core.Concrete.Scout", "Scout")
                        .WithMany("ScoutBadges")
                        .HasForeignKey("ScoutId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}