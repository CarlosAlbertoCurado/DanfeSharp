using System;
using System.Collections.Generic;
using System.Drawing;
using DanfeSharp.Graphics;
using DanfeSharp.Modelo;

namespace DanfeSharp.Blocos
{
    internal class TabelaProdutosServicos : ElementoBase
    {
        public CabecalhoBloco CabecalhoBloco { get; private set; }
        public Tabela Tabela { get; private set; }
        public DanfeViewModel ViewModel { get; private set; }

        public TabelaProdutosServicos(DanfeViewModel viewModel, Estilo estilo) : base(estilo)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
            CabecalhoBloco = new CabecalhoBloco(estilo, "DADOS DOS PRODUTOS / SERVIÇOS");

            var ad = AlinhamentoHorizontal.Direita;
            var ac = AlinhamentoHorizontal.Centro;
            var ae = AlinhamentoHorizontal.Esquerda;

            Tabela = new Tabela(Estilo);
            String cabecalho4 = ViewModel.Emitente.CRT == "3" ? "O/CST" : "O/CSOSN";

            if (ViewModel.IsRetrato)
            { 
                Tabela
                .ComColuna(7F, ac, "CÓDIGO", "PRODUTO")
                .ComColuna(0, ae, "DESCRIÇÃO DO PRODUTO / SERVIÇO")
                .ComColuna(5.1F, ac, "NCM/SH")
                .ComColuna(3.4F, ac, cabecalho4)
                .ComColuna(3.4F, ac, "CFOP")
                .ComColuna(2.75F, ac, "UN")
                .ComColuna(5.2F, ad, "QTDE")
                .ComColuna(5.5F, ad, "VALOR", "UNIT.")
                .ComColuna(5.5F, ad, "VALOR", "DESC.")
                .ComColuna(5.5F, ad, "VALOR", "TOTAL")
                .ComColuna(3.3F, ad, "RED BASE", "CALC ICMS")
                .ComColuna(5.5F, ad, "B CÁLC", "ICMS")
                .ComColuna(3F, ad, "ALIQ.", "ICMS")
                .ComColuna(4.5F, ad, "VALOR", "ICMS")
                .ComColuna(4.5F, ad, "VALOR", "IPI")
                .ComColuna(3F, ad, "ALIQ.", "IPI")
                .ComColuna(5.5F, ad, "BASE", "ICMSST")
                .ComColuna(3F, ad, "ALIQ.", "ICMSST")
                .ComColuna(5.5F, ad, "VALOR", "ICMSST");
            }
            else
            {
                Tabela
                .ComColuna(6.6f, ac, "CÓDIGO PRODUTO")
                .ComColuna(0, ae, "DESCRIÇÃO DO PRODUTO / SERVIÇO")
                .ComColuna(5F, ac, "NCM/SH")
                .ComColuna(2.6F, ac, cabecalho4)
                .ComColuna(2.9F, ac, "CFOP")
                .ComColuna(2.5F, ac, "UN")
                .ComColuna(4.55F, ad, "QTDE")
                .ComColuna(5.1F, ad, "VALOR UNIT.")
                .ComColuna(5.1F, ad, "VALOR DESC.")
                .ComColuna(5.1F, ad, "VALOR TOTAL")
                .ComColuna(3.3F, ad, "RED BASE", "CALC ICMS")
                .ComColuna(5.1F, ad, "B CÁLC ICMS")
                .ComColuna(2.5F, ad, "ALIQ.", "ICMS")
                .ComColuna(5.1F, ad, "VALOR ICMS")
                .ComColuna(5.1F, ad, "VALOR IPI")
                .ComColuna(2.5F, ad, "ALIQ.", "IPI")
                .ComColuna(5.1F, ad, "BASE", "ICMSST")
                .ComColuna(2.5F, ad, "ALIQ.", "ICMSST")
                .ComColuna(5.1F, ad, "VALOR", "ICMSST");
            }

            Tabela.AjustarLarguraColunas();

            foreach (var p in ViewModel.Produtos)
            {
                var linha = new List<String>
                {
                    p.Codigo,
                    p.DescricaoCompleta,
                    p.Ncm,
                    p.OCst,
                    p.Cfop.Formatar("N0"),
                    p.Unidade,
                    p.Quantidade.Formatar(),
                    p.ValorUnitario.Formatar(),
                    p.ValorDesconto.Formatar(),
                    p.ValorTotal.Formatar(),
                    p.AliqReducaoBC.Formatar(),
                    p.BaseIcms.Formatar(),
                    p.AliquotaIcms.Formatar(),
                    p.ValorIcms.Formatar(),
                    p.ValorIpi.Formatar(),
                    p.AliquotaIpi.Formatar(),
                    p.ValorBCIcmsST.Formatar(),
                    p.AliqIcmsST.Formatar(),
                    p.ValorIcmsST.Formatar(),
                };

                Tabela.AdicionarLinha(linha);
            }
        }

        public override void Draw(Gfx gfx)
        {
            base.Draw(gfx);

            Tabela.SetPosition(RetanguloTabela.Location);
            Tabela.SetSize(RetanguloTabela.Size);
            Tabela.Draw(gfx);

            CabecalhoBloco.SetPosition(X, Y);
            CabecalhoBloco.Width = Width;
            CabecalhoBloco.Draw(gfx);    
        }


        public RectangleF RetanguloTabela => BoundingBox.CutTop(CabecalhoBloco.Height);
        public Boolean CompletamenteDesenhada => Tabela.LinhaAtual == ViewModel.Produtos.Count;
        public override bool PossuiContono => false;
    }
}
