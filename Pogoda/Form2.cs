using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pogoda
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void bInteriaTemp_Click(object sender, EventArgs e)
        {
            var html = @"https://pogoda.interia.pl/prognoza-szczegolowa-gdansk,cId,8048";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//*[@id=\"weather-currently\"]/div[2]/div[1]/div/div[3]/div");

            
            if(node != null)
            {

                tInteriaTemp.Text = node.InnerText;
            }
            else
            {
                MessageBox.Show("brak danych");
            }
        }

        private void bMeteoTemp_Click(object sender, EventArgs e)
        {
            var html = @"https://www.meteoprog.pl/pl/weather/Gdansk/";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("/html/body/div[3]/main/article/section[1]/div/span/b");

            if (node != null)

            {
                tMeteoTemp.Text = node.InnerText ;
            }
            else
            {
                MessageBox.Show("brak danych");
            }
        }

        private void bNaszaTemp_Click(object sender, EventArgs e)
        {
            var html = @"https://pogoda.trojmiasto.pl/";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("/html/body/div[1]/div/div/div[2]/div[4]/div[1]/div/div[1]/ul/li[4]/span");

            if (node != null)

            {
                tNaszaTemp.Text = node.InnerText+"°C";
            }
            else
            {
                MessageBox.Show("brak danych");
            }
        }

        private void bMnsTemp_Click(object sender, EventArgs e)
        {
            var html = @"https://pogoda.wp.pl/pogoda-dlugoterminowa/gdansk/3099434";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//*[@id=\"__layout\"]/div/div[6]/div[1]/div/div[2]/div/div/table/tbody/tr/td[1]/span");

            if (node != null)

            {
                tMnsTemp.Text = node.InnerText + "°C";
            }
            else
            {
                MessageBox.Show("brak danych");
            }
        }

        private void bNaszaCis_Click(object sender, EventArgs e)
        {
            //
            var html = @"https://pogoda.trojmiasto.pl/";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//*[@id=\"gdansk\"]/div[1]/div[1]/div[3]/p[1]/span");

            if (node != null)

            {
                tNaszaCis.Text = node.InnerText + " hPa";
            }
            else
            {
                MessageBox.Show("brak danych");
            }

        }

        private void bInteriaCis_Click(object sender, EventArgs e)
        {
            var html = @"https://pogoda.interia.pl/prognoza-szczegolowa-gdansk,cId,8048";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("/html/body/div[4]/section/div[2]/div[1]/div/ul/li[3]/span");

            if (node != null)

            {
                tInteriaCis.Text = node.InnerText + "hPa";
            }
            else
            {
                MessageBox.Show("brak danych");
            }
        }

        private void bMeteoCis_Click(object sender, EventArgs e)
        {
            var html = @"https://www.meteoprog.pl/pl/weather/Gdansk/";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("/html/body/div[3]/main/article/section[1]/div/table/tbody/tr[3]/td/b");

            if (node != null)

            {
                tMeteoCis.Text = node.InnerText + " hPa";
            }
            else
            {
                MessageBox.Show("brak danych");
            }
        }

        private void bWpCis_Click(object sender, EventArgs e)
        {
            var html = @"https://pogoda.wp.pl/pogoda-dlugoterminowa/gdansk/3099434";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//*[@id=\"__layout\"]/div/div[6]/div[1]/div/div[2]/div/div/table/tbody/tr/td[3]/div/small/span");

            if (node != null)

            {
                tWpCis.Text = node.InnerText  + " hPa";
            }
            else
            {
                MessageBox.Show("brak danych");
            }
        }

        private void switchTo1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Hide();
        }
    }
}
