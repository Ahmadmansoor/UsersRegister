<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportForm))
        Me.ReprotDataSet = New UsersRegister.ReprotDataSet()
        Me.InOutTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InOutTableTableAdapter = New UsersRegister.ReprotDataSetTableAdapters.InOutTableTableAdapter()
        Me.TableAdapterManager = New UsersRegister.ReprotDataSetTableAdapters.TableAdapterManager()
        Me.UsersStampsTableAdapter = New UsersRegister.ReprotDataSetTableAdapters.UsersStampsTableAdapter()
        Me.InOutTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.InOutTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.InOutTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Bu_GetData = New System.Windows.Forms.Button()
        Me.CB_Year = New System.Windows.Forms.ComboBox()
        Me.CB_Month = New System.Windows.Forms.ComboBox()
        Me.UsersIdTextBox = New System.Windows.Forms.TextBox()
        Me.UsersStampsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserNameComboBox = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        UserNameLabel = New System.Windows.Forms.Label()
        CType(Me.ReprotDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InOutTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InOutTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InOutTableBindingNavigator.SuspendLayout()
        CType(Me.InOutTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.UsersStampsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserNameLabel
        '
        UserNameLabel.AutoSize = True
        UserNameLabel.Location = New System.Drawing.Point(9, 14)
        UserNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(90, 16)
        UserNameLabel.TabIndex = 1
        UserNameLabel.Text = "User Name:"
        '
        'ReprotDataSet
        '
        Me.ReprotDataSet.DataSetName = "ReprotDataSet"
        Me.ReprotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InOutTableBindingSource
        '
        Me.InOutTableBindingSource.DataMember = "InOutTable"
        Me.InOutTableBindingSource.DataSource = Me.ReprotDataSet
        '
        'InOutTableTableAdapter
        '
        Me.InOutTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.InOutTableTableAdapter = Me.InOutTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = UsersRegister.ReprotDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersStampsTableAdapter = Me.UsersStampsTableAdapter
        '
        'UsersStampsTableAdapter
        '
        Me.UsersStampsTableAdapter.ClearBeforeFill = True
        '
        'InOutTableBindingNavigator
        '
        Me.InOutTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.InOutTableBindingNavigator.BindingSource = Me.InOutTableBindingSource
        Me.InOutTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InOutTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.InOutTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.InOutTableBindingNavigatorSaveItem})
        Me.InOutTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.InOutTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InOutTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InOutTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InOutTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InOutTableBindingNavigator.Name = "InOutTableBindingNavigator"
        Me.InOutTableBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.InOutTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InOutTableBindingNavigator.Size = New System.Drawing.Size(1171, 25)
        Me.InOutTableBindingNavigator.TabIndex = 0
        Me.InOutTableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(73, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'InOutTableBindingNavigatorSaveItem
        '
        Me.InOutTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InOutTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("InOutTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InOutTableBindingNavigatorSaveItem.Name = "InOutTableBindingNavigatorSaveItem"
        Me.InOutTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.InOutTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'InOutTableDataGridView
        '
        Me.InOutTableDataGridView.AllowUserToAddRows = False
        Me.InOutTableDataGridView.AllowUserToDeleteRows = False
        Me.InOutTableDataGridView.AllowUserToOrderColumns = True
        Me.InOutTableDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InOutTableDataGridView.AutoGenerateColumns = False
        Me.InOutTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.InOutTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InOutTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.InOutTableDataGridView.DataSource = Me.InOutTableBindingSource
        Me.InOutTableDataGridView.Location = New System.Drawing.Point(4, 40)
        Me.InOutTableDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.InOutTableDataGridView.Name = "InOutTableDataGridView"
        Me.InOutTableDataGridView.Size = New System.Drawing.Size(1155, 535)
        Me.InOutTableDataGridView.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 29)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1171, 608)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage1.Controls.Add(Me.Bu_GetData)
        Me.TabPage1.Controls.Add(Me.CB_Year)
        Me.TabPage1.Controls.Add(Me.CB_Month)
        Me.TabPage1.Controls.Add(Me.UsersIdTextBox)
        Me.TabPage1.Controls.Add(UserNameLabel)
        Me.TabPage1.Controls.Add(Me.UserNameComboBox)
        Me.TabPage1.Controls.Add(Me.InOutTableDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1163, 579)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'Bu_GetData
        '
        Me.Bu_GetData.Location = New System.Drawing.Point(586, 11)
        Me.Bu_GetData.Name = "Bu_GetData"
        Me.Bu_GetData.Size = New System.Drawing.Size(75, 23)
        Me.Bu_GetData.TabIndex = 9
        Me.Bu_GetData.Text = "GetData"
        Me.Bu_GetData.UseVisualStyleBackColor = True
        '
        'CB_Year
        '
        Me.CB_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Year.FormattingEnabled = True
        Me.CB_Year.Items.AddRange(New Object() {"2016", "2017", "2018", "2019"})
        Me.CB_Year.Location = New System.Drawing.Point(391, 11)
        Me.CB_Year.Name = "CB_Year"
        Me.CB_Year.Size = New System.Drawing.Size(62, 24)
        Me.CB_Year.TabIndex = 7
        '
        'CB_Month
        '
        Me.CB_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Month.FormattingEnabled = True
        Me.CB_Month.Items.AddRange(New Object() {"1-January", "2-February", "3-March", "4-April", "5-May", "6-June", "7-July", "8-August", "9-September", "10-October", "11-November", "12-December"})
        Me.CB_Month.Location = New System.Drawing.Point(459, 11)
        Me.CB_Month.Name = "CB_Month"
        Me.CB_Month.Size = New System.Drawing.Size(121, 24)
        Me.CB_Month.TabIndex = 8
        '
        'UsersIdTextBox
        '
        Me.UsersIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersStampsBindingSource, "UsersId", True))
        Me.UsersIdTextBox.Location = New System.Drawing.Point(336, 11)
        Me.UsersIdTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UsersIdTextBox.Name = "UsersIdTextBox"
        Me.UsersIdTextBox.ReadOnly = True
        Me.UsersIdTextBox.Size = New System.Drawing.Size(49, 22)
        Me.UsersIdTextBox.TabIndex = 4
        '
        'UsersStampsBindingSource
        '
        Me.UsersStampsBindingSource.DataMember = "UsersStamps"
        Me.UsersStampsBindingSource.DataSource = Me.ReprotDataSet
        '
        'UserNameComboBox
        '
        Me.UserNameComboBox.DataSource = Me.UsersStampsBindingSource
        Me.UserNameComboBox.DisplayMember = "UserName"
        Me.UserNameComboBox.FormattingEnabled = True
        Me.UserNameComboBox.Location = New System.Drawing.Point(107, 11)
        Me.UserNameComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UserNameComboBox.Name = "UserNameComboBox"
        Me.UserNameComboBox.Size = New System.Drawing.Size(221, 24)
        Me.UserNameComboBox.TabIndex = 2
        Me.UserNameComboBox.ValueMember = "UserName"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1163, 579)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "InOutId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "InOutId"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "UserId"
        Me.DataGridViewTextBoxColumn2.HeaderText = "UserId"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "UserName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "UserName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TimeIn"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TimeIn"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TimeOut"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TimeOut"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DifTime"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DifTime"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'ReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1171, 642)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.InOutTableBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ReportForm"
        Me.Text = "ReportForm"
        CType(Me.ReprotDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InOutTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InOutTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InOutTableBindingNavigator.ResumeLayout(False)
        Me.InOutTableBindingNavigator.PerformLayout()
        CType(Me.InOutTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.UsersStampsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReprotDataSet As ReprotDataSet
    Friend WithEvents InOutTableBindingSource As BindingSource
    Friend WithEvents InOutTableTableAdapter As ReprotDataSetTableAdapters.InOutTableTableAdapter
    Friend WithEvents TableAdapterManager As ReprotDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InOutTableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents InOutTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents InOutTableDataGridView As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents UsersStampsTableAdapter As ReprotDataSetTableAdapters.UsersStampsTableAdapter
    Friend WithEvents UsersStampsBindingSource As BindingSource
    Friend WithEvents UsersIdTextBox As TextBox
    Friend WithEvents UserNameComboBox As ComboBox
    Friend WithEvents Bu_GetData As Button
    Friend WithEvents CB_Year As ComboBox
    Friend WithEvents CB_Month As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
