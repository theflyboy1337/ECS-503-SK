﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20191113190251_dbupdated")]
    partial class dbupdated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Comments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CommentssId");

                    b.Property<DateTime>("DatePosted");

                    b.Property<int>("ParentCommentId");

                    b.Property<int?>("PersonsId");

                    b.Property<int>("PostId");

                    b.Property<int>("PostedBy");

                    b.HasKey("Id");

                    b.HasIndex("CommentssId");

                    b.HasIndex("PersonsId");

                    b.HasIndex("PostId");

                    b.ToTable("Commentss");
                });

            modelBuilder.Entity("WebApplication1.Models.FriendWith", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FirstPerson");

                    b.Property<DateTime>("Friendaversary");

                    b.Property<int?>("PersonId");

                    b.Property<int?>("PersonsId");

                    b.Property<int>("SecondPersond");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("PersonsId");

                    b.ToTable("FreindsWith");
                });

            modelBuilder.Entity("WebApplication1.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(20);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("WebApplication1.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonId");

                    b.Property<string>("PostContent")
                        .IsRequired();

                    b.Property<DateTime>("PostedDate");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("WebApplication1.Models.PostImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName");

                    b.Property<bool>("IsPrimary");

                    b.Property<int>("PostId");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("PostImagess");
                });

            modelBuilder.Entity("WebApplication1.Models.Reaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommentId");

                    b.Property<int?>("CommentssId");

                    b.Property<int>("ImageId");

                    b.Property<int>("PostId");

                    b.Property<int?>("PostImagessId");

                    b.Property<DateTime>("ReactionDate");

                    b.Property<int>("ReactionType");

                    b.Property<int?>("ReactionTypesId");

                    b.HasKey("Id");

                    b.HasIndex("CommentssId");

                    b.HasIndex("PostId");

                    b.HasIndex("PostImagessId");

                    b.HasIndex("ReactionTypesId");

                    b.ToTable("Reactions");
                });

            modelBuilder.Entity("WebApplication1.Models.ReactionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IconURL");

                    b.Property<string>("TypeName")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("ReactionTypes");
                });

            modelBuilder.Entity("WebApplication1.Models.Comments", b =>
                {
                    b.HasOne("WebApplication1.Models.Comments", "Commentss")
                        .WithMany()
                        .HasForeignKey("CommentssId");

                    b.HasOne("WebApplication1.Models.Person", "Persons")
                        .WithMany()
                        .HasForeignKey("PersonsId");

                    b.HasOne("WebApplication1.Models.Post", "Posts")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.FriendWith", b =>
                {
                    b.HasOne("WebApplication1.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("WebApplication1.Models.Person", "Persons")
                        .WithMany()
                        .HasForeignKey("PersonsId");
                });

            modelBuilder.Entity("WebApplication1.Models.Post", b =>
                {
                    b.HasOne("WebApplication1.Models.Person", "Persons")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.PostImages", b =>
                {
                    b.HasOne("WebApplication1.Models.Post", "Posts")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication1.Models.Reaction", b =>
                {
                    b.HasOne("WebApplication1.Models.Comments", "Commentss")
                        .WithMany()
                        .HasForeignKey("CommentssId");

                    b.HasOne("WebApplication1.Models.Post", "Posts")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication1.Models.PostImages", "PostImagess")
                        .WithMany()
                        .HasForeignKey("PostImagessId");

                    b.HasOne("WebApplication1.Models.ReactionType", "ReactionTypes")
                        .WithMany()
                        .HasForeignKey("ReactionTypesId");
                });
#pragma warning restore 612, 618
        }
    }
}