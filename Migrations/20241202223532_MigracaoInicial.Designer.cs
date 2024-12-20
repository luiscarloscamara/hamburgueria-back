﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebAPI.Context;

#nullable disable

namespace burguermania_backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241202223532_MigracaoInicial")]
    partial class MigracaoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebAPI.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("BaseDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PathImage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            FullDescription = "Um hambúrguer vegano suculento feito com uma base de grão-de-bico e quinoa, temperado com especiarias defumadas, cebola caramelizada e alho, garantindo uma textura rica e saborosa. Servido em um pão macio, ele vem acompanhado de fatias frescas de tomate, alface crocante, picles, abacate cremoso e uma generosa camada de maionese de ervas vegana. Finalizado com molho barbecue agridoce e uma pitada de pimenta-do-reino moída na hora, proporcionando uma combinação deliciosa de sabores e texturas em cada mordida.",
                            Name = "X-Vegan",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true"
                        },
                        new
                        {
                            Id = 2,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            FullDescription = "Um sanduíche leve e nutritivo, perfeito para quem busca energia e sabor. Feito com um hambúrguer grelhado de peito de frango temperado com ervas finas e cúrcuma, servido em um pão integral artesanal. Acompanhado de folhas frescas de rúcula, espinafre e brotos de alfafa, além de rodelas crocantes de pepino, fatias finas de cenoura e uma pasta de iogurte grego com hortelã. Finalizado com um toque de azeite extravirgem e sementes de chia, proporcionando uma refeição equilibrada, repleta de texturas frescas e saudáveis.",
                            Name = "X-Fitness",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true"
                        },
                        new
                        {
                            Id = 3,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            FullDescription = "Um sanduíche irresistível e indulgente para os amantes de sabores intensos. Composto por um hambúrguer suculento de 200g de carne bovina Angus, envolto em uma crosta de bacon crocante e coberto com uma generosa porção de queijo cheddar derretido. Servido em um pão brioche amanteigado, o recheio inclui cebolas fritas crocantes, fatias de tomate, alface americana, molho especial à base de maionese e alho, e um toque extra de ketchup e mostarda. Para finalizar, uma camada de pulled pork desfiado e uma pitada de páprica picante, garantindo uma explosão de sabores a cada mordida.",
                            Name = "X-Infarto",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true"
                        },
                        new
                        {
                            Id = 4,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            FullDescription = "Uma experiência gastronômica sofisticada, criada para paladares exigentes. O hambúrguer trufado, preparado com carne Angus suculenta, é coroado com queijo brie derretido e cogumelos trufados, realçando a complexidade dos sabores. Servido em um pão brioche artesanal, ele é complementado por rúcula fresca e uma maionese artesanal levemente cítrica. Cada mordida é um convite a saborear a combinação perfeita entre ingredientes premium e texturas envolventes, fazendo do X-Gourmet uma escolha inesquecível.",
                            Name = "X-Gourmet",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true"
                        },
                        new
                        {
                            Id = 5,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            FullDescription = "Uma celebração aos sabores que nunca saem de moda. O Cheeseburger Tradicional, com hambúrguer grelhado no ponto perfeito, é acompanhado por queijo cheddar derretido, alface fresca e tomate suculento, tudo dentro de um pão macio. Para os amantes de bacon, o X-Bacon entrega o crocante irresistível junto com molho barbecue. Já o X-Egg adiciona o toque especial do ovo frito com gema cremosa. Simples e deliciosos, os clássicos oferecem conforto e sabor em cada mordida.",
                            Name = "X-Clássicos",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true"
                        });
                });

            modelBuilder.Entity("WebAPI.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Observation")
                        .HasColumnType("text");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.Property<float>("Value")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WebAPI.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("BaseDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("FullDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PathImage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            CategoryId = 1,
                            FullDescription = "Um hambúrguer vegano suculento feito com uma base de grão-de-bico e quinoa, temperado com especiarias defumadas, cebola caramelizada e alho, garantindo uma textura rica e saborosa. Servido em um pão macio, ele vem acompanhado de fatias frescas de tomate, alface crocante, picles, abacate cremoso e uma generosa camada de maionese de ervas vegana. Finalizado com molho barbecue agridoce e uma pitada de pimenta-do-reino moída na hora, proporcionando uma combinação deliciosa de sabores e texturas em cada mordida.",
                            Name = "X-Alface-Premium",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true",
                            Price = 29.989999999999998
                        },
                        new
                        {
                            Id = 2,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            CategoryId = 1,
                            FullDescription = "Um hambúrguer vegano suculento feito com uma base de grão-de-bico e quinoa, temperado com especiarias defumadas, cebola caramelizada e alho, garantindo uma textura rica e saborosa. Servido em um pão macio, ele vem acompanhado de fatias frescas de tomate, alface crocante, picles, abacate cremoso e uma generosa camada de maionese de ervas vegana. Finalizado com molho barbecue agridoce e uma pitada de pimenta-do-reino moída na hora, proporcionando uma combinação deliciosa de sabores e texturas em cada mordida.",
                            Name = "X-Tomate",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true",
                            Price = 39.990000000000002
                        },
                        new
                        {
                            Id = 3,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            CategoryId = 1,
                            FullDescription = "Um hambúrguer vegano suculento feito com uma base de grão-de-bico e quinoa, temperado com especiarias defumadas, cebola caramelizada e alho, garantindo uma textura rica e saborosa. Servido em um pão macio, ele vem acompanhado de fatias frescas de tomate, alface crocante, picles, abacate cremoso e uma generosa camada de maionese de ervas vegana. Finalizado com molho barbecue agridoce e uma pitada de pimenta-do-reino moída na hora, proporcionando uma combinação deliciosa de sabores e texturas em cada mordida.",
                            Name = "X-Frutas",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true",
                            Price = 49.990000000000002
                        },
                        new
                        {
                            Id = 4,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            CategoryId = 1,
                            FullDescription = "Um hambúrguer vegano suculento feito com uma base de grão-de-bico e quinoa, temperado com especiarias defumadas, cebola caramelizada e alho, garantindo uma textura rica e saborosa. Servido em um pão macio, ele vem acompanhado de fatias frescas de tomate, alface crocante, picles, abacate cremoso e uma generosa camada de maionese de ervas vegana. Finalizado com molho barbecue agridoce e uma pitada de pimenta-do-reino moída na hora, proporcionando uma combinação deliciosa de sabores e texturas em cada mordida.",
                            Name = "X-Salada",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true",
                            Price = 49.990000000000002
                        },
                        new
                        {
                            Id = 5,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            CategoryId = 2,
                            FullDescription = "Um hambúrguer vegano suculento feito com uma base de grão-de-bico e quinoa, temperado com especiarias defumadas, cebola caramelizada e alho, garantindo uma textura rica e saborosa. Servido em um pão macio, ele vem acompanhado de fatias frescas de tomate, alface crocante, picles, abacate cremoso e uma generosa camada de maionese de ervas vegana. Finalizado com molho barbecue agridoce e uma pitada de pimenta-do-reino moída na hora, proporcionando uma combinação deliciosa de sabores e texturas em cada mordida.",
                            Name = "X-Fitness-Grelhado",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true",
                            Price = 29.989999999999998
                        },
                        new
                        {
                            Id = 6,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            CategoryId = 2,
                            FullDescription = "Um hambúrguer vegano suculento feito com uma base de grão-de-bico e quinoa, temperado com especiarias defumadas, cebola caramelizada e alho, garantindo uma textura rica e saborosa. Servido em um pão macio, ele vem acompanhado de fatias frescas de tomate, alface crocante, picles, abacate cremoso e uma generosa camada de maionese de ervas vegana. Finalizado com molho barbecue agridoce e uma pitada de pimenta-do-reino moída na hora, proporcionando uma combinação deliciosa de sabores e texturas em cada mordida.",
                            Name = "X-Proteína",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true",
                            Price = 39.990000000000002
                        },
                        new
                        {
                            Id = 7,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            CategoryId = 2,
                            FullDescription = "Um hambúrguer vegano suculento feito com uma base de grão-de-bico e quinoa, temperado com especiarias defumadas, cebola caramelizada e alho, garantindo uma textura rica e saborosa. Servido em um pão macio, ele vem acompanhado de fatias frescas de tomate, alface crocante, picles, abacate cremoso e uma generosa camada de maionese de ervas vegana. Finalizado com molho barbecue agridoce e uma pitada de pimenta-do-reino moída na hora, proporcionando uma combinação deliciosa de sabores e texturas em cada mordida.",
                            Name = "X-Low-Carb",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true",
                            Price = 49.990000000000002
                        },
                        new
                        {
                            Id = 8,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            CategoryId = 2,
                            FullDescription = "Um hambúrguer vegano suculento feito com uma base de grão-de-bico e quinoa, temperado com especiarias defumadas, cebola caramelizada e alho, garantindo uma textura rica e saborosa. Servido em um pão macio, ele vem acompanhado de fatias frescas de tomate, alface crocante, picles, abacate cremoso e uma generosa camada de maionese de ervas vegana. Finalizado com molho barbecue agridoce e uma pitada de pimenta-do-reino moída na hora, proporcionando uma combinação deliciosa de sabores e texturas em cada mordida.",
                            Name = "X-Light",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true",
                            Price = 49.990000000000002
                        },
                        new
                        {
                            Id = 9,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            CategoryId = 3,
                            FullDescription = "Um hambúrguer vegano suculento feito com uma base de grão-de-bico e quinoa, temperado com especiarias defumadas, cebola caramelizada e alho, garantindo uma textura rica e saborosa. Servido em um pão macio, ele vem acompanhado de fatias frescas de tomate, alface crocante, picles, abacate cremoso e uma generosa camada de maionese de ervas vegana. Finalizado com molho barbecue agridoce e uma pitada de pimenta-do-reino moída na hora, proporcionando uma combinação deliciosa de sabores e texturas em cada mordida.",
                            Name = "X-Mega-Bacon",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true",
                            Price = 29.989999999999998
                        },
                        new
                        {
                            Id = 10,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            CategoryId = 3,
                            FullDescription = "Um hambúrguer vegano suculento feito com uma base de grão-de-bico e quinoa, temperado com especiarias defumadas, cebola caramelizada e alho, garantindo uma textura rica e saborosa. Servido em um pão macio, ele vem acompanhado de fatias frescas de tomate, alface crocante, picles, abacate cremoso e uma generosa camada de maionese de ervas vegana. Finalizado com molho barbecue agridoce e uma pitada de pimenta-do-reino moída na hora, proporcionando uma combinação deliciosa de sabores e texturas em cada mordida.",
                            Name = "X-Parada-Cardíaca",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true",
                            Price = 39.990000000000002
                        },
                        new
                        {
                            Id = 11,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            CategoryId = 3,
                            FullDescription = "Um hambúrguer vegano suculento feito com uma base de grão-de-bico e quinoa, temperado com especiarias defumadas, cebola caramelizada e alho, garantindo uma textura rica e saborosa. Servido em um pão macio, ele vem acompanhado de fatias frescas de tomate, alface crocante, picles, abacate cremoso e uma generosa camada de maionese de ervas vegana. Finalizado com molho barbecue agridoce e uma pitada de pimenta-do-reino moída na hora, proporcionando uma combinação deliciosa de sabores e texturas em cada mordida.",
                            Name = "X-Queijo-Extra",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true",
                            Price = 49.990000000000002
                        },
                        new
                        {
                            Id = 12,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            CategoryId = 3,
                            FullDescription = "Um hambúrguer vegano suculento feito com uma base de grão-de-bico e quinoa, temperado com especiarias defumadas, cebola caramelizada e alho, garantindo uma textura rica e saborosa. Servido em um pão macio, ele vem acompanhado de fatias frescas de tomate, alface crocante, picles, abacate cremoso e uma generosa camada de maionese de ervas vegana. Finalizado com molho barbecue agridoce e uma pitada de pimenta-do-reino moída na hora, proporcionando uma combinação deliciosa de sabores e texturas em cada mordida.",
                            Name = "X-Triplo",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true",
                            Price = 49.990000000000002
                        },
                        new
                        {
                            Id = 13,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            CategoryId = 4,
                            FullDescription = "Um hambúrguer vegano suculento feito com uma base de grão-de-bico e quinoa, temperado com especiarias defumadas, cebola caramelizada e alho, garantindo uma textura rica e saborosa. Servido em um pão macio, ele vem acompanhado de fatias frescas de tomate, alface crocante, picles, abacate cremoso e uma generosa camada de maionese de ervas vegana. Finalizado com molho barbecue agridoce e uma pitada de pimenta-do-reino moída na hora, proporcionando uma combinação deliciosa de sabores e texturas em cada mordida.",
                            Name = "X-Trufado-Supreme",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true",
                            Price = 59.990000000000002
                        },
                        new
                        {
                            Id = 14,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            CategoryId = 4,
                            FullDescription = "Um hambúrguer vegano suculento feito com uma base de grão-de-bico e quinoa, temperado com especiarias defumadas, cebola caramelizada e alho, garantindo uma textura rica e saborosa. Servido em um pão macio, ele vem acompanhado de fatias frescas de tomate, alface crocante, picles, abacate cremoso e uma generosa camada de maionese de ervas vegana. Finalizado com molho barbecue agridoce e uma pitada de pimenta-do-reino moída na hora, proporcionando uma combinação deliciosa de sabores e texturas em cada mordida.",
                            Name = "X-Blue-Cheese-Delight",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true",
                            Price = 69.989999999999995
                        },
                        new
                        {
                            Id = 15,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            CategoryId = 4,
                            FullDescription = "Um hambúrguer vegano suculento feito com uma base de grão-de-bico e quinoa, temperado com especiarias defumadas, cebola caramelizada e alho, garantindo uma textura rica e saborosa. Servido em um pão macio, ele vem acompanhado de fatias frescas de tomate, alface crocante, picles, abacate cremoso e uma generosa camada de maionese de ervas vegana. Finalizado com molho barbecue agridoce e uma pitada de pimenta-do-reino moída na hora, proporcionando uma combinação deliciosa de sabores e texturas em cada mordida.",
                            Name = "X-Mediterrâneo",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true",
                            Price = 79.989999999999995
                        },
                        new
                        {
                            Id = 16,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            CategoryId = 4,
                            FullDescription = "Um hambúrguer vegano suculento feito com uma base de grão-de-bico e quinoa, temperado com especiarias defumadas, cebola caramelizada e alho, garantindo uma textura rica e saborosa. Servido em um pão macio, ele vem acompanhado de fatias frescas de tomate, alface crocante, picles, abacate cremoso e uma generosa camada de maionese de ervas vegana. Finalizado com molho barbecue agridoce e uma pitada de pimenta-do-reino moída na hora, proporcionando uma combinação deliciosa de sabores e texturas em cada mordida.",
                            Name = "X-Deluxe",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true",
                            Price = 89.989999999999995
                        },
                        new
                        {
                            Id = 17,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            CategoryId = 5,
                            FullDescription = "Um hambúrguer vegano suculento feito com uma base de grão-de-bico e quinoa, temperado com especiarias defumadas, cebola caramelizada e alho, garantindo uma textura rica e saborosa. Servido em um pão macio, ele vem acompanhado de fatias frescas de tomate, alface crocante, picles, abacate cremoso e uma generosa camada de maionese de ervas vegana. Finalizado com molho barbecue agridoce e uma pitada de pimenta-do-reino moída na hora, proporcionando uma combinação deliciosa de sabores e texturas em cada mordida.",
                            Name = "X-Cheeseburger-Tradicional",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true",
                            Price = 29.989999999999998
                        },
                        new
                        {
                            Id = 18,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            CategoryId = 5,
                            FullDescription = "Um hambúrguer vegano suculento feito com uma base de grão-de-bico e quinoa, temperado com especiarias defumadas, cebola caramelizada e alho, garantindo uma textura rica e saborosa. Servido em um pão macio, ele vem acompanhado de fatias frescas de tomate, alface crocante, picles, abacate cremoso e uma generosa camada de maionese de ervas vegana. Finalizado com molho barbecue agridoce e uma pitada de pimenta-do-reino moída na hora, proporcionando uma combinação deliciosa de sabores e texturas em cada mordida.",
                            Name = "X-Bacon",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true",
                            Price = 39.990000000000002
                        },
                        new
                        {
                            Id = 19,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            CategoryId = 5,
                            FullDescription = "Um hambúrguer vegano suculento feito com uma base de grão-de-bico e quinoa, temperado com especiarias defumadas, cebola caramelizada e alho, garantindo uma textura rica e saborosa. Servido em um pão macio, ele vem acompanhado de fatias frescas de tomate, alface crocante, picles, abacate cremoso e uma generosa camada de maionese de ervas vegana. Finalizado com molho barbecue agridoce e uma pitada de pimenta-do-reino moída na hora, proporcionando uma combinação deliciosa de sabores e texturas em cada mordida.",
                            Name = "X-Egg",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true",
                            Price = 49.990000000000002
                        },
                        new
                        {
                            Id = 20,
                            BaseDescription = "Pão, hambúrguer, alface, tomate, queijo e maionese.",
                            CategoryId = 5,
                            FullDescription = "Um hambúrguer vegano suculento feito com uma base de grão-de-bico e quinoa, temperado com especiarias defumadas, cebola caramelizada e alho, garantindo uma textura rica e saborosa. Servido em um pão macio, ele vem acompanhado de fatias frescas de tomate, alface crocante, picles, abacate cremoso e uma generosa camada de maionese de ervas vegana. Finalizado com molho barbecue agridoce e uma pitada de pimenta-do-reino moída na hora, proporcionando uma combinação deliciosa de sabores e texturas em cada mordida.",
                            Name = "X-Tudo",
                            PathImage = "https://github.com/mauricio-alves/burguermania-frontend/blob/main/src/app/assets/images/image4.png?raw=true",
                            Price = 49.990000000000002
                        });
                });

            modelBuilder.Entity("WebAPI.Models.ProductOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductOrders");
                });

            modelBuilder.Entity("WebAPI.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Status");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pendente"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Em Processamento"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Finalizado"
                        });
                });

            modelBuilder.Entity("WebAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "mauricio@email.com",
                            Name = "Mauricio Alves",
                            Password = "password123"
                        },
                        new
                        {
                            Id = 2,
                            Email = "fulano@email.com",
                            Name = "Fulano de Tal",
                            Password = "password123"
                        });
                });

            modelBuilder.Entity("WebAPI.Models.UserOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("UserOrders");
                });

            modelBuilder.Entity("WebAPI.Models.Order", b =>
                {
                    b.HasOne("WebAPI.Models.Status", "Status")
                        .WithMany("Orders")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Status");
                });

            modelBuilder.Entity("WebAPI.Models.Product", b =>
                {
                    b.HasOne("WebAPI.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WebAPI.Models.ProductOrder", b =>
                {
                    b.HasOne("WebAPI.Models.Order", "Order")
                        .WithMany("ProductOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Models.Product", "Product")
                        .WithMany("ProductOrders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebAPI.Models.UserOrder", b =>
                {
                    b.HasOne("WebAPI.Models.Order", "Order")
                        .WithMany("UserOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Models.User", "User")
                        .WithMany("UserOrders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebAPI.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("WebAPI.Models.Order", b =>
                {
                    b.Navigation("ProductOrders");

                    b.Navigation("UserOrders");
                });

            modelBuilder.Entity("WebAPI.Models.Product", b =>
                {
                    b.Navigation("ProductOrders");
                });

            modelBuilder.Entity("WebAPI.Models.Status", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("WebAPI.Models.User", b =>
                {
                    b.Navigation("UserOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
