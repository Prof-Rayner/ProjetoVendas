using System;
using System.Collections.Generic;
using System.Text;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF;
using System.Diagnostics;
using ProjetoVenda.modelo;
using QuestPDF.Infrastructure;

namespace ProjetoVenda.controle
{
    internal class Relatorio
    {

        public void salvarPdf(Document documento)
        {
            string pasta = Path.GetTempPath();
            string nomeArquivo = $"doc_{Guid.NewGuid()}.pdf";
            string caminho = Path.Combine(pasta, nomeArquivo);

            documento.GeneratePdf(caminho);

            // Abre o documento
            Process.Start(new ProcessStartInfo
            {
                FileName = caminho,
                UseShellExecute = true
            });

        }

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


        private void resumo(IContainer conteudo, List<Venda> listaDeVendas)
        {
            int quantidadeDeVendas = listaDeVendas.Count();
            Venda? maiorVenda = listaDeVendas.OrderByDescending(venda=>venda.total).FirstOrDefault();
            Venda? menorVenda = listaDeVendas.OrderBy(venda=>venda.total).FirstOrDefault();

            conteudo.Column(coluna => {
                coluna.Item()
                .Background(Colors.BlueGrey.Darken1)
                .Border(0.5f, Colors.BlueGrey.Darken2)
                .Padding(8)
                .DefaultTextStyle(e=>e.FontColor(Colors.White))
                .Text("RESUMO GERAL");

                coluna.Item().Row(linha => {
                    linha.RelativeItem().Text($"Maior Venda:{maiorVenda.total:C2}");
                    linha.RelativeItem().Text($"Menor Venda:{menorVenda.total:C2}");
                    linha.RelativeItem().Text($"Total de vendas:{quantidadeDeVendas}");
                });

            });

        }

        private void rankFuncionario(IContainer conteudo, List<Venda> listaDeVendas)
        {

            var funcionarios = listaDeVendas.GroupBy(venda => new { 
                venda.cod_funcionario,
                venda.nomeFuncionario
            }).Select(grupo => new
            {
                cod_funcionario = grupo.Key.cod_funcionario,
                nome = grupo.Key.nomeFuncionario,
                quantidadeVendas = grupo.Count(),
                total = grupo.Sum(venda=>venda.total)
            }).OrderByDescending(funcionario=>funcionario.total).ToList();

            conteudo.Column(coluna => {
                coluna.Item()
                .Background(Colors.BlueGrey.Darken1)
                .Border(0.5f, Colors.BlueGrey.Darken2)
                .Padding(8)
                .DefaultTextStyle(e => e.FontColor(Colors.White))
                .Text("RANKING DOS FUNCIONARIOS");

                coluna.Spacing(10);

                coluna.Item().Table(tabela => {
                    tabela.ColumnsDefinition(coluna =>
                    {
                        coluna.ConstantColumn(30);
                        coluna.ConstantColumn(40);
                        coluna.RelativeColumn(2);
                        coluna.ConstantColumn(40);
                        coluna.RelativeColumn();
                    });
                    tabela.Header(cabecalho =>
                    {
                        cabecalho.Cell().Background(Colors.Grey.Lighten1).BorderBottom(0.5f).Text("#");
                        cabecalho.Cell().Background(Colors.Grey.Lighten1).BorderBottom(0.5f).Text("cod");
                        cabecalho.Cell().Background(Colors.Grey.Lighten1).BorderBottom(0.5f).Text("nome");
                        cabecalho.Cell().Background(Colors.Grey.Lighten1).BorderBottom(0.5f).Text("QTD");
                        cabecalho.Cell().Background(Colors.Grey.Lighten1).BorderBottom(0.5f).Text("Total").AlignRight();
                    });
                    int pos = 1;
                    foreach(var funcionario in funcionarios)
                    {
                        tabela.Cell().Text($"{pos}º");
                        tabela.Cell().Text($"{funcionario.cod_funcionario}");
                        tabela.Cell().Text($"{funcionario.nome}");
                        tabela.Cell().Text($"{funcionario.quantidadeVendas}");
                        tabela.Cell().Text($"{funcionario.total:C2}").AlignRight();
                        pos++;
                    }
                });
                

            });
        }

        private void demonstrativo(IContainer conteudo, List<Venda> listaDeVendas)
        {
            decimal totalVendido = listaDeVendas.Sum(venda=>venda.total);

            conteudo.Column(coluna => {
                coluna.Item()
                .Background(Colors.BlueGrey.Darken1)
                .Border(0.5f, Colors.BlueGrey.Darken2)
                .Padding(8)
                .DefaultTextStyle(e => e.FontColor(Colors.White))
                .Text("DEMONSTRATIVO DE VENDAS (DRE)");

                coluna.Item().Row(linha => {
                    linha.RelativeItem().Text($"Faturamento").FontSize(16);
                    linha.RelativeItem().Text($"{totalVendido:C2}").AlignRight().FontSize(16);
                });

            });

        }


        public Document gerarRelatorioMensal(List<Venda> listaDeVendas)
        {
            DateTime data = DateTime.Now;
            DateTime dataInicial = listaDeVendas.Min(venda => venda.data);
            DateTime dataFinal = listaDeVendas.Max(venda => venda.data);

            var documento = Document.Create(conteudo => {
                conteudo.Page(pagina =>
                {
                    pagina.Size(PageSizes.A4);
                    pagina.Margin(10);
                    pagina.DefaultTextStyle(estilo=>estilo.FontSize(12));

                    // cabeçalho
                    pagina.Header().Column(coluna=> {
                        coluna.Item().Text("Relatório Mensal").AlignCenter().FontSize(18);
                        coluna.Item().Text("Mercadinho da esquina");
                        coluna.Item().Text($"Periodo: {dataInicial:dd/MM/yyyy} a {dataFinal:dd/MM/yyyy}");
                        coluna.Item().LineHorizontal(1f);
                    });

                    //conteudo principal
                    pagina.Content().Column(coluna =>
                    {
                        //resumo
                        coluna.Item().Element(conteudo=>resumo(conteudo, listaDeVendas));

                        // ranking funcionarios
                        coluna.Item().Element(conteudo => rankFuncionario(conteudo, listaDeVendas));

                        // demonstrativo
                        coluna.Item().Element(conteudo => demonstrativo(conteudo, listaDeVendas));

                    });


                    // rodapé
                    pagina.Footer().Column(coluna=> {
                        coluna.Item().LineHorizontal(1f);
                        coluna.Item().Row(linha =>
                        {
                            linha.RelativeItem().Text($" Gerado em: {data:dd/MM/yyyy HH:mm:ss}");
                            linha.RelativeItem().AlignRight().Text(texto =>
                            {
                                texto.Span("Pagina ");
                                texto.CurrentPageNumber();
                                texto.Span(" de ");
                                texto.TotalPages();
                            });

                        });
                    });

                });
            });
            return documento;

        }

    }
}
