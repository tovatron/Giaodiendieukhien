using Giaodiendieukhien.Sources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Giaodiendieukhien
{
    public partial class UC_Baocao : UserControl
    {
        public static UC_Baocao UCReport;
        public UC_Baocao()
        {
            InitializeComponent();
            UCReport = this;
        }

        private void UC_Baocao_Load(object sender, EventArgs e)
        {
            cBoxSelectReport.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Time_From = dtpkFrom.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string Time_To = dtpkTo.Value.ToString("yyyy-MM-dd HH:mm:ss.fff");
            if (cBoxSelectReport.SelectedIndex == 0)
            {
                string tablenameBunke1 = "Bunke1_data";
                string tablenameBunke2 = "Bunke2_data";
                string tablenameBunke3 = "Bunke3_data";
                string sqlSelect = $@"
                    SELECT 
                COALESCE({tablenameBunke1}.ID, {tablenameBunke2}.ID, {tablenameBunke3}.ID) AS ID,
                CASE 
                    WHEN {tablenameBunke1}.date_time BETWEEN '{Time_From}' AND '{Time_To}' THEN {tablenameBunke1}.date_time
                    ELSE NULL 
                END AS date_time1,
                CASE 
                    WHEN {tablenameBunke1}.date_time BETWEEN '{Time_From}' AND '{Time_To}' THEN {tablenameBunke1}.loadcell1_data
                ELSE NULL 
                END AS loadcell1_data,
                CASE 
                    WHEN {tablenameBunke2}.date_time BETWEEN '{Time_From}' AND '{Time_To}' THEN {tablenameBunke2}.date_time
                    ELSE NULL 
                END AS date_time2,
                CASE 
                    WHEN {tablenameBunke2}.date_time BETWEEN '{Time_From}' AND '{Time_To}' THEN {tablenameBunke2}.loadcell2_data
                    ELSE NULL 
                END AS loadcell2_data,
                CASE 
                    WHEN {tablenameBunke3}.date_time BETWEEN '{Time_From}' AND '{Time_To}' THEN {tablenameBunke3}.date_time
                    ELSE NULL 
                END AS date_time3,
                CASE 
                    WHEN {tablenameBunke3}.date_time BETWEEN '{Time_From}' AND '{Time_To}' THEN {tablenameBunke3}.sensor_status
                    ELSE NULL 
                END AS sensor_status
                FROM 
                    {tablenameBunke3}
                LEFT JOIN 
                    {tablenameBunke1} ON {tablenameBunke3}.ID = {tablenameBunke1}.ID
                LEFT JOIN 
                    {tablenameBunke2} ON {tablenameBunke3}.ID = {tablenameBunke2}.ID
                WHERE 
                    ({tablenameBunke1}.date_time BETWEEN '{Time_From}' AND '{Time_To}') OR
                    ({tablenameBunke2}.date_time BETWEEN '{Time_From}' AND '{Time_To}') OR
                    ({tablenameBunke3}.date_time BETWEEN '{Time_From}' AND '{Time_To}');
            ";

                class_Database.sqlDisplay(sqlSelect, dtGVShowReport);
                dtGVShowReport.Columns[0].HeaderText = "ID";
                dtGVShowReport.Columns[1].HeaderText = "Thời gian (Bunke 1)";
                dtGVShowReport.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss.fff";
                dtGVShowReport.Columns[2].HeaderText = "Khối lượng (Bunke 1)";
                dtGVShowReport.Columns[3].HeaderText = "Thời gian (Bunke 2)";
                dtGVShowReport.Columns[3].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss.fff";
                dtGVShowReport.Columns[4].HeaderText = "Khối lượng (Bunke 2)";
                dtGVShowReport.Columns[5].HeaderText = "Thời gian (Bunke 3)";
                dtGVShowReport.Columns[5].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss.fff";
                dtGVShowReport.Columns[6].HeaderText = "Cảm biến Status (Bunke 3)";
            }
            if (cBoxSelectReport.SelectedIndex == 1)
            {
                string tablenameDevices = "Devices_data";
                string sqlSelect = "SELECT date_time, device_name, device_status, note FROM "
                    + tablenameDevices + " WHERE date_time BETWEEN '"
                    + Time_From + "' AND '" + Time_To + "' " +
                    "ORDER BY date_time";
                class_Database.sqlDisplay(sqlSelect, dtGVShowReport);
                dtGVShowReport.Columns[0].HeaderText = "Ngày tháng";
                dtGVShowReport.Columns[0].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss.fff";
                dtGVShowReport.Columns[1].HeaderText = "Thiết bị, tín hiệu";
                dtGVShowReport.Columns[2].HeaderText = "Trạng thái";
                dtGVShowReport.Columns[3].HeaderText = "Ghi chú";
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DialogResult ReportConfirm = MessageBox.Show("Bạn có muốn xuất báo cáo Excel không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ReportConfirm == DialogResult.Yes)
            {
                class_Excel_Export fn_Export = new class_Excel_Export();
                fn_Export.Excute(dtpkFrom, dtpkTo, cBoxSelectReport);
            }
        }
    }
}
