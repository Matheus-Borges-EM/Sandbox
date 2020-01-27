using OfficeOpenXml;
using System;
using System.Windows.Forms;

namespace TestesEpplus
{
    public partial class Form1 : Form
    {

        private Montador Montador = new Montador();
        private ExcelWorksheet Planilha;

        public Form1()
        {
            Planilha = Montador._planilhaHelper.Workbook.Worksheets.Add("Sheet 1");
            InitializeComponent();
        }

        private void btnEmite_Click(object sender, EventArgs e)
        {
            Montador.MontePlanilha(Planilha);
        }

        private void btnAltere_Click(object sender, EventArgs e)
        {
            Montador.AlterePlanilha(Planilha);
        }
    }
}
