// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using el_r3ad.data;

#nullable disable

namespace el_r3ad.Migrations
{
    [DbContext(typeof(Datacontext))]
    partial class DatacontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("el_r3ad.models.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActorId"), 1L, 1);

                    b.Property<string>("ActorBio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ActorGender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ActorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActorId");

                    b.ToTable("Actor");
                });

            modelBuilder.Entity("el_r3ad.models.ActorReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int?>("ActorReviewId")
                        .HasColumnType("int");

                    b.Property<string>("ReviewContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReviewRating")
                        .HasColumnType("int");

                    b.Property<int>("ReviewerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.HasIndex("ActorReviewId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("ActorReviews");
                });

            modelBuilder.Entity("el_r3ad.models.MovieActor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieActor");
                });

            modelBuilder.Entity("el_r3ad.models.MovieReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int?>("MovieReviewId")
                        .HasColumnType("int");

                    b.Property<string>("ReviewContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReviewRating")
                        .HasColumnType("int");

                    b.Property<int>("reviewerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.HasIndex("MovieId");

                    b.HasIndex("MovieReviewId");

                    b.HasIndex("reviewerId");

                    b.ToTable("MovieReviews");
                });

            modelBuilder.Entity("el_r3ad.models.Movies", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("MovieId");

                    b.HasIndex("ProducerId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("el_r3ad.models.Producer", b =>
                {
                    b.Property<int>("ProducerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProducerId"), 1L, 1);

                    b.Property<string>("ProducerBio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProducerGender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProducerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProducerId");

                    b.ToTable("Producer");
                });

            modelBuilder.Entity("el_r3ad.models.Reviewer", b =>
                {
                    b.Property<int>("ReviewerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewerId"), 1L, 1);

                    b.Property<string>("ReviewerBio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewerGender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReviewerId");

                    b.ToTable("Reviewer");
                });

            modelBuilder.Entity("el_r3ad.models.ActorReview", b =>
                {
                    b.HasOne("el_r3ad.models.Actor", "Actor")
                        .WithMany()
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("el_r3ad.models.ActorReview", null)
                        .WithMany("ActorReviews")
                        .HasForeignKey("ActorReviewId");

                    b.HasOne("el_r3ad.models.Reviewer", "Reviewer")
                        .WithMany("ActorReviews")
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Reviewer");
                });

            modelBuilder.Entity("el_r3ad.models.MovieActor", b =>
                {
                    b.HasOne("el_r3ad.models.Actor", "Actor")
                        .WithMany("ActorMovie")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("el_r3ad.models.Movies", "Movie")
                        .WithMany("MovieActor")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("el_r3ad.models.MovieReview", b =>
                {
                    b.HasOne("el_r3ad.models.Actor", null)
                        .WithMany("Reviews")
                        .HasForeignKey("ActorId");

                    b.HasOne("el_r3ad.models.Movies", "Movie")
                        .WithMany("Reviews")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("el_r3ad.models.MovieReview", null)
                        .WithMany("MovieReviews")
                        .HasForeignKey("MovieReviewId");

                    b.HasOne("el_r3ad.models.Reviewer", "Reviewer")
                        .WithMany("MovieReviews")
                        .HasForeignKey("reviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Reviewer");
                });

            modelBuilder.Entity("el_r3ad.models.Movies", b =>
                {
                    b.HasOne("el_r3ad.models.Producer", "producer")
                        .WithMany("Movies")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("producer");
                });

            modelBuilder.Entity("el_r3ad.models.Actor", b =>
                {
                    b.Navigation("ActorMovie");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("el_r3ad.models.ActorReview", b =>
                {
                    b.Navigation("ActorReviews");
                });

            modelBuilder.Entity("el_r3ad.models.MovieReview", b =>
                {
                    b.Navigation("MovieReviews");
                });

            modelBuilder.Entity("el_r3ad.models.Movies", b =>
                {
                    b.Navigation("MovieActor");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("el_r3ad.models.Producer", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("el_r3ad.models.Reviewer", b =>
                {
                    b.Navigation("ActorReviews");

                    b.Navigation("MovieReviews");
                });
#pragma warning restore 612, 618
        }
    }
}
