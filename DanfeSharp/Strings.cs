namespace DanfeSharp
{
    internal static class Strings
    {
        public const string InscricaoEstadual = "Inscrição Estadual";
        public const string Endereco = "Endereço";
        public const string Municipio = "Município";
        public const string UF = "UF";
        public const string CnpjCpf = "Cnpj / Cpf";
        public const string Quantidade = "Quantidade";
        public const string RazaoSocial = "Razão Social";
        public const string NomeRazaoSocial = "Nome / Razão Social";
        public const string FoneFax = "Fone / Fax";
        public const string Cep = "CEP";
        public const string BairroDistrito = "Bairro / Distrito";
        public const string TextoConsulta = "Consulta de autenticidade no portal nacional da NF-e www.nfe.fazenda.gov.br/portal ou no site da Sefaz Autorizadora";
        public const string TextoConsulta6512 = "Consulta de autenticidade em: https://www.sefaznet.ac.gov.br/nfce/consulta";
        public const string TextoConsulta6527 = "Consulta de autenticidade em: http://nfce.sefaz.al.gov.br/consultaNFCe.htm";
        public const string TextoConsulta6516 = "Consulta de autenticidade em: https://www.sefaz.ap.gov.br/sate/seg/SEGf_AcessarFuncao.jsp?cdFuncao=FIS_1261";
        public const string TextoConsulta6513 = "Consulta de autenticidade em: https://sistemas.sefaz.am.gov.br/nfceweb/formConsulta.do";
        public const string TextoConsulta6529 = "Consulta de autenticidade em: http://nfe.sefaz.ba.gov.br/servicos/nfce/Modulos/Geral/NFCEC_consulta_chave_acesso.aspx";
        public const string TextoConsulta6523 = "Consulta de autenticidade em: https://nfce.sefaz.ce.gov.br/pages/consultaNota.jsf";
        public const string TextoConsulta6553 = "Consulta de autenticidade em: https://ww1.receita.fazenda.df.gov.br/documentosfiscais/consultar";
        public const string TextoConsulta6532 = "Consulta de autenticidade em: http://app.sefaz.es.gov.br/ConsultaNFCe";
        public const string TextoConsulta6552 = "Consulta de autenticidade em: http://nfe.sefaz.go.gov.br/nfeweb/sites/nfe/consulta-completa";
        public const string TextoConsulta6521 = "Consulta de autenticidade em: http://www.nfce.sefaz.ma.gov.br/portal/consultaNFe.do?method=preFilterCupom&";
        public const string TextoConsulta6551 = "Consulta de autenticidade em: http://www.sefaz.mt.gov.br/nfce/consultanfce";
        public const string TextoConsulta6550 = "Consulta de autenticidade em: https://www.dfe.ms.gov.br/nfce/consulta";
        public const string TextoConsulta6531 = "Consulta de autenticidade em: http://nfce.fazenda.mg.gov.br/portalnfce/sistema/consultaarg.xhtml";
        public const string TextoConsulta6515 = "Consulta de autenticidade em: https://sefa.pa.gov.br/internal/services/iib";
        public const string TextoConsulta6525 = "Consulta de autenticidade em: https://www.sefaz.pb.gov.br/servirtual/documentos-fiscais/nfc-e/consultar-nfc-e";
        public const string TextoConsulta6541 = "Consulta de autenticidade em: https://sped.fazenda.pr.gov.br/NFCe/webservices/sped/nfce/completa";
        public const string TextoConsulta6526 = "Consulta de autenticidade em: http://nfce.sefaz.pe.gov.br/nfce/consulta";
        public const string TextoConsulta6522 = "Consulta de autenticidade em: https://www.sefaz.pi.gov.br/nfce/index.jsf";
        public const string TextoConsulta6533 = "Consulta de autenticidade em: https://www.nfce.fazenda.rj.gov.br/consulta";
        public const string TextoConsulta6524 = "Consulta de autenticidade em: http://nfce.set.rn.gov.br/portalDFE/NFCe/ConsultaNFCe.aspx";
        public const string TextoConsulta6543 = "Consulta de autenticidade em: https://www.sefaz.rs.gov.br/NFCE/NFCE-COM.aspx";
        public const string TextoConsulta6511 = "Consulta de autenticidade em: https://www.nfce.sefin.ro.gov.br";
        public const string TextoConsulta6514 = "Consulta de autenticidade em: https://portalweb.sefaz.rr.gov.br/nfce/servlet/wp_consulta_nfce";
        public const string TextoConsulta6542 = "Consulta de autenticidade em: https://sat.sef.sc.gov.br/tax.NET/Sat.Dfe.NFCe.Web/Consultas/ConsultaPublicaNFCe.aspx";
        public const string TextoConsulta6535 = "Consulta de autenticidade em: https://www.nfce.fazenda.sp.gov.br/NFCeConsultaPublica/Paginas/ConsultaPublica.aspx";
        public const string TextoConsulta6528 = "Consulta de autenticidade em: https://nfce.sefaz.se.gov.br/portal/portalNoticias.jsp?jsp=barra-menu/servicos/consultaDANFENFCe.htm";
        public const string TextoConsulta6517 = "Consulta de autenticidade em: https://www.sefaz.to.gov.br/nfce";

        public static string TxtConsulta(int docto, string uf)
        {
            switch (docto)
            {
                case 55:
                    return TextoConsulta;
                case 65:
                    switch (uf)
                    {
                        case "11":
                            return TextoConsulta6511;
                        case "12":
                            return TextoConsulta6512;
                        case "13":
                            return TextoConsulta6513;
                        case "14":
                            return TextoConsulta6514;
                        case "15":
                            return TextoConsulta6515;
                        case "16":
                            return TextoConsulta6516;
                        case "17":
                            return TextoConsulta6517;
                        case "21":
                            return TextoConsulta6521;
                        case "22":
                            return TextoConsulta6522;
                        case "23":
                            return TextoConsulta6523;
                        case "24":
                            return TextoConsulta6524;
                        case "25":
                            return TextoConsulta6525;
                        case "26":
                            return TextoConsulta6526;
                        case "27":
                            return TextoConsulta6527;
                        case "28":
                            return TextoConsulta6528;
                        case "29":
                            return TextoConsulta6529;
                        case "31":
                            return TextoConsulta6531;
                        case "32":
                            return TextoConsulta6532;
                        case "33":
                            return TextoConsulta6533;
                        case "35":
                            return TextoConsulta6535;
                        case "41":
                            return TextoConsulta6541;
                        case "42":
                            return TextoConsulta6542;
                        case "43":
                            return TextoConsulta6543;
                        case "50":
                            return TextoConsulta6550;
                        case "51":
                            return TextoConsulta6551;
                        case "52":
                            return TextoConsulta6552;
                        case "53":
                            return TextoConsulta6553;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            return "";
        }



    }
}