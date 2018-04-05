﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SacramentPlanner.Models;
using System;

namespace SacramentPlanner.Migrations
{
    [DbContext(typeof(SacramentPlannerContext))]
    [Migration("20180405180543_FixFields")]
    partial class FixFields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SacramentPlanner.Models.Meeting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClosePrayer")
                        .HasMaxLength(50);

                    b.Property<string>("CloseSong")
                        .HasMaxLength(50);

                    b.Property<int>("CloseSongNum");

                    b.Property<string>("Conduct")
                        .HasMaxLength(50);

                    b.Property<DateTime>("Date");

                    b.Property<string>("OpenPrayer")
                        .HasMaxLength(50);

                    b.Property<string>("OpenSong")
                        .HasMaxLength(50);

                    b.Property<int>("OpenSongNum");

                    b.Property<string>("SacSong")
                        .HasMaxLength(50);

                    b.Property<int>("SacSongNum");

                    b.Property<string>("SecondSpeaker");

                    b.Property<string>("SecondTopic");

                    b.Property<string>("ThirdSpeaker");

                    b.Property<string>("ThirdTopic");

                    b.Property<string>("YouthSpeaker");

                    b.Property<string>("YouthTopic");

                    b.HasKey("ID");

                    b.ToTable("Meeting");
                });
#pragma warning restore 612, 618
        }
    }
}
