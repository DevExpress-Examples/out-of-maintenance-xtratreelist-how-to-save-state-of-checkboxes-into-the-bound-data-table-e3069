Imports DevExpress.XtraTreeList

Namespace XtraTreeListSaveCheckboxesState
    Partial Public Class Main
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(457, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemCheckEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(428, 435)
            Me.gridControl1.TabIndex = 1
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' treeList1
            ' 
            Me.treeList1.Dock = System.Windows.Forms.DockStyle.Left
            Me.treeList1.Location = New System.Drawing.Point(0, 0)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsView.ShowCheckBoxes = True
            Me.treeList1.Size = New System.Drawing.Size(457, 435)
            Me.treeList1.TabIndex = 2
            ' 
            ' repositoryItemCheckEdit1
            ' 
            Me.repositoryItemCheckEdit1.AutoHeight = False
            Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
            ' 
            ' Main
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(885, 435)
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.treeList1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Name = "Main"
            Me.Text = "Main"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private treeList1 As TreeList
        Private WithEvents repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    End Class
End Namespace

