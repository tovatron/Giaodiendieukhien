using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using System.Drawing;
using System.Runtime.Remoting.Contexts;
using System.Collections;
using System.Globalization;
using System.Net.NetworkInformation;

namespace Giaodiendieukhien.Sources
{
    public class class_Excel_Export
    {
        public void Excute(DateTimePicker dtpk_TimeFrom,
                           DateTimePicker dtpk_TimeTo,
                           ComboBox cbSelectReport)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                if (excelApp == null)
                {
                    MessageBox.Show("Lỗi không tìm thấy thư viện Excel");
                    return;
                }
                excelApp.Visible = false;
                object misValue = System.Reflection.Missing.Value;
                Workbook wb = excelApp.Workbooks.Add(misValue);
                Worksheet ws = (Worksheet)wb.Worksheets[1];
                if (ws == null)
                {
                    MessageBox.Show("Không tạo được WorkSheet");
                    return;
                }
                //============================HEADER DESIGN================================
                // Hình ảnh logo
                var imgRange = (Microsoft.Office.Interop.Excel.Range)ws.Cells[1, 1];
                Microsoft.Office.Interop.Excel.Range oRange = imgRange;
                const float Height = 50;
                const float Width = 50;
                string imgPath = "C:\\humglogo.png";
                float Left = (float)((double)oRange.Left);
                float Top = (float)((double)oRange.Top);
                var mso = Microsoft.Office.Core.MsoTriState.msoFalse;
                var msoCTrue = Microsoft.Office.Core.MsoTriState.msoCTrue;
                ws.Shapes.AddPicture(imgPath, mso, msoCTrue, Left, Top, Height, Width);
                //Tiêu đề
                Range company_name = ws.get_Range("B1");
                Range Adress = ws.get_Range("B2");
                Range Contact = ws.get_Range("B3");
                company_name.Value2 = "TRƯỜNG ĐẠI HỌC MỎ ĐỊA CHẤT - KHOA CƠ ĐIỆN - TỰ ĐỘNG HÓA";
                Adress.Value2 = "18 P. Viên, Đông Ngạc, Bắc Từ Liêm, Hà Nội";
                Contact.Value2 = "Hotline: +84 375 345 201";
                company_name.Font.Size = 14;
                company_name.Font.Name = "Times New Roman";
                company_name.Font.Bold = true;
                //Ngày giờ in báo cáo
                Range printtime = ws.get_Range("A4");
                string acttime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string printtimest = "Ngày tháng: " + acttime;
                printtime.Value2 = printtimest;
                excelApp.DisplayAlerts = false;
                //Tiêu đề báo cáo
                if (cbSelectReport.SelectedIndex == 0)
                {
                    Range tittle = ws.get_Range("A5", "H5");
                    tittle.Value2 = "BÁO CÁO SẢN XUẤT";
                    tittle.Merge();
                    tittle.Font.Size = 14;
                    tittle.Font.Name = "Times New Roman";
                    var alignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    tittle.Cells.HorizontalAlignment = alignment;
                }
                else if (cbSelectReport.SelectedIndex == 1)
                {
                    Range tittle = ws.get_Range("A5", "E5");
                    tittle.Value2 = "BÁO CÁO SẢN XUẤT";
                    tittle.Merge();
                    tittle.Font.Size = 14;
                    tittle.Font.Name = "Times New Roman";
                    var alignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    tittle.Cells.HorizontalAlignment = alignment;
                }
                excelApp.DisplayAlerts = true;
                //Tạo ô số thứ tự
                Range STT = ws.get_Range("A6");
                STT.Value2 = "STT";
                STT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                STT.ColumnWidth = 10;
                if (cbSelectReport.SelectedIndex == 0)
                {
                    //Tạo ô thời gian
                    Range sTimeB1 = ws.get_Range("B6");
                    sTimeB1.Value2 = "Thời gian Bunke 1";
                    sTimeB1.EntireColumn.NumberFormat = "yyyy-MM-dd HH:mm:ss.000";
                    sTimeB1.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    sTimeB1.ColumnWidth = 25;
                    //Tạo ô loadcell1_data
                    Range loadcell1_data = ws.get_Range("C6");
                    loadcell1_data.Value2 = "Bunke 1 (gram)";
                    loadcell1_data.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    loadcell1_data.ColumnWidth = 15;
                    //Tạo ô thời gian
                    Range sTimeB2 = ws.get_Range("D6");
                    sTimeB2.Value2 = "Thời gian Bunke 2";
                    sTimeB2.EntireColumn.NumberFormat = "yyyy-MM-dd HH:mm:ss.000";
                    sTimeB2.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    sTimeB2.ColumnWidth = 25;
                    //Tạo ô loadcell2_data
                    Range loadcell2_data = ws.get_Range("E6");
                    loadcell2_data.Value2 = "Bunke 2 (gram)";
                    loadcell2_data.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    loadcell2_data.ColumnWidth = 15;
                    //Tạo ô thời gian
                    Range sTimeB3 = ws.get_Range("F6");
                    sTimeB3.Value2 = "Thời gian Bunke 3";
                    sTimeB3.EntireColumn.NumberFormat = "yyyy-MM-dd HH:mm:ss.000";
                    sTimeB3.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    sTimeB3.ColumnWidth = 25;
                    //Tạo ô trạng thái sensor
                    Range sensor_status = ws.get_Range("G6");
                    sensor_status.Value2 = "Bunke 3 (status)";
                    sensor_status.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    sensor_status.ColumnWidth = 18;
                    //Tạo ô ghi chú
                    Range note = ws.get_Range("H6");
                    note.Value2 = "Ghi chú";
                    note.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    note.ColumnWidth = 30;
                    //Tô nền cho các cột tiêu đề:
                    Range tittle_style = ws.get_Range("A5", "H6");
                    var backcolor = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                    var fontcolor = ColorTranslator.ToOle(System.Drawing.Color.Black);
                    tittle_style.Interior.Color = backcolor;
                    tittle_style.Font.Color = fontcolor;
                    tittle_style.Font.Bold = true;
                }
                if (cbSelectReport.SelectedIndex == 1)
                {
                    //Tạo ô thời gian
                    Range sTime = ws.get_Range("B6");
                    sTime.Value2 = "Thời gian";
                    sTime.EntireColumn.NumberFormat = "yyyy-MM-dd HH:mm:ss.000";
                    sTime.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    sTime.ColumnWidth = 28;
                    //Tạo ô device_name
                    Range device_name = ws.get_Range("C6");
                    device_name.Value2 = "Thiết bị, tín hiệu";
                    device_name.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    device_name.ColumnWidth = 25;
                    //Tạo ô device_status
                    Range device_status = ws.get_Range("D6");
                    device_status.Value2 = "Trạng thái";
                    device_status.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    device_status.ColumnWidth = 15;
                    //Tạo ô ghi chú
                    Range note = ws.get_Range("E6");
                    note.Value2 = "Ghi chú";
                    note.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    note.ColumnWidth = 30;
                    //Tô nền cho các cột tiêu đề:
                    Range tittle_style = ws.get_Range("A5", "E6");
                    var backcolor = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                    var fontcolor = ColorTranslator.ToOle(System.Drawing.Color.Black);
                    tittle_style.Interior.Color = backcolor;
                    tittle_style.Font.Color = fontcolor;
                    tittle_style.Font.Bold = true;
                }
                if (cbSelectReport.SelectedIndex == 0)
                {
                    //=======================XUẤT CƠ SỞ DỮ LIỆU=====================
                    string Time_From = dtpk_TimeFrom.Value.ToString("yyyy-MM-dd HH:mm:ss.000");
                    string Time_To = dtpk_TimeTo.Value.ToString("yyyy-MM-dd HH:mm:ss.000");
                    Excel_ReportDataContext database = new Excel_ReportDataContext();
                    int row1 = 6; //Bắt đầu xuất từ dòng số 7
                    var datalist1 = from b3 in database.Bunke3_datas
                                    join b1 in database.Bunke1_datas on b3.ID equals b1.ID into b1Group
                                    from subBunke1 in b1Group.DefaultIfEmpty()
                                    join b2 in database.Bunke2_datas on b3.ID equals b2.ID into b2Group
                                    from subBunke2 in b2Group.DefaultIfEmpty()
                                    let date_time1 = (subBunke1 != null && subBunke1.date_time >= DateTime.Parse(Time_From) && subBunke1.date_time <= DateTime.Parse(Time_To)) ? subBunke1.date_time : (DateTime?)null
                                    let loadcell1_data = (subBunke1 != null && subBunke1.date_time >= DateTime.Parse(Time_From) && subBunke1.date_time <= DateTime.Parse(Time_To)) ? subBunke1.loadcell1_data : null
                                    let date_time2 = (subBunke2 != null && subBunke2.date_time >= DateTime.Parse(Time_From) && subBunke2.date_time <= DateTime.Parse(Time_To)) ? subBunke2.date_time : (DateTime?)null
                                    let loadcell2_data = (subBunke2 != null && subBunke2.date_time >= DateTime.Parse(Time_From) && subBunke2.date_time <= DateTime.Parse(Time_To)) ? subBunke2.loadcell2_data : null
                                    let date_time3 = (b3.date_time >= DateTime.Parse(Time_From) && b3.date_time <= DateTime.Parse(Time_To)) ? b3.date_time : (DateTime?)null
                                    let sensor_status = (b3.date_time >= DateTime.Parse(Time_From) && b3.date_time <= DateTime.Parse(Time_To)) ? b3.sensor_status : null
                                    where date_time1 != null || date_time2 != null || date_time3 != null
                                    select new
                                    {
                                        ID = subBunke1 != null ? subBunke1.ID : (subBunke2 != null ? subBunke2.ID : b3.ID),
                                        date_time1,
                                        loadcell1_data,
                                        date_time2,
                                        loadcell2_data,
                                        date_time3,
                                        sensor_status
                                    };
                    foreach (var element in datalist1)
                    {
                        row1++;
                        dynamic[] arr = { element.ID, element.date_time1, element.loadcell1_data, element.date_time2, element.loadcell2_data, element.date_time3, element.sensor_status };
                        Range rowData = ws.get_Range("A" + row1, "G" + row1);
                        rowData.Font.Size = 11;
                        rowData.Font.Name = "Times New Roman";
                        rowData.Value2 = arr;
                    }
                    //=======================TẠO TRƯỜNG CHỮ KÝ=====================
                    //Tạo ô chữ ký
                    int signrow = row1 + 2;
                    int signnote = signrow + 1;

                    // Người ký 1
                    string signpos1 = "B" + signrow;
                    string signnotepos1 = "B" + signnote;

                    Range sign1 = ws.get_Range(signpos1);
                    sign1.Value2 = "Giám đốc";
                    sign1.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    sign1.Font.Bold = true;

                    Range signnote1 = ws.get_Range(signnotepos1);
                    signnote1.Value2 = "(Ký ghi rõ họ tên)";
                    signnote1.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                    // Người ký 2
                    string signpos2 = "E" + signrow;
                    string signnotepos2 = "E" + signnote;

                    Range sign2 = ws.get_Range(signpos2);
                    sign2.Value2 = "Trưởng ca";
                    sign2.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    sign2.Font.Bold = true;

                    Range signnote2 = ws.get_Range(signnotepos2);
                    signnote2.Value2 = "(Ký ghi rõ họ tên)";
                    signnote2.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                    // Người ký 3
                    string signpos3 = "H" + signrow;
                    string signnotepos3 = "H" + signnote;

                    Range sign3 = ws.get_Range(signpos3);
                    sign3.Value2 = "Người in biểu";
                    sign3.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    sign3.Font.Bold = true;

                    Range signnote3 = ws.get_Range(signnotepos3);
                    signnote3.Value2 = "(Ký ghi rõ họ tên)";
                    signnote3.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    // ================CÁC PHẦN THIẾT KẾ KHÁC===================
                    class_Excel.BorderAround(ws.get_Range("A5", "H" + row1));
                    // Step 1: Lưu file excel xuống Ổ cứng
                    string datetimenow = DateTime.Now.ToString("yyyy_MM_dd HH_mm_ss");
                    string saveExcelFile = @"d:\Excel_Report_" + datetimenow + ".xlsx";
                    wb.SaveAs(saveExcelFile);
                    //Step 2: Đóng file để hoàn tất quá trình lưu trữ
                    wb.Close(true, misValue, misValue);
                    //Step 3: Thoát và thu hồi bộ nhớ cho COM
                    excelApp.Quit();
                    class_Excel.releaseObject(ws);
                    class_Excel.releaseObject(wb);
                    class_Excel.releaseObject(excelApp);
                    //Step 4: Mở File excel sau khi Xuất thành công
                    System.Diagnostics.Process.Start(saveExcelFile);
                }
                if (cbSelectReport.SelectedIndex == 1)
                {
                    string Time_From = dtpk_TimeFrom.Value.ToString("yyyy-MM-dd HH:mm:ss.000");
                    string Time_To = dtpk_TimeTo.Value.ToString("yyyy-MM-dd HH:mm:ss.000");
                    Excel_ReportDataContext database = new Excel_ReportDataContext();
                    var datalist = from tb in database.Devices_datas
                                   where
                                   tb.date_time >= DateTime.Parse(Time_From) &&
                                   tb.date_time < DateTime.Parse(Time_To)
                                   select new
                                   {
                                   date_time = tb.date_time,
                                   device_signal = tb.device_name,
                                   device_status = tb.device_status,
                                   note = tb.note,
                                   };
                    int stt = 0;
                    int row = 6; //Bắt đầu xuất từ dòng số 7
                    foreach (var element in datalist)
                    {
                        stt++;
                        row++;
                        dynamic[] arr = { stt, element.date_time, element.device_signal, element.device_status, element.note};
                        Range rowData = ws.get_Range("A" + row, "E" + row);
                        rowData.Font.Size = 11;
                        rowData.Font.Name = "Times New Roman";
                        rowData.Value2 = arr;
                    }
                    //=======================TẠO TRƯỜNG CHỮ KÝ=====================
                    //Tạo ô chữ ký
                    int signrow = row + 2;
                    int signnote = signrow + 1;

                    // Người ký 1
                    string signpos1 = "B" + signrow;
                    string signnotepos1 = "B" + signnote;

                    Range sign1 = ws.get_Range(signpos1);
                    sign1.Value2 = "Giám đốc";
                    sign1.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    sign1.Font.Bold = true;

                    Range signnote1 = ws.get_Range(signnotepos1);
                    signnote1.Value2 = "(Ký ghi rõ họ tên)";
                    signnote1.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                    // Người ký 2
                    string signpos2 = "D" + signrow;
                    string signnotepos2 = "D" + signnote;

                    Range sign2 = ws.get_Range(signpos2);
                    sign2.Value2 = "Trưởng ca";
                    sign2.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    sign2.Font.Bold = true;

                    Range signnote2 = ws.get_Range(signnotepos2);
                    signnote2.Value2 = "(Ký ghi rõ họ tên)";
                    signnote2.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                    // Người ký 3
                    string signpos3 = "F" + signrow;
                    string signnotepos3 = "F" + signnote;

                    Range sign3 = ws.get_Range(signpos3);
                    sign3.Value2 = "Người in biểu";
                    sign3.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    sign3.Font.Bold = true;

                    Range signnote3 = ws.get_Range(signnotepos3);
                    signnote3.Value2 = "(Ký ghi rõ họ tên)";
                    signnote3.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    // ================CÁC PHẦN THIẾT KẾ KHÁC===================
                    class_Excel.BorderAround(ws.get_Range("A5", "E" + row));
                    // Step 1: Lưu file excel xuống Ổ cứng
                    string datetimenow = DateTime.Now.ToString("yyyy_MM_dd HH_mm_ss");
                    string saveExcelFile = @"d:\Excel_Report_" + datetimenow + ".xlsx";
                    wb.SaveAs(saveExcelFile);
                    //Step 2: Đóng file để hoàn tất quá trình lưu trữ
                    wb.Close(true, misValue, misValue);
                    //Step 3: Thoát và thu hồi bộ nhớ cho COM
                    excelApp.Quit();
                    class_Excel.releaseObject(ws);
                    class_Excel.releaseObject(wb);
                    class_Excel.releaseObject(excelApp);
                    //Step 4: Mở File excel sau khi Xuất thành công
                    System.Diagnostics.Process.Start(saveExcelFile);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    public static class class_Excel
    {
        //Hàm kẻ khung cho Excel (mặc định)
        public static void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }
        //Hàm thu hồi bộ nhớ cho COM Excel (Mặc định)
        public static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                obj = null;
            }
            finally
            { GC.Collect(); }
        }
    }
}
