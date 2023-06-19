using System.Windows.Forms;


namespace XML_to_Tabbed_Datagridview_example.functions
{
    class DGV_Functions
    {

        public static void SetUpViews(DataGridView dgv, int NumCols)
        {
            dgv.ColumnCount = NumCols;

            if (dgv.Name == "dgv_tab1")
            {
                dgv.Columns[0].Name = "Name";
                dgv.Columns[1].Name = "Amount";
            }
           else if (dgv.Name == "dgv_tab2")
            {
                dgv.Columns[0].Name = "Name";
                dgv.Columns[1].Name = "Monthly";
            }
            else if (dgv.Name == "dgv_tab3")
            {
                dgv.Columns[0].Name = "Year";
                dgv.Columns[1].Name = "Name";
                dgv.Columns[2].Name = "Amount";
            }
            

            dgv.AllowUserToAddRows = false; //remove last empty row
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //fit columns to grid view 
            dgv.RowHeadersVisible = false; //remove left hand column

        }

        public static void ClearData(DataGridView dgv1, DataGridView dgv2, DataGridView dgv3)
        {
            dgv1.Rows.Clear();
            dgv1.Refresh();

            dgv2.Rows.Clear();
            dgv2.Refresh();

            dgv3.Rows.Clear();
            dgv3.Refresh();
            
        }
    }
}
