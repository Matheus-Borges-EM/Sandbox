
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

            Random rnd = new Random();
            
            for (int i = 1; i <= 10; i++)
            {
                planilha.Cells[1, i].Value = "Valor  " + i;
                planilha.Cells[2, i].Value = rnd.Next(0, 2);
                planilha.Cells[3, i].Value = rnd.Next(0, 2);
                planilha.Cells[4, i].Value = rnd.Next(0, 2);
                
            }

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

            planilha.Cells["A1:B5"].Merge = true;

            // planilha.Column(3).Hidden = true;
            _planilhaHelper.SaveAs(caminho);
        }

    }
}
