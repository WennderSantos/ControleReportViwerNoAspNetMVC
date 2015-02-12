using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using UtilizandoControleReportViwer.Models;

namespace UtilizandoControleReportViwer.Views.Produto
{
    public partial class Relatorio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var listaProduto = new List<ProdutoModels>()
            {
                    new ProdutoModels{Codigo = 1, Nome = "Teclado", Preco = 31.50, QtdEmEstoque = 100},
                    new ProdutoModels{Codigo = 2, Nome = "Mouse", Preco = 20, QtdEmEstoque = 75},
                    new ProdutoModels{Codigo = 3, Nome = "Monitor", Preco = 350.99, QtdEmEstoque = 83},
                    new ProdutoModels{Codigo = 4, Nome = "Fone de ouvido", Preco = 59.60, QtdEmEstoque = 18},
                    new ProdutoModels{Codigo = 5, Nome = "Mousepad", Preco = 8.30, QtdEmEstoque = 33},
                    new ProdutoModels{Codigo = 6, Nome = "Notebook", Preco = 2500.70, QtdEmEstoque = 20},
                    new ProdutoModels{Codigo = 7, Nome = "HD SSD 120 GB", Preco = 240, QtdEmEstoque = 17},
                    new ProdutoModels{Codigo = 8, Nome = "Placa de vídeo", Preco = 999, QtdEmEstoque = 42},
                    new ProdutoModels{Codigo = 9, Nome = "Gabinete", Preco = 60, QtdEmEstoque = 23},
                    new ProdutoModels{Codigo = 10, Nome = "Iphone 6", Preco = 3000, QtdEmEstoque = 50}  
                             
            };

                var reportDS = new ReportDataSource();
                reportDS.Name = "dsProduto";
                reportDS.Value = listaProduto;

                ReportViewer1.LocalReport.DataSources.Add(reportDS);
                ReportViewer1.LocalReport.ReportPath = "Relatorio/ListaProduto.rdlc";
            }

        }
    }
}