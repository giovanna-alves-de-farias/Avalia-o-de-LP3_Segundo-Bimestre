using Microsoft.Data.Sqlite;
using Avaliacao3BimLp3 .Database;
using Avaliacao3BimLp3 .Repositories;
using Avaliacao3BimLp3 .Models;
using Avaliacao3BimLp3 .Models;

var databaseConfig = new DatabaseConfig();
var databaseSetup = new DatabaseSetup(databaseConfig);

// Routing
var modelName = args[0];
var modelAction = args[1];

if(modelName == "Product")
{
    var productRepository = new ProductRepository(databaseConfig);

    if(modelAction == "List")
    {
        Console.WriteLine("Product List: "); 
        
        foreach (var product in productRepository.GetAll())
        {
            Console.WriteLine($"{product.Id}, {product.Ram}, {product.Processor}");
            
        }
    } 
    
    if (modelAction == "New")
    {
        var id = Convert.ToInt32(args[2]);
        var name = args[3];
        var price = Convert.ToDouble(args[4]);
        var active = Convert.ToBoolean(args[5]);

        var product = new Product(id, name, price, active);

        productRepository.Save(product);
    }

    if(modelAction == "Delete")
    {
        var id = Convert.ToInt32(args[2]);

        if (productRepository.ExistById(id))
        {
            productRepository.Delete(id);
        }
        else
        {
            Console.WriteLine($"O Produto {id} não existe.");
        }
    }

    if(modelAction == "Delete")
    {
        
    }


}