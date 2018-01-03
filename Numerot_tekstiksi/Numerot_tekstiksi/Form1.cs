using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numerot_tekstiksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void muunnaNappi_Click(object sender, EventArgs e)
        {
            int count = Regex.Matches(alkuperainenTeksti.Text, @"\d+").Count;
            string muunnettu = "";

            for (int i = 0; i < count; i++)
            {
                if (muunnettu != "")
                {
                    string seuraavaNumero = Regex.Match(muunnettu, @"\d+").Value;
                    int numero2 = int.Parse(seuraavaNumero);

                    var regex = new Regex(numero2.ToString());
                    muunnettu = regex.Replace(muunnettu, NumeroTekstiksi(numero2), 1);
                }
                else
                {
                    string ekaNumeroTekstista = Regex.Match(alkuperainenTeksti.Text, @"\d+").Value;
                    int numero1 = int.Parse(ekaNumeroTekstista);

                    var regex = new Regex(numero1.ToString());
                    muunnettu = regex.Replace(alkuperainenTeksti.Text, NumeroTekstiksi(numero1), 1);
                }
            }

            muunnettuTeksti.Text = muunnettu;
        }

        private string NumeroTekstiksi(int numero)
        {
            if (numero == 0)
            {
                return "nolla";
            }

            string sanat = "";

            if ((numero / 1000000) > 0)
            {
                if ((numero / 1000000) == 1)
                {
                    sanat += "miljoona ";
                }
                else
                {
                    sanat += NumeroTekstiksi(numero / 1000000) + "miljoonaa ";
                }
                numero %= 1000000;
            }

            if ((numero / 1000) > 0)
            {
                if ((numero / 1000) == 1)
                {
                    sanat += "tuhat ";
                }
                else
                {
                    sanat += NumeroTekstiksi(numero / 1000) + "tuhatta ";
                }
                numero %= 1000;
            }

            if ((numero / 100) > 0)
            {
                if ((numero / 100) == 1)
                {
                    sanat += "sata";
                }
                else
                {
                    sanat += NumeroTekstiksi(numero / 100) + "sataa ";
                }
                numero %= 100;
            }

            if (numero > 0)
            {
                string[] yksikot = new string[] { "nolla", "yksi", "kaksi", "kolme", "neljä", "viisi", "kuusi", "seitsemän", "kahdeksan", "yhdeksän", "kymmenen", "yksitoista", "kaksitoista", "kolmetoista", "neljätoista", "viisitoista", "kuusitoista", "seitsemäntoista", "kahdeksantoista", "yhdeksäntoista" };
                string[] kymmenet = new string[] { "nolla", "kymmenen", "kaksikymmentä", "kolmekymmentä", "neljäkymmentä", "viisikymmentä", "kuusikymmentä", "seitsemänkymmentä", "kahdeksankymmentä", "yhdeksänkymmentä" };

                if (numero < 20)
                {
                    sanat += yksikot[numero];
                }
                else
                {
                    sanat += kymmenet[numero / 10];
                    if ((numero % 10) > 0)
                    {
                        sanat += yksikot[numero % 10];
                    }
                }
            }

            return sanat;
        }
    }
}
