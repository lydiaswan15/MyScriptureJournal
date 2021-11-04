﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MySciptureJournal.Migrations
{
    [DbContext(typeof(MyScriptureJournalContext))]
    [Migration("20211104033300_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("MyScriptureJournal.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BookName")
                        .HasColumnType("TEXT");

                    b.HasKey("BookId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("MyScriptureJournal.Models.Scripture", b =>
                {
                    b.Property<int>("ScriptureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Verses")
                        .HasColumnType("TEXT");

                    b.HasKey("ScriptureId");

                    b.HasIndex("BookId");

                    b.ToTable("Scripture");
                });

            modelBuilder.Entity("MyScriptureJournal.Models.Scripture", b =>
                {
                    b.HasOne("MyScriptureJournal.Models.Book", "Book")
                        .WithMany("Scriptures")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("MyScriptureJournal.Models.Book", b =>
                {
                    b.Navigation("Scriptures");
                });
#pragma warning restore 612, 618
        }
    }
}
