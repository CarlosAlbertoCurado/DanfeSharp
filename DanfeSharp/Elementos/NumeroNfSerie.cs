using DanfeSharp.Graphics;
using System;

namespace DanfeSharp
{
    class NumeroNfSerie : ElementoBase
    {
        public String NfNumero { get; private set; }
        public String NfSerie { get; private set; }
        public String ModDocto { get; private set; }

        public NumeroNfSerie(Estilo estilo, String nfNumero, String nfSerie, String modDocto) : base(estilo)
        {
            NfNumero = nfNumero;
            NfSerie = nfSerie;
            ModDocto = modDocto;
        }

        public override void Draw(Gfx gfx)
        {
            base.Draw(gfx);

            var r = BoundingBox.InflatedRetangle(1);

            var f1 = Estilo.CriarFonteNegrito(14);
            var f2 = Estilo.CriarFonteNegrito(11F);

            gfx.DrawString(ModDocto == "55" ? "NF-e" : "NFC-e", r, f1, AlinhamentoHorizontal.Centro);

            r = r.CutTop(f1.AlturaLinha);

            TextStack ts = new TextStack(r)
            {
                AlinhamentoHorizontal = AlinhamentoHorizontal.Centro,
                AlinhamentoVertical = AlinhamentoVertical.Centro,
                LineHeightScale = 1F
            }
            .AddLine($"Nº.: {NfNumero}", f2)
            .AddLine($"Série: {NfSerie}", f2);

            ts.Draw(gfx);

        }
    }
}