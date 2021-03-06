// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PracaInzynierskaAPI.DataBase.Context;

namespace PracaInzynierskaAPI.DataBase.Migrations
{
    [DbContext(typeof(PInzDataBaseContext))]
    [Migration("20211206134043_PInz2")]
    partial class PInz2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.Author.AuthorDbModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AddedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Biography")
                        .HasColumnType("text");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeathDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsBuildIn")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsModified")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("SecondName")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AddedBy");

                    b.HasIndex("Surname");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.Book.BookDbModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("AddedById")
                        .HasColumnType("uuid");

                    b.Property<bool>("Approved")
                        .HasColumnType("boolean");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<long>("Dislikes")
                        .HasColumnType("bigint");

                    b.Property<string>("ISBN")
                        .HasColumnType("text");

                    b.Property<Guid>("ImageCoverId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsBuildIn")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsModified")
                        .HasColumnType("boolean");

                    b.Property<Guid>("LanguageId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("Likes")
                        .HasColumnType("bigint");

                    b.Property<int?>("Pages")
                        .HasColumnType("integer");

                    b.Property<int>("PublishedYear")
                        .HasColumnType("integer");

                    b.Property<Guid>("PublisherId")
                        .HasColumnType("uuid");

                    b.Property<string>("Series")
                        .HasColumnType("text");

                    b.Property<string>("Subtitle")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AddedById");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageCoverId")
                        .IsUnique();

                    b.HasIndex("LanguageId");

                    b.HasIndex("PublisherId");

                    b.HasIndex("Title");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.Book_Author.Book_AuthorDbModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsBuildIn")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsModified")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("Book_Authors");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.Book_User.Book_UserDbModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsBuildIn")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsModified")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("User_Books");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.Category.CategoryDbModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsBuildIn")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsModified")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("Category")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.Comment.CommentDbModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AddedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uuid");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<Guid?>("CommentId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsBuildIn")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsModified")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("ToCommentId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("AddedBy");

                    b.HasIndex("BookId");

                    b.HasIndex("ToCommentId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.ImageCover.ImageCoverDbModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<byte[]>("ImageFile")
                        .HasColumnType("bytea");

                    b.Property<string>("ImageTitle")
                        .HasColumnType("text");

                    b.Property<bool>("IsBuildIn")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsModified")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("ImageCovers");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.Language.LanguageDbModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AddedBy")
                        .HasColumnType("uuid");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsBuildIn")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsModified")
                        .HasColumnType("boolean");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("Language")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.NLog.NLogDbModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Application")
                        .HasColumnType("text");

                    b.Property<string>("Callsite")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Exception")
                        .HasColumnType("text");

                    b.Property<bool>("IsBuildIn")
                        .HasColumnType("boolean");

                    b.Property<string>("Level")
                        .HasColumnType("text");

                    b.Property<string>("Logger")
                        .HasColumnType("text");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("NLogs");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.Publisher.PublisherDbModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AddedBy")
                        .HasColumnType("uuid");

                    b.Property<string>("Building")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsBuildIn")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsModified")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("PostCode")
                        .HasColumnType("text");

                    b.Property<string>("Premises")
                        .HasColumnType("text");

                    b.Property<string>("PublisherName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .HasColumnType("text");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PublisherName")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.User.UserDbModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool?>("Banned")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("IsBuildIn")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsModified")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("Likes")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long>("NumberOfBooks")
                        .HasColumnType("bigint");

                    b.Property<long>("NumberOfComments")
                        .HasColumnType("bigint");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Sex")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.HasIndex("Id", "UserName", "Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.UserPermission.UserPermissionDbModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsBuildIn")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsModified")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastModifiedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("PermissionName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PermissionName");

                    b.HasIndex("UserId");

                    b.ToTable("UserPermissions");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.Author.AuthorDbModel", b =>
                {
                    b.HasOne("PracaInzynierskaAPI.Entities.User.UserDbModel", "User")
                        .WithMany("Authors")
                        .HasForeignKey("AddedBy")
                        .HasConstraintName("Fk_Author_User")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.Book.BookDbModel", b =>
                {
                    b.HasOne("PracaInzynierskaAPI.Entities.User.UserDbModel", "AddedBy")
                        .WithMany("Books")
                        .HasForeignKey("AddedById");

                    b.HasOne("PracaInzynierskaAPI.Entities.Category.CategoryDbModel", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("Fk_Book_Category")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PracaInzynierskaAPI.Entities.ImageCover.ImageCoverDbModel", "ImageCover")
                        .WithOne("Book")
                        .HasForeignKey("PracaInzynierskaAPI.Entities.Book.BookDbModel", "ImageCoverId")
                        .HasConstraintName("Fk_Book_ImageCover")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PracaInzynierskaAPI.Entities.Language.LanguageDbModel", "Language")
                        .WithMany("Books")
                        .HasForeignKey("LanguageId")
                        .HasConstraintName("Fk_Book_Language")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PracaInzynierskaAPI.Entities.Publisher.PublisherDbModel", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .HasConstraintName("Fk_Book_Publisher")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AddedBy");

                    b.Navigation("Category");

                    b.Navigation("ImageCover");

                    b.Navigation("Language");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.Book_Author.Book_AuthorDbModel", b =>
                {
                    b.HasOne("PracaInzynierskaAPI.Entities.Author.AuthorDbModel", "Author")
                        .WithMany("Book_Author")
                        .HasForeignKey("AuthorId")
                        .HasConstraintName("Fk_BookAuthor_Author")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PracaInzynierskaAPI.Entities.Book.BookDbModel", "Book")
                        .WithMany("Book_Author")
                        .HasForeignKey("BookId")
                        .HasConstraintName("Fk_BookAuthor_Book")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.Book_User.Book_UserDbModel", b =>
                {
                    b.HasOne("PracaInzynierskaAPI.Entities.Book.BookDbModel", "Book")
                        .WithMany("BookList")
                        .HasForeignKey("BookId")
                        .HasConstraintName("Fk_BookUser_Book")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PracaInzynierskaAPI.Entities.User.UserDbModel", "User")
                        .WithMany("BooksList")
                        .HasForeignKey("UserId")
                        .HasConstraintName("Fk_BookUSer_User")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.Category.CategoryDbModel", b =>
                {
                    b.HasOne("PracaInzynierskaAPI.Entities.User.UserDbModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.Comment.CommentDbModel", b =>
                {
                    b.HasOne("PracaInzynierskaAPI.Entities.User.UserDbModel", "User")
                        .WithMany("Comments")
                        .HasForeignKey("AddedBy")
                        .HasConstraintName("Fk_Comment_User")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PracaInzynierskaAPI.Entities.Book.BookDbModel", "Book")
                        .WithMany("Comments")
                        .HasForeignKey("BookId")
                        .HasConstraintName("Fk_Comment_Boook")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PracaInzynierskaAPI.Entities.Comment.CommentDbModel", "ToComment")
                        .WithMany()
                        .HasForeignKey("ToCommentId");

                    b.Navigation("Book");

                    b.Navigation("ToComment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.Language.LanguageDbModel", b =>
                {
                    b.HasOne("PracaInzynierskaAPI.Entities.User.UserDbModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.Publisher.PublisherDbModel", b =>
                {
                    b.HasOne("PracaInzynierskaAPI.Entities.User.UserDbModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.UserPermission.UserPermissionDbModel", b =>
                {
                    b.HasOne("PracaInzynierskaAPI.Entities.User.UserDbModel", "User")
                        .WithMany("UserPermissions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.Author.AuthorDbModel", b =>
                {
                    b.Navigation("Book_Author");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.Book.BookDbModel", b =>
                {
                    b.Navigation("Book_Author");

                    b.Navigation("BookList");

                    b.Navigation("Comments");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.Category.CategoryDbModel", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.ImageCover.ImageCoverDbModel", b =>
                {
                    b.Navigation("Book");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.Language.LanguageDbModel", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.Publisher.PublisherDbModel", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("PracaInzynierskaAPI.Entities.User.UserDbModel", b =>
                {
                    b.Navigation("Authors");

                    b.Navigation("Books");

                    b.Navigation("BooksList");

                    b.Navigation("Comments");

                    b.Navigation("UserPermissions");
                });
#pragma warning restore 612, 618
        }
    }
}
