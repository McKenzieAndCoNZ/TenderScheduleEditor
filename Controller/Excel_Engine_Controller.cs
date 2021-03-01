using Microsoft.Office.Core;
using Microsoft.Office.Interop.Excel;
using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.Controller
{
    public class Excel_Engine_Controller
    {
        public Workbook Create_TenderSchedule_Workbook(string path_to_workbook, 
                               ProjectFile_ViewModel project, string monthClaim_name)
        {
            Microsoft.Office.Interop.Excel.Application excel = null;
            Workbooks wbs = null;
            Workbook wb = null; 
            try
            {
                if (!File.Exists(path_to_workbook))
                {
                    MessageBox.Show("Source Workbook Does Not Exists at Give Path: " + path_to_workbook);
                    return null;
                }
                //Start Excel and get Application object.
                excel = new Microsoft.Office.Interop.Excel.Application
                {
                    DisplayAlerts = false
                };
                 
                wbs = excel.Workbooks;

                if (CreatePaymentScheduleWorksheet(wb))
                    wb.Save();

                if (CreateMonthlyClaimWorksheet(wb, monthClaim_name))
                    wb.Save();

                return wb; 
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null;
            }
            finally
            {
                excel.Quit();

                // Cleanup
                GC.Collect();
                GC.WaitForPendingFinalizers();

                Marshal.ReleaseComObject(wb);
                Marshal.ReleaseComObject(wbs);
                Marshal.ReleaseComObject(excel);

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private static bool CreateMonthlyClaimWorksheet(Workbook wb,string name)
        {
            try
            { 
                var ws = wb.Worksheets.Add();
                ws.Name = name;
                return true;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return false;
            }
        }

        private static bool CreatePaymentScheduleWorksheet(Workbook wb)
        {
            try
            {
                Range rng = null;
                var ws = wb.Sheets[1];
                ws.Name = "Payment Schedule";

                //=======Set ColumnWidth===========================================
                ws.Columns("A:A").ColumnWidth = 6.43;
                ws.Columns("B:B").ColumnWidth = 43.86;
                ws.Columns("C:C").ColumnWidth = 19.29;
                ws.Columns("D:D").ColumnWidth = 18.86;
                ws.Columns("E:E").ColumnWidth = 14.57;
                ws.Columns("F:F").ColumnWidth = 19;

                //=======Set RowHeight============================================
                ws.Rows("1:1").RowHeight = 99.75;
                ws.Rows("3:3").RowHeight = 44.25;
                ws.Rows("4:4").RowHeight = 26.25;
                ws.Rows("6:6").RowHeight = 25.5;
                ws.Rows("7:7").RowHeight = 26.25;
                ws.Rows("10:10").RowHeight = 26.25;
                ws.Rows("11:11").RowHeight = 26.25;
                ws.Rows("12:42").RowHeight = 18;

                //==================================================
                rng = ws.get_Range("A3");
                rng.Select();
                ws.ActiveCell.FormulaR1C1 = "[JOB NUMBER - STAGE - WORKS DECRIPTION]";
                rng = ws.get_Range("A3:F3");
                rng.Select();
                ws.Selection.HorizontalAlignment = Constants.xlCenter;
                ws.Selection.VerticalAlignment = Constants.xlCenter;
                ws.Selection.MergeCells = true;
                ws.Selection.Font.Name = "Axiforma Light"; 
                ws.Selection.Font.Size = 22;
                ws.Selection.Font.Bold = true;

                //==================================================
                rng = ws.get_Range("A4"); 
                rng.Select();
                ws.ActiveCell.FormulaR1C1 = "[CLIENT]";
                rng = ws.get_Range("A4:F4");
                rng.Select();
                ws.Selection.HorizontalAlignment = Constants.xlCenter;
                ws.Selection.VerticalAlignment = Constants.xlTop;
                ws.Selection.MergeCells = true;
                ws.Selection.Font.Name = "Abadi Extra Light";
                ws.Selection.Font.Size = 18;
                ws.Selection.Font.Bold = true;

                //==================================================
                rng = ws.get_Range("A6");
                rng.Select();
                ws.ActiveCell.FormulaR1C1 = "[TYPE OF WORK (EW OR CIVIL)]";
                rng = ws.get_Range("A6:F6");
                rng.Select();
                ws.Selection.HorizontalAlignment = Constants.xlCenter;
                ws.Selection.VerticalAlignment = Constants.xlCenter;
                ws.Selection.MergeCells = true;
                ws.Selection.Font.Name = "Axiforma Light";
                ws.Selection.Font.Size = 18;

                //==================================================
                rng = ws.get_Range("A7");
                rng.Select();
                ws.ActiveCell.FormulaR1C1 = "PROGRESS PAYMENT SCHEDULE";
                rng = ws.get_Range("A7:F7");
                rng.Select();
                ws.Selection.HorizontalAlignment = Constants.xlCenter;
                ws.Selection.VerticalAlignment = Constants.xlTop;
                ws.Selection.MergeCells = true;
                ws.Selection.Font.Name = "Axiforma Light";
                ws.Selection.Font.Size = 18;

                //==================================================
                rng = ws.get_Range("A8");
                rng.Select();
                ws.ActiveCell.FormulaR1C1 = "[CONTRACT TITLE]";
                rng = ws.get_Range("A8:F8");
                rng.Select();
                ws.Selection.HorizontalAlignment = Constants.xlCenter;
                ws.Selection.VerticalAlignment = Constants.xlTop;
                ws.Selection.MergeCells = true;
                ws.Selection.Font.Name = "Axiforma Light";
                ws.Selection.Font.Size = 12;

                //==================================================
                rng = ws.get_Range("A10");
                rng.Select();
                ws.ActiveCell.FormulaR1C1 = "[MMMM YYYY]";
                rng = ws.get_Range("A10:F10");
                rng.Select();
                ws.Selection.HorizontalAlignment = Constants.xlCenter;
                ws.Selection.VerticalAlignment = Constants.xlTop;
                ws.Selection.MergeCells = true;
                ws.Selection.Font.Name = "Axiforma Light";
                ws.Selection.Font.Size = 18;

                //==================================================
                ws.get_Range("B12:C21").Select();
                ws.Selection.Font.Name = "Axiforma Light";
                ws.Selection.Font.Size = 9;

                //==================================================
                rng = ws.get_Range("B12").Select;
                ws.ActiveCell.FormulaR1C1 = "CONTRACTOR:";
                rng = ws.get_Range("C12").Select;
                ws.ActiveCell.FormulaR1C1 = "[Contractor]";

                //==================================================
                rng = ws.get_Range("B13").Select;
                ws.ActiveCell.FormulaR1C1 = "ADDRESS:";
                rng = ws.get_Range("C13").Select;
                ws.ActiveCell.FormulaR1C1 = "[Contractor Address]";

                //==================================================
                rng = ws.get_Range("B14").Select;
                ws.ActiveCell.FormulaR1C1 = "SITE LOCATION:";
                rng = ws.get_Range("C14").Select;
                ws.ActiveCell.FormulaR1C1 = "[Contractor Site]";

                //==================================================
                rng = ws.get_Range("B15").Select;
                ws.ActiveCell.FormulaR1C1 = "PAYMENT NUMBER:";
                rng = ws.get_Range("C15").Select;
                ws.ActiveCell.FormulaR1C1 = "[Payment Number]";

                //==================================================
                rng = ws.get_Range("B16").Select;
                ws.ActiveCell.FormulaR1C1 = "PRINCIPAL:";
                rng = ws.get_Range("C16").Select;
                ws.ActiveCell.FormulaR1C1 = "[Principal]";

                //==================================================
                rng = ws.get_Range("B17").Select;
                ws.ActiveCell.FormulaR1C1 = "ADDRESS:";
                rng = ws.get_Range("C17").Select;
                ws.ActiveCell.FormulaR1C1 = "[Principal's Address]";

                //==================================================
                rng = ws.get_Range("B18").Select;
                ws.ActiveCell.FormulaR1C1 = "ENGINEER:";
                rng = ws.get_Range("C18").Select;
                ws.ActiveCell.FormulaR1C1 = "McKenzie & Co Consultants Limited";

                //==================================================
                rng = ws.get_Range("B19").Select;
                ws.ActiveCell.FormulaR1C1 = "ADDRESS:";
                rng = ws.get_Range("C19").Select;
                ws.ActiveCell.FormulaR1C1 = "Level 1, 2 Osterley Way, Manukau, 2104";

                //==================================================
                rng = ws.get_Range("B20").Select;
                ws.ActiveCell.FormulaR1C1 = "CONTRACTOR PROGRESS CLAIM No.:";
                rng = ws.get_Range("C20").Select;
                ws.ActiveCell.FormulaR1C1 = "[Progress Claim Number]";

                //==================================================
                rng = ws.get_Range("B21").Select;
                ws.ActiveCell.FormulaR1C1 = "PAYMENT CLAIM SUBMITED TO ENGINEER:";
                rng = ws.get_Range("C21").Select;
                ws.ActiveCell.FormulaR1C1 = "";

                //==================================================
                ws.get_Range("B23:C33").Select();
                ws.Selection.Font.Name = "Axiforma Light";
                ws.Selection.Font.Size = 9;
                ws.Selection.Font.Bold = true;
                ws.Selection.HorizontalAlignment = Constants.xlLeft;
                ws.Selection.VerticalAlignment = Constants.xlTop;

                //==================================================
                rng = ws.get_Range("C27").Select;
                ws.Selection.NumberFormat = @"_($* #,##0_);_($* (#,##0);_($* ""-""_);_(@_)"; 
                ws.ActiveCell.Value = "0";

                //==================================================
                ws.get_Range("B23").Select();
                ws.ActiveCell.FormulaR1C1 = "SUBTOTAL";
                rng = ws.get_Range("F23").Select;
                ws.ActiveCell.Formula = "=F62";

                //==================================================
                rng = ws.get_Range("B24").Select;
                ws.ActiveCell.FormulaR1C1 = "LESS 10% RETENTIONS ON FIRST $200,000";
                rng = ws.get_Range("F24").Select;
                ws.ActiveCell.Formula = "=IF(F23<200000,F23*0.1,200000*0.1)";

                //==================================================
                rng = ws.get_Range("B25").Select;
                ws.ActiveCell.FormulaR1C1 = "LESS 5% RETENTIONS FROM $200,001-$1,000,000";
                rng = ws.get_Range("F25").Select;
                ws.ActiveCell.Formula = "=IF(AND(F23>200000,F23<1000000),(F23-200000)*0.05,IF(F23>1000000, 800000*0.05,0))";

                //==================================================
                rng = ws.get_Range("B26").Select;
                ws.ActiveCell.FormulaR1C1 = "LESS 1.75% RETENTIONS FROM $1,000,001+";
                rng = ws.get_Range("F26").Select;
                ws.ActiveCell.Formula = "=IF(F23>1000000,(F23-1000000)*0.0175,0)";

                //==================================================
                rng = ws.get_Range("B27").Select;
                ws.ActiveCell.FormulaR1C1 = "RELEASE OF RETENTIONS";
                rng = ws.get_Range("C27").Select;
                ws.ActiveCell.Value = "0";
                rng = ws.get_Range("F27").Select;
                ws.ActiveCell.Formula = "=SUM(F24:F26)*$C$27";

                //==================================================
                rng = ws.get_Range("B28").Select;
                ws.ActiveCell.FormulaR1C1 = "TOTAL RETENTIONS";
                rng = ws.get_Range("F28").Select;
                ws.ActiveCell.Formula = "=SUM(F24:F26)-F27";

                //==================================================
                rng = ws.get_Range("B29").Select;
                ws.ActiveCell.FormulaR1C1 = "WORK VALUE LESS RETENTIONS";
                rng = ws.get_Range("F29").Select;
                ws.ActiveCell.Formula = "=F23-F28";

                //==================================================
                rng = ws.get_Range("B30").Select;
                ws.ActiveCell.FormulaR1C1 = "LESS PREVIOUSLY PAID";
                rng = ws.get_Range("F30").Select;
                ws.ActiveCell.Value = "0";

                //==================================================
                rng = ws.get_Range("B31").Select;
                ws.ActiveCell.FormulaR1C1 = "TOTAL";
                rng = ws.get_Range("F31").Select;
                ws.ActiveCell.Formula = "=F23-F24-F25-F26-F30";

                //==================================================
                rng = ws.get_Range("B32").Select;
                ws.ActiveCell.FormulaR1C1 = "GST (15%)";
                rng = ws.get_Range("F32").Select;
                ws.ActiveCell.Formula = "=F31*0.15";

                //==================================================
                rng = ws.get_Range("B33").Select;
                ws.ActiveCell.FormulaR1C1 = "TOTAL AMOUNT PAYABLE";
                rng = ws.get_Range("F33").Select;
                ws.ActiveCell.Formula = "=F32+F31";

                //==================================================
                ws.get_Range("F22").Select();
                ws.Selection.Font.Bold = true;
                ws.Selection.Font.Underline = Microsoft.Office.Interop.Excel.XlUnderlineStyle.xlUnderlineStyleSingle;
                ws.Selection.NumberFormat = "mmm-yy";
                ws.Selection.Interior.Pattern = Constants.xlSolid;
                ws.Selection.Interior.PatternColorIndex = Constants.xlAutomatic;
                ws.Selection.Interior.Color = 5287936;
                ws.Selection.Interior.ThemeColor = XlThemeColor.xlThemeColorAccent6;
                ws.Selection.Interior.TintAndShade = -0.249977111117893;

                //==================================================
                ws.get_Range("F23:F33").Select();
                ws.Selection.NumberFormat = @"_($* #,##0.00_);_($* (#,##0.00);_($* ""-""??_);_(@_)";

                //==================================================
                ws.get_Range("F33").Select();
                ws.Selection.Font.Bold = true;
                ws.Selection.Font.Underline = Microsoft.Office.Interop.Excel.XlUnderlineStyle.xlUnderlineStyleSingleAccounting;

                //==================================================
                ws.get_Range("D35").Select();
                ws.ActiveCell.FormulaR1C1 = "[Contractor]";
                ws.Selection.Font.Bold = true;
                ws.Selection.Underline = Microsoft.Office.Interop.Excel.XlUnderlineStyle.xlUnderlineStyleSingle;

                //==================================================
                ws.get_Range("B35").Select();
                ws.ActiveCell.FormulaR1C1 = "THIS IS TO CERTIFY THAT";

                //==================================================
                ws.get_Range("D36").Select();
                ws.ActiveCell.FormulaR1C1 = "=F33";
                ws.Selection.NumberFormat = @"_($* #,##0.00_);_($* (#,##0.00);_($* ""-""??_);_(@_)";
                ws.Selection.Font.Bold = true;
                ws.Selection.Underline = Microsoft.Office.Interop.Excel.XlUnderlineStyle.xlUnderlineStyleSingle;

                //==================================================
                ws.get_Range("B36").Select();
                ws.ActiveCell.FormulaR1C1 = "IS ENTITLED TO RECEIVE THE SUM OF";

                //==================================================
                ws.get_Range("E36").Select();
                ws.ActiveCell.FormulaR1C1 = "(Including GST.)";

                //==================================================
                ws.get_Range("D37").Select();
                // ws.ActiveCell.FormulaR1C1 = "=( &@ spellnumber(D36) &,including GST)"; 
                ws.ActiveCell.FormulaR1C1 = "\"(\" &@ spellnumber(D36) & \",including GST)\""; 
                ws.Selection.HorizontalAlignment = Constants.xlCenter;
                ws.Selection.VerticalAlignment = Constants.xlBottom;

                //==================================================
                ws.get_Range("B39").Select(); 
                ws.ActiveCell.Value = "Signed";
                ws.Selection.HorizontalAlignment = Constants.xlRight;
                ws.Selection.VerticalAlignment = Constants.xlTop;

                //==================================================
                ws.get_Range("B40").Select(); 
                ws.ActiveCell.Value = "Andrew Hunter";
                ws.Selection.HorizontalAlignment = Constants.xlRight;
                ws.Selection.VerticalAlignment = Constants.xlTop;

                //==================================================
                ws.get_Range("B41").Select(); 
                ws.ActiveCell.Value = "Date";
                ws.Selection.HorizontalAlignment = Constants.xlRight;
                ws.Selection.VerticalAlignment = Constants.xlTop;

                //==================================================
                ws.get_Range("C41").Select(); 
                ws.ActiveCell.Formula = "=A10";
                ws.Selection.HorizontalAlignment = Constants.xlRight;
                ws.Selection.VerticalAlignment = Constants.xlTop;

                //==================================================
                ws.get_Range("D41").Select();
                ws.ActiveCell.Value = "(ENGINEER TO THE CONTRACT OR ENGINEER's REPRESENTATIVE)"; 
                ws.Selection.VerticalAlignment = Constants.xlTop;

                //==================================================
                ws.get_Range("B43").Select();
                ws.ActiveCell.Value = "The sum certified in the payment certifcate is provisional only," +
                    "subject to any amendments by the principal or the expiry of 12 working days after the date of issue.";
                ws.Selection.HorizontalAlignment = Constants.xlLeft;
                ws.Selection.VerticalAlignment = Constants.xlTop;

                //==================================================
                ws.get_Range("B49").Select();
                ws.ActiveCell.Value = "SUMMARY";
                ws.Selection.Font.Bold = true;
                ws.Selection.VerticalAlignment = Constants.xlTop;

                //==================================================
                ws.get_Range("B50").Select();
                ws.ActiveCell.Value = "FOR THE MONTH OF"; 
                ws.Selection.VerticalAlignment = Constants.xlTop;

                //==================================================
                ws.get_Range("B51").Select();
                ws.ActiveCell.FormulaR1C1 = "=A10";
                ws.Selection.Font.Bold = true;
                ws.Selection.HorizontalAlignment = Constants.xlLeft;
                ws.Selection.VerticalAlignment = Constants.xlTop;

                //==================================================
                ws.get_Range("C51:F51").Select();
                ws.Selection.Font.Bold = true;
                ws.Selection.HorizontalAlignment = Constants.xlCenter;
                ws.Selection.VerticalAlignment = Constants.xlCenter;
                ws.Selection.Interior.Pattern =XlPattern.xlPatternSolid; 
                ws.Selection.Interior.PatternColorIndex = XlPattern.xlPatternAutomatic;
                ws.Selection.Interior.ThemeColor = XlThemeColor.xlThemeColorAccent6;
                ws.Selection.Interior.TintAndShade = -0.249977111117893;
                ws.Selection.Interior.PatternTintAndShade = 0;

                //==================================================
                ws.get_Range("C51").Select();
                ws.ActiveCell.Value = "Contract Value"; 

                //==================================================
                ws.get_Range("D51:F51").Select();
                ws.Selection.Font.Underline = true;

                //==================================================
                ws.get_Range("D51").Select();
                ws.ActiveCell.Value = "Previous";

                //==================================================
                ws.get_Range("E51").Select();
                ws.ActiveCell.Value = "This Period";

                //==================================================
                ws.get_Range("F51").Select();
                ws.ActiveCell.Value = "Total";

                //==================================================
                ws.get_Range("G51:H51").Select();
                ws.Selection.Font.Bold = true;
                ws.Selection.WrapText = true;
                ws.Selection.HorizontalAlignment = Constants.xlCenter;
                ws.Selection.VerticalAlignment = Constants.xlCenter;

                //==================================================
                ws.get_Range("G51").Select();
                ws.ActiveCell.Value = "Contract Value Remaining ";

                //==================================================
                ws.get_Range("H51").Select();
                ws.ActiveCell.Value = "WORKS VALUE REMAINING";

                return true;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return false;
            }
        }
    }
} 