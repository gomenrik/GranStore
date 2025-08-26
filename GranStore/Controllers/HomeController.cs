using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GranStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace GranStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private List<Produto> produtos;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        
        List<Categoria> categorias = new() {
            new Categoria { Id = 1, Nome = "Mouse"},
            new Categoria { Id = 2, Nome = "Mousepad"}
        };

        produtos = new List<Produto>
        {
            new Produto {
                Id = 1,
                Categoria = categorias[0],
                Nome = "Pulsar ZywOo",
                Descricao = "Lorem Ipsum",
                ValorCusto = 1649.90m,
                ValorVenda = 1484.90m,
                QtdeEstoque = 26,
                Foto = "/img/Produtos/pulsar-zywoo-medium-white.jpg",
            },
            new Produto {
                Id = 2,
                Categoria = categorias[0],
                Nome = "Finalmouse ULX Prophecy Small",
                Descricao = "Lorem Ipsum",
                ValorCusto = 2199.90m,
                ValorVenda = 1979.91m,
                QtdeEstoque = 43,
                Foto = "/img/Produtos/Finalmouse ULX Prophecy Small.jpg"
            },
            new Produto {
                Id = 3,
                Categoria = categorias[0],
                Nome = "Viper V3 PRO",
                Descricao = "Lorem Ipsum",
                ValorCusto = 1899.90m,
                ValorVenda = 1709.91m,
                QtdeEstoque = 29,
                Foto = "/img/Produtos/ViperV3PRO.jpg"
            },
            new Produto {
                Id = 4,
                Categoria = categorias[0],
                Nome = "Endgame Gear OP1w 4K v2",
                Descricao = "Lorem Ipsum",
                ValorCusto = 1099.90m,
                ValorVenda = 989.91m,
                QtdeEstoque = 14,
                Foto = "/img/Produtos/Endgame Gear OP1w 4K v2.jpg"
            },
            new Produto {
                Id = 5,
                Categoria = categorias[1],
                Nome = "KanamiMinamiGlasspad",
                Descricao = "Lorem Ipsum",
                ValorCusto = 1499.90m,
                ValorVenda = 1349.91m,
                QtdeEstoque = 21,
                Foto = "/img/Produtos/KanamiMinamiGlasspad.jpg"
            },
            new Produto {
                Id = 6,
                Categoria = categorias[1],
                Nome = "Wallhack SP-004",
                Descricao = "Lorem Ipsum",
                ValorCusto = 1299.90m,
                ValorVenda = 1079.91m,
                QtdeEstoque = 23,
                Foto = "/img/Produtos/Wallhack SP-004.jpg"
            },
            new Produto {
                Id = 7,
                Categoria = categorias[1],
                Nome = "LGG x Pulsar Hyperion XXL",
                Descricao = "Lorem Ipsum",
                ValorCusto = 1199.90m,
                ValorVenda = 944.91m,
                QtdeEstoque = 22,
                Foto = "/img/Produtos/LGGxPulsarHyperionXXL.jpg"
            },
            new Produto {
                Id = 8,
                Categoria = categorias[1],
                Nome = "Artisan FX Key-83 XL",
                Descricao = "Lorem Ipsum",
                ValorCusto = 749.90m,
                ValorVenda = 674.91m,
                QtdeEstoque = 9,
                Foto = "/img/Produtos/ArtisanFXKey-83XL.jpg"
            },
        };
    }

    public IActionResult Index()
    {
        return View(produtos);
    }

    public IActionResult Produto(int id)
    {
        var produto = produtos.SingleOrDefault(p => p.Id == id);
        return View(produto);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}