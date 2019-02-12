Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace XtraTreeListSaveCheckboxesState
    Partial Public Class Main
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            Dim dt As DataTable = FillDataTable()

            treeList1.DataSource = dt
            treeList1.CheckBoxFieldName = "CheckBoxState"
            treeList1.Columns("CheckBoxState").Visible = False

            gridControl1.DataSource = dt
            gridView1.Columns("CheckBoxState").ColumnEdit = repositoryItemCheckEdit1
        End Sub

        Private Function FillDataTable() As DataTable
            Dim _dataTable As New DataTable()
            Dim col As DataColumn
            Dim row As DataRow

            col = New DataColumn()
            col.ColumnName = "Plant"
            col.DataType = System.Type.GetType("System.String")
            _dataTable.Columns.Add(col)

            col = New DataColumn()
            col.ColumnName = "ID"
            col.DataType = System.Type.GetType("System.Int32")
            col.Unique = True
            _dataTable.Columns.Add(col)

            col = New DataColumn()
            col.ColumnName = "ParentID"
            col.DataType = System.Type.GetType("System.Int32")
            _dataTable.Columns.Add(col)

            col = New DataColumn()
            col.ColumnName = "CheckBoxState"
            col.DataType = System.Type.GetType("System.Boolean")
            _dataTable.Columns.Add(col)

            row = _dataTable.NewRow()
            row("ID") = 1
            row("ParentID") = 0
            row("Plant") = "Fruit"
            row("CheckBoxState") = "True"
            _dataTable.Rows.Add(row)
            row = _dataTable.NewRow()
            row("ID") = 2
            row("ParentID") = 1
            row("Plant") = "Apple"
            row("CheckBoxState") = "False"
            _dataTable.Rows.Add(row)
            row = _dataTable.NewRow()
            row("ID") = 3
            row("ParentID") = 1
            row("Plant") = "Banana"
            row("CheckBoxState") = "True"
            _dataTable.Rows.Add(row)
            row = _dataTable.NewRow()
            row("ID") = 4
            row("ParentID") = 1
            row("Plant") = "Peach"
            row("CheckBoxState") = "False"
            _dataTable.Rows.Add(row)

            Return _dataTable
        End Function

        Private Sub OnEditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles repositoryItemCheckEdit1.EditValueChanged
            gridView1.PostEditor()
            gridView1.UpdateCurrentRow()
        End Sub
    End Class
End Namespace
