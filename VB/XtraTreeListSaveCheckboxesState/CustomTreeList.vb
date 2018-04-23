Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraTreeList
Imports System.ComponentModel
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraTreeList.Nodes
Imports System.Data
Imports DevExpress.XtraTreeList.Nodes.Operations

Namespace XtraTreeListSaveCheckboxesState
	Friend Class CustomTreeList
		Inherits TreeList
		Private checkedStateFieldName_Renamed As String

		Public Sub New()
			MyBase.New()
		End Sub

		<Description("Gets or sets the data column for storing node's checked state"), Category("Data"), XtraSerializableProperty()> _
		Public Property CheckedStateFieldName() As String
			Get
				Return checkedStateFieldName_Renamed
			End Get
			Set(ByVal value As String)
				checkedStateFieldName_Renamed = value
				OnCheckedStateFieldNameChanged()
			End Set
		End Property

		Friend Sub OnCheckedStateFieldNameChanged()
			CustomTreeListStoreCheckedStateHelper.SetCheckedState(Me)
		End Sub

		Protected Overrides Sub InternalNodeChanged(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode, ByVal changeType As NodeChangeTypeEnum)
            If changeType = NodeChangeTypeEnum.CheckedState Then
                CustomTreeListStoreCheckedStateHelper.StoreCheckedState(node)
            End If
			MyBase.InternalNodeChanged(node, changeType)
		End Sub
	End Class

	Friend Class CustomTreeListStoreCheckedStateHelper
		Public Shared Sub StoreCheckedState(ByVal node As TreeListNode)
			Dim tl As CustomTreeList = TryCast(node.TreeList, CustomTreeList)
			If tl.CheckedStateFieldName Is Nothing OrElse tl.CheckedStateFieldName = "" Then
				Return
			End If
			TryCast(node.TreeList.DataSource, DataTable).Rows(node.Id)(tl.CheckedStateFieldName) = node.Checked
		End Sub

		Private Class CustomNodeOperation
			Inherits TreeListOperation
			Public Overrides Sub Execute(ByVal node As TreeListNode)
				node.Checked = CBool((TryCast(node.TreeList.DataSource, DataTable)).Rows(node.Id)((TryCast(node.TreeList, CustomTreeList)).CheckedStateFieldName))
			End Sub
		End Class

		Public Shared Sub SetCheckedState(ByVal tl As CustomTreeList)
			If (Not tl.OptionsView.ShowCheckBoxes) OrElse tl.CheckedStateFieldName Is Nothing OrElse tl.CheckedStateFieldName = "" Then
				Return
			End If

			tl.NodesIterator.DoOperation(New CustomNodeOperation())
		End Sub
	End Class
End Namespace
