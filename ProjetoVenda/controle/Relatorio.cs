using System;
using System.Collections.Generic;
using System.Text;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF;
using System.Diagnostics;
using ProjetoVenda.modelo;

namespace ProjetoVenda.controle
{
    internal class Relatorio
    {
        public Document gerarNota(List<Item> itens)
        {
            DateTime data = DateTime.Now;

            var documento = Document.Create(conteudo=> { // criando o documento

                conteudo.Page(pagina => {
                    pagina.Size(PageSizes.A6);
                    pagina.PageColor(QuestPDF.Infrastructure.Color.FromHex("f7f7c7"));
                    pagina.Margin(1, QuestPDF.Infrastructure.Unit.Centimetre);
                    pagina.DefaultTextStyle(font=>font.FontSize(10));

                    // repete em toda pagina
                    pagina.Header().Column(coluna=> {
                        coluna.Item().Text("Mercadinho da Esquina").Bold();
                        coluna.Item().PaddingBottom(10).Text("Rua das flores - 7070 - Sorocaba/SP").FontSize(5);
                        coluna.Item().AlignCenter().Text("Cupom de Venda").FontSize(18);
                        coluna.Item().LineHorizontal(0.5f);
                    });


                    // conteudo princial
                    pagina.Content().Column(coluna =>
                    {

                        // cabeçalho dos itens
                        coluna.Item().Row(linha => {
                            linha.ConstantItem(20).Text("Item").FontSize(8);
                            linha.RelativeItem(3).Text("Descrição").FontSize(8);
                            linha.ConstantItem(20).Text("Qtd").FontSize(8);
                            linha.RelativeItem().Text("Preço").FontSize(8);
                            linha.RelativeItem().Text("Total").FontSize(8).AlignRight();
                        });
                        coluna.Item().LineHorizontal(0.5f);

                        // os itens descritos
                        for (int i=0;  i<itens.Count; i++)
                        {
                            Item item = itens[i];

                            coluna.Item().Row(linha => {
                                linha.ConstantItem(20).Text($"{i+1}").FontSize(8);
                                linha.RelativeItem(3).Text(item.nomeProduto).FontSize(8);
                                linha.ConstantItem(20).Text($"{item.quantidade}").FontSize(8);
                                linha.RelativeItem().Text($"{item.precoReal}").FontSize(8);
                                linha.RelativeItem().Text($"{item.subTotal:C2}").FontSize(8).AlignRight();
                            });
                        }
                        coluna.Item().LineHorizontal(0.5f);

                        coluna.Item().Row(linha =>
                        {
                            decimal total = itens.Sum(i => i.subTotal);
                            linha.RelativeItem().Text("Total").FontSize(8);
                            linha.RelativeItem().Text($"{total:C2}").FontSize(8).AlignRight();
                        });

                    });


                    // repete em toda pagina
                    //Rodapé
                    pagina.Footer().Column(coluna =>
                    {
                        coluna.Item().LineHorizontal(0.5f);
                        coluna.Item().Text($"Data: {data:dd/MM/yyyy HH:mm:ss} ");
                        coluna.Item().Text("Compre mais");

                        coluna.Item().Text("todos os produtos são de procedência duvidosa").FontSize(1);
                    });



                });

            });

            return documento;
        }


        public void salvarPdf(Document documento)
        {
            string pasta = Path.GetTempPath();
            string nomeArquivo = $"doc_{Guid.NewGuid()}.pdf";
            string caminho = Path.Combine(pasta, nomeArquivo );

            documento.GeneratePdf(caminho);

            // Abre o documento
            Process.Start(new ProcessStartInfo
            {
                FileName = caminho,
                UseShellExecute = true
            });

        }

    }
}
