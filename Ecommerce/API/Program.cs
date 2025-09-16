using API.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Lista de Produtos
var produtos = new List<Produto>
{
    new Produto { Nome = "Mouse", Quantidade = 20, Preco = 50.00, CriadoEm = DateTime.Now },
    new Produto { Nome = "Teclado", Quantidade = 15, Preco = 150.00, CriadoEm = DateTime.Now },
    new Produto { Nome = "Monitor", Quantidade = 8, Preco = 1200.00, CriadoEm = DateTime.Now },
    new Produto { Nome = "Fone de Ouvido", Quantidade = 30, Preco = 200.00, CriadoEm = DateTime.Now },
    new Produto { Nome = "Cadeira Ergonômica", Quantidade = 10, Preco = 800.00, CriadoEm = DateTime.Now },
    new Produto { Nome = "Processador Intel i7", Quantidade = 5, Preco = 2500.00, CriadoEm = DateTime.Now },
    new Produto { Nome = "Placa de Vídeo Nvidia RTX 3080", Quantidade = 3, Preco = 3500.00, CriadoEm = DateTime.Now },
    new Produto { Nome = "SSD 1TB", Quantidade = 25, Preco = 450.00, CriadoEm = DateTime.Now },
    new Produto { Nome = "Cabo HDMI 4K", Quantidade = 50, Preco = 40.00, CriadoEm = DateTime.Now },
    new Produto { Nome = "Webcam Full HD", Quantidade = 18, Preco = 120.00, CriadoEm = DateTime.Now }
};

// Rota GET raiz
app.MapGet("/", () => "Minha segunda API em C#");

// Rota GET simples
app.MapGet("/endereco", () => "Outra funcionalidade");

// Rota POST simples
app.MapPost("/endereco", () => "Funcionalidade do POST");

// Rota GET para criar produto e exibir data de criação
app.MapGet("/produto", () =>
{
    Produto produto = new Produto();
    return $"Produto: {produto.Nome} | Criado em: {produto.CriadoEm}";
});

// Rota GET para a API de Produtos
app.MapGet("/api", () => "API de Produtos");

// Rota GET para listar os produtos
app.MapGet("/api/produtos/Listar", () => produtos);  // Alterei a rota de "/api/produtos/Listar" para "/api/produtos"

// POST: /api/produto/cadastrar 
// Agora recebe um produto via corpo da requisição
app.MapPost("/api/produto/cadastrar", (Produto produtoNovo) =>
{
    // Gera um GUID único para o novo produto
    produtoNovo.Id = Guid.NewGuid().ToString();
    produtoNovo.CriadoEm = DateTime.Now; // Define a data de criação

    produtos.Add(produtoNovo); // Adiciona o novo produto à lista de produtos

    // Retorna o status 201 (Criado) com o produto
    return Results.Created($"/api/produto/{produtoNovo.Id}", produtoNovo);  
});

app.Run();
