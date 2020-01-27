
using OfficeOpenXml;
using System;
using System.IO;

namespace TestesEpplus
{
    class Montador
    {

        public ExcelPackage _planilhaHelper { get; set; }

        public FileInfo caminho { get; set; }


        public Montador()
        {
            _planilhaHelper = new ExcelPackage();
        }

        public ExcelWorksheet MontePlanilha(ExcelWorksheet planilha)
        {

            //Set some properties of the Excel document    
            _planilhaHelper.Workbook.Properties.Author = "Matheus Borges";
            _planilhaHelper.Workbook.Properties.Title = "Testando";
            _planilhaHelper.Workbook.Properties.Subject = "Teste top";
            _planilhaHelper.Workbook.Properties.Created = DateTime.Now;

            //Add some text to cell A1
            planilha.Cells[1, 1].Value = "My first EPPlus spreadsheet!";     //You could also use [line, column] notation:     
            planilha.Cells[1, 2].Value = "This is cell B1!";

            //Save your file     
            caminho = new FileInfo($@"C:\Users\Usuario\Desktop\Sandbox\PlanilhasTestes\teste.xlsx");
            _planilhaHelper.SaveAs(caminho);

            return planilha;

        }

        public void MonteCelula(ExcelWorksheet planilha)
        {

        }

        public void AlterePlanilha(ExcelWorksheet planilha)
        {
            planilha.Cells[4, 1].Value = $"Voce alterou a planilha hein";
            _planilhaHelper.SaveAs(caminho);
        }

    }
}
