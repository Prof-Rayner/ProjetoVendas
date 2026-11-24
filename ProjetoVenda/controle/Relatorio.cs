using System;
using System.Collections.Generic;
using System.Text;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF;

namespace ProjetoVenda.controle
{
    internal class Relatorio
    {
        public Document gerarNota()
        {
            var documento = Document.Create(conteudo=> { // criando o documento

                conteudo.Page(pagina => {
                    pagina.Size(PageSizes.A6);
                    pagina.PageColor(QuestPDF.Infrastructure.Color.FromHex("f7f7c7"));
                    pagina.Margin(1, QuestPDF.Infrastructure.Unit.Centimetre);
                    pagina.DefaultTextStyle(font=>font.FontSize(10));

                    // repete em toda pagina
                    pagina.Header().Column(coluna=> {
                        coluna.Item().AlignCenter().Text("Cupom de Venda").FontSize(18);
                        coluna.Item().LineHorizontal(2);
                        coluna.Item().AlignCenter().Text("Mercadinho da Esquina").Bold();
                        coluna.Item().AlignCenter().Text("Rua das flores - 7070 - Sorocaba/SP").FontSize(5);
                        coluna.Item().LineHorizontal(0.5f);
                    });


                    pagina.Content();


                    // repete em toda pagina
                    pagina.Footer().Column(coluna =>
                    {
                        coluna.Item().LineHorizontal(0.5f);
                        coluna.Item().Text("Data: 23/11/2026");
                        coluna.Item().Text("Compre mais");

                        coluna.Item().Text("todos os produtos são de procedência duvidosa").FontSize(1);
                    });



                });

            });

            return documento;
        }


        public void salvarPdf()
        {
            var dialogo = new SaveFileDialog
            {
                Title = "Salvar Documento",
                FileName = "nota.pdf",
                Filter = "(PDF)|*.pdf"
            };
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                var documento = gerarNota();
                documento.GeneratePdf(dialogo.FileName);
            }
            
        }

    }
}
