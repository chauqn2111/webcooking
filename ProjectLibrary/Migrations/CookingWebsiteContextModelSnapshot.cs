﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectLibrary.ObjectBussiness;

#nullable disable

namespace ProjectLibrary.Migrations
{
    [DbContext(typeof(CookingWebsiteContext))]
    partial class CookingWebsiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("CategoryId")
                        .HasName("PK_Type");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"));

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("RecipeId");

                    b.HasIndex("UserId");

                    b.ToTable("Comment", (string)null);
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.Contest", b =>
                {
                    b.Property<int>("ContestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContestId"));

                    b.Property<string>("ContestName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime");

                    b.Property<int?>("OwnerUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime");

                    b.HasKey("ContestId")
                        .HasName("PK__Contests__87DE0B1A63E36EED");

                    b.HasIndex("OwnerUserId");

                    b.HasIndex(new[] { "StartTime", "EndTime" }, "UC_ContestDates")
                        .IsUnique();

                    b.ToTable("Contests");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.IngredientsDetail", b =>
                {
                    b.Property<int>("Stt")
                        .HasColumnType("int")
                        .HasColumnName("stt");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("Stt");

                    b.HasIndex("IngredientId");

                    b.ToTable("Ingredients_Detail", (string)null);
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.IngredientsGroup", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngredientId"));

                    b.Property<string>("NameIngredients")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int");

                    b.HasKey("IngredientId")
                        .HasName("PK__Ingredie__BEAEB25A7C2114F2");

                    b.HasIndex("RecipeId");

                    b.ToTable("Ingredients_Group", (string)null);
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.Notification", b =>
                {
                    b.Property<int>("NotificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("NotificationID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotificationId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("NotificationId");

                    b.HasIndex("UserId");

                    b.ToTable("Notification", (string)null);
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.Rating", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RatingId"));

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("Vote")
                        .HasColumnType("int");

                    b.HasKey("RatingId")
                        .HasName("PK__Ratings__FCCDF87CA929BC9E");

                    b.HasIndex("RecipeId");

                    b.HasIndex(new[] { "UserId", "RecipeId" }, "UC_User_Contest")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL AND [RecipeId] IS NOT NULL");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeId"));

                    b.Property<string>("Calories")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Carbs")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ContestId")
                        .HasColumnType("int");

                    b.Property<string>("CookTime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("Creator")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fat")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageTitle")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PrepTime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Protein")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<bool>("ReadFree")
                        .HasColumnType("bit");

                    b.Property<string>("RecipeTitle")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Servings")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.Property<string>("TotalTime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("VideoUrl")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("VideoURL");

                    b.HasKey("RecipeId")
                        .HasName("PK__Recipes__45D89E1C9D62B44D");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ContestId");

                    b.HasIndex("Creator");

                    b.HasIndex("TagId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.RecipesStep", b =>
                {
                    b.Property<int>("Step")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("ImageURL");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int");

                    b.Property<string>("VideoUrl")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("VideoURL");

                    b.HasKey("Step");

                    b.HasIndex("RecipeId");

                    b.ToTable("Recipes_Step", (string)null);
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RoleId")
                        .HasName("PK__Roles__8AFACE1A38D0BE6E");

                    b.HasIndex(new[] { "RoleName" }, "UQ__Roles__8A2B61604B25B500")
                        .IsUnique()
                        .HasFilter("[RoleName] IS NOT NULL");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagId"));

                    b.Property<string>("TagName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TagId")
                        .HasName("PK__Tags__9FCD3F7E1BFA9C7C");

                    b.HasIndex(new[] { "TagName" }, "UQ__Tags__2EAE8F47CB170E55")
                        .IsUnique()
                        .HasFilter("[TagName] IS NOT NULL");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("EmailConfirmationToken")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserType")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("UserId")
                        .HasName("PK__Users__1788CC4C95FAAD11");

                    b.HasIndex("RoleId");

                    b.HasIndex(new[] { "Email" }, "UQ__Users__A9D10534638514AD")
                        .IsUnique();

                    b.HasIndex(new[] { "UserName" }, "UQ__Users__C9F284564CC9CD89")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.UserActivity", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActivityId"));

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LogDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ActivityId")
                        .HasName("PK__UserActi__45F4A791EBC83F5E");

                    b.HasIndex("UserId");

                    b.ToTable("UserActivity", (string)null);
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.UserDetail", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Avatar")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FullName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("UserId")
                        .HasName("PK__UserDeta__1788CC4C5A774286");

                    b.ToTable("UserDetail", (string)null);
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.UserRegHistory", b =>
                {
                    b.Property<int>("RegistrationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RegistrationId"));

                    b.Property<decimal?>("Amount")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime");

                    b.Property<string>("MemberType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime");

                    b.Property<string>("SubscriptionType")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RegistrationId")
                        .HasName("PK__UserRegH__6EF58810FC7204B9");

                    b.HasIndex("UserId");

                    b.ToTable("UserRegHistory", (string)null);
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.WinnerInfo", b =>
                {
                    b.Property<int>("WinnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WinnerId"));

                    b.Property<int?>("ContestId")
                        .HasColumnType("int");

                    b.Property<string>("Prize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Vote")
                        .HasColumnType("int");

                    b.Property<int?>("WinnerUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("WinningDate")
                        .HasColumnType("datetime");

                    b.HasKey("WinnerId")
                        .HasName("PK__WinnerIn__8A3D1DA89A7B71C7");

                    b.HasIndex("ContestId");

                    b.HasIndex("WinnerUserId");

                    b.ToTable("WinnerInfo", (string)null);
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.Comment", b =>
                {
                    b.HasOne("ProjectLibrary.ObjectBussiness.Recipe", "Recipe")
                        .WithMany("Comments")
                        .HasForeignKey("RecipeId")
                        .HasConstraintName("FK_Comment_Recipes");

                    b.HasOne("ProjectLibrary.ObjectBussiness.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Comment_Users");

                    b.Navigation("Recipe");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.Contest", b =>
                {
                    b.HasOne("ProjectLibrary.ObjectBussiness.User", "OwnerUser")
                        .WithMany("Contests")
                        .HasForeignKey("OwnerUserId")
                        .HasConstraintName("FK__Contests__OwnerU__6383C8BA");

                    b.Navigation("OwnerUser");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.IngredientsDetail", b =>
                {
                    b.HasOne("ProjectLibrary.ObjectBussiness.IngredientsGroup", "Ingredient")
                        .WithMany("IngredientsDetails")
                        .HasForeignKey("IngredientId")
                        .IsRequired()
                        .HasConstraintName("FK_Ingredients_Detail_Ingredients_Group");

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.IngredientsGroup", b =>
                {
                    b.HasOne("ProjectLibrary.ObjectBussiness.Recipe", "Recipe")
                        .WithMany("IngredientsGroups")
                        .HasForeignKey("RecipeId")
                        .HasConstraintName("FK__Ingredien__Recip__73BA3083");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.Notification", b =>
                {
                    b.HasOne("ProjectLibrary.ObjectBussiness.User", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Notification_Users");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.Rating", b =>
                {
                    b.HasOne("ProjectLibrary.ObjectBussiness.Recipe", "Recipe")
                        .WithMany("Ratings")
                        .HasForeignKey("RecipeId")
                        .HasConstraintName("FK_Ratings_Recipes");

                    b.HasOne("ProjectLibrary.ObjectBussiness.User", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Ratings__UserId__6754599E");

                    b.Navigation("Recipe");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.Recipe", b =>
                {
                    b.HasOne("ProjectLibrary.ObjectBussiness.Category", "Category")
                        .WithMany("Recipes")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Recipes_Recipes");

                    b.HasOne("ProjectLibrary.ObjectBussiness.Contest", "Contest")
                        .WithMany("Recipes")
                        .HasForeignKey("ContestId")
                        .HasConstraintName("FK_Recipes_Contests");

                    b.HasOne("ProjectLibrary.ObjectBussiness.User", "CreatorNavigation")
                        .WithMany("Recipes")
                        .HasForeignKey("Creator")
                        .HasConstraintName("FK__Recipes__CreateU__6EF57B66");

                    b.HasOne("ProjectLibrary.ObjectBussiness.Tag", "Tag")
                        .WithMany("Recipes")
                        .HasForeignKey("TagId")
                        .IsRequired()
                        .HasConstraintName("FK__Recipes__IdTags__6FE99F9F");

                    b.Navigation("Category");

                    b.Navigation("Contest");

                    b.Navigation("CreatorNavigation");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.RecipesStep", b =>
                {
                    b.HasOne("ProjectLibrary.ObjectBussiness.Recipe", "Recipe")
                        .WithMany("RecipesSteps")
                        .HasForeignKey("RecipeId")
                        .HasConstraintName("FK_Recipes_Step_Recipes");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.User", b =>
                {
                    b.HasOne("ProjectLibrary.ObjectBussiness.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK__Users__RoleId__4E88ABD4");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.UserActivity", b =>
                {
                    b.HasOne("ProjectLibrary.ObjectBussiness.User", "User")
                        .WithMany("UserActivities")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__UserActiv__UserI__59FA5E80");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.UserDetail", b =>
                {
                    b.HasOne("ProjectLibrary.ObjectBussiness.User", "User")
                        .WithOne("UserDetail")
                        .HasForeignKey("ProjectLibrary.ObjectBussiness.UserDetail", "UserId")
                        .IsRequired()
                        .HasConstraintName("FK__UserDetai__UserI__5165187F");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.UserRegHistory", b =>
                {
                    b.HasOne("ProjectLibrary.ObjectBussiness.User", "User")
                        .WithMany("UserRegHistories")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__UserRegHi__UserI__571DF1D5");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.WinnerInfo", b =>
                {
                    b.HasOne("ProjectLibrary.ObjectBussiness.Contest", "Contest")
                        .WithMany("WinnerInfos")
                        .HasForeignKey("ContestId")
                        .HasConstraintName("FK__WinnerInf__Conte__6B24EA82");

                    b.HasOne("ProjectLibrary.ObjectBussiness.User", "WinnerUser")
                        .WithMany("WinnerInfos")
                        .HasForeignKey("WinnerUserId")
                        .HasConstraintName("FK__WinnerInf__Winne__6C190EBB");

                    b.Navigation("Contest");

                    b.Navigation("WinnerUser");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.Category", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.Contest", b =>
                {
                    b.Navigation("Recipes");

                    b.Navigation("WinnerInfos");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.IngredientsGroup", b =>
                {
                    b.Navigation("IngredientsDetails");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.Recipe", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("IngredientsGroups");

                    b.Navigation("Ratings");

                    b.Navigation("RecipesSteps");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.Tag", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("ProjectLibrary.ObjectBussiness.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Contests");

                    b.Navigation("Notifications");

                    b.Navigation("Ratings");

                    b.Navigation("Recipes");

                    b.Navigation("UserActivities");

                    b.Navigation("UserDetail");

                    b.Navigation("UserRegHistories");

                    b.Navigation("WinnerInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
