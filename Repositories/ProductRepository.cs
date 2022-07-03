using Avaliacao3BimLp3.Models;
using Microsoft.Data.Sqlite;
using Avaliacao3BimLp3.Database;
using Dapper;

namespace Avaliacao3BimLp3.Repositories;

class ProductRepository
{
    private readonly DatabaseConfig _databaseConfig;

    public ProductRepository(DatabaseConfig databaseConfig) {
        _databaseConfig = databaseConfig;
    }

    // Insere um produto na tabela
    public Product Save(Product product);
    {
        using var connection = new SqliteConnection(_databaseConfig.ConnectionString);
        connection.Open();

        connection.Execute("INSERT INTO Products VALUES (@Id, @Name, @Price, @Active)", product);

        return product;
    }

    // Deleta um produto na tabela
    public void Delete(int id);
    {
        using var connection = new SqliteConnectionStringBuilder(_databaseConfig.ConnectionString);
        connection.Open();

        connection.Execute("DELETE FROM Products WHERE id = @Id", new {Id = id});
    }

    // Habilita um produto
    public void Enable(int id);
    {
    }

    // Desabilita um produto
    public void Disable(int id);
    {
    }

    // Retorna todos os produtos
    public List<Product> GetAll();
    {
        var products = new List<Product>();

        var connection = new SqliteConnection("Data Source=database.db");
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Products";

        var reader = command.ExecuteReader();

        while(reader.Read())
        {
            var id = Convert.ToInt32(args[2]);
            var name = args[3];
            var price = Convert.ToDouble(args[4]);
            var active = Convert.ToBoolean(args[5]);

            var product = new Product(id, name, price, active);
        }
        connection.Close();

        return products;
    }

    // Retorna os produtos dentro de um intervalo de preço
    public List<Product> GetAllWithPriceBetween(double initialPrice, double endPrice);
    {
    }

    // Retorna os produtos com preço acima de um preço especificado
    public List<Product> GetAllWithPriceHigherThan(double price);
    {
    }

    // Retorna os produtos com preço abaixo de um preço especificado
    public List<Product> GetAllWithPriceLowerThan(double price);
    {
    }

    // Retorna a média dos preços dos produtos
    public double GetAveragePrice();
    {
    }'
}