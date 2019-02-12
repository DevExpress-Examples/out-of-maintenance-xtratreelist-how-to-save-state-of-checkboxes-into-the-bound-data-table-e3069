using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XtraTreeListSaveCheckboxesState {
    public partial class Main : XtraForm {
        public Main() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            DataTable dt = FillDataTable();

            treeList1.DataSource = dt;
            treeList1.CheckBoxFieldName = "CheckBoxState";
            treeList1.Columns["CheckBoxState"].Visible = false;

            gridControl1.DataSource = dt;
            gridView1.Columns["CheckBoxState"].ColumnEdit = repositoryItemCheckEdit1;
        }

        DataTable FillDataTable() {
            DataTable _dataTable = new DataTable();
            DataColumn col;
            DataRow row;

            col = new DataColumn();
            col.ColumnName = "Plant";
            col.DataType = System.Type.GetType("System.String");
            _dataTable.Columns.Add(col);

            col = new DataColumn();
            col.ColumnName = "ID";
            col.DataType = System.Type.GetType("System.Int32");
            col.Unique = true;
            _dataTable.Columns.Add(col);

            col = new DataColumn();
            col.ColumnName = "ParentID";
            col.DataType = System.Type.GetType("System.Int32");
            _dataTable.Columns.Add(col);

            col = new DataColumn();
            col.ColumnName = "CheckBoxState";
            col.DataType = System.Type.GetType("System.Boolean");
            _dataTable.Columns.Add(col);

            row = _dataTable.NewRow();
            row["ID"] = 1; row["ParentID"] = 0; row["Plant"] = "Fruit"; row["CheckBoxState"] = "True";
            _dataTable.Rows.Add(row);
            row = _dataTable.NewRow();
            row["ID"] = 2; row["ParentID"] = 1; row["Plant"] = "Apple"; row["CheckBoxState"] = "False";
            _dataTable.Rows.Add(row);
            row = _dataTable.NewRow();
            row["ID"] = 3; row["ParentID"] = 1; row["Plant"] = "Banana"; row["CheckBoxState"] = "True";
            _dataTable.Rows.Add(row);
            row = _dataTable.NewRow();
            row["ID"] = 4; row["ParentID"] = 1; row["Plant"] = "Peach"; row["CheckBoxState"] = "False";
            _dataTable.Rows.Add(row);

            return _dataTable;
        }

        private void OnEditValueChanged(object sender, EventArgs e) {
            gridView1.PostEditor();
            gridView1.UpdateCurrentRow();
        }
    }
}
