<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccessForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccessForm))
        Me.Bu_Exit = New System.Windows.Forms.Button()
        Me.AxZKFPEngX1 = New AxZKFPEngXControl.AxZKFPEngX()
        Me.IOUsersDataSet = New UsersRegister.IOUsersDataSet()
        Me.InOutTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InOutTableTableAdapter = New UsersRegister.IOUsersDataSetTableAdapters.InOutTableTableAdapter()
        Me.TableAdapterManager = New UsersRegister.IOUsersDataSetTableAdapters.TableAdapterManager()
        Me.UsersStampsTableAdapter = New UsersRegister.IOUsersDataSetTableAdapters.UsersStampsTableAdapter()
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
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsersStampsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PB_Stamp = New System.Windows.Forms.PictureBox()
        CType(Me.AxZKFPEngX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IOUsersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InOutTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InOutTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InOutTableBindingNavigator.SuspendLayout()
        CType(Me.InOutTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersStampsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PB_Stamp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bu_Exit
        '
        Me.Bu_Exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bu_Exit.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bu_Exit.Location = New System.Drawing.Point(1093, 599)
        Me.Bu_Exit.Margin = New System.Windows.Forms.Padding(4)
        Me.Bu_Exit.Name = "Bu_Exit"
        Me.Bu_Exit.Size = New System.Drawing.Size(101, 68)
        Me.Bu_Exit.TabIndex = 0
        Me.Bu_Exit.Text = "Exit"
        Me.Bu_Exit.UseVisualStyleBackColor = True
        '
        'AxZKFPEngX1
        '
        Me.AxZKFPEngX1.Enabled = True
        Me.AxZKFPEngX1.Location = New System.Drawing.Point(968, 12)
        Me.AxZKFPEngX1.Name = "AxZKFPEngX1"
        Me.AxZKFPEngX1.OcxState = CType(resources.GetObject("AxZKFPEngX1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxZKFPEngX1.Size = New System.Drawing.Size(24, 24)
        Me.AxZKFPEngX1.TabIndex = 1
        '
        'IOUsersDataSet
        '
        Me.IOUsersDataSet.DataSetName = "IOUsersDataSet"
        Me.IOUsersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InOutTableBindingSource
        '
        Me.InOutTableBindingSource.DataMember = "InOutTable"
        Me.InOutTableBindingSource.DataSource = Me.IOUsersDataSet
        '
        'InOutTableTableAdapter
        '
        Me.InOutTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.InOutTableTableAdapter = Me.InOutTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = UsersRegister.IOUsersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.InOutTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InOutTableBindingNavigator.Size = New System.Drawing.Size(1196, 25)
        Me.InOutTableBindingNavigator.TabIndex = 2
        Me.InOutTableBindingNavigator.Text = "BindingNavigator1"
        Me.InOutTableBindingNavigator.Visible = False
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        Me.InOutTableDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.InOutTableDataGridView.Name = "InOutTableDataGridView"
        Me.InOutTableDataGridView.Size = New System.Drawing.Size(1191, 592)
        Me.InOutTableDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "InOutId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "InOutId"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "UserId"
        Me.DataGridViewTextBoxColumn2.HeaderText = "UserId"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "UserName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "UserName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
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
        'UsersStampsBindingSource
        '
        Me.UsersStampsBindingSource.DataMember = "UsersStamps"
        Me.UsersStampsBindingSource.DataSource = Me.IOUsersDataSet
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel3, Me.StatusLabel1, Me.StatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 671)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1196, 26)
        Me.StatusStrip1.TabIndex = 34
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLabel3
        '
        Me.StatusLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel3.Name = "StatusLabel3"
        Me.StatusLabel3.Size = New System.Drawing.Size(177, 21)
        Me.StatusLabel3.Text = "ToolStripStatusLabel1"
        Me.StatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatusLabel1
        '
        Me.StatusLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel1.Name = "StatusLabel1"
        Me.StatusLabel1.Size = New System.Drawing.Size(94, 21)
        Me.StatusLabel1.Text = "Sensor Number :"
        Me.StatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatusLabel2
        '
        Me.StatusLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel2.Name = "StatusLabel2"
        Me.StatusLabel2.Size = New System.Drawing.Size(87, 21)
        Me.StatusLabel2.Text = "Serial Number :"
        Me.StatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PB_Stamp
        '
        Me.PB_Stamp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PB_Stamp.BackgroundImage = Global.UsersRegister.My.Resources.Resources._error
        Me.PB_Stamp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_Stamp.Location = New System.Drawing.Point(996, 599)
        Me.PB_Stamp.Name = "PB_Stamp"
        Me.PB_Stamp.Size = New System.Drawing.Size(81, 66)
        Me.PB_Stamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Stamp.TabIndex = 35
        Me.PB_Stamp.TabStop = False
        '
        'AccessForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1196, 697)
        Me.Controls.Add(Me.PB_Stamp)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.InOutTableDataGridView)
        Me.Controls.Add(Me.AxZKFPEngX1)
        Me.Controls.Add(Me.InOutTableBindingNavigator)
        Me.Controls.Add(Me.Bu_Exit)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "AccessForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AccessForm"
        Me.TopMost = True
        CType(Me.AxZKFPEngX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IOUsersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InOutTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InOutTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InOutTableBindingNavigator.ResumeLayout(False)
        Me.InOutTableBindingNavigator.PerformLayout()
        CType(Me.InOutTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersStampsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PB_Stamp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bu_Exit As Button
    Friend WithEvents AxZKFPEngX1 As AxZKFPEngXControl.AxZKFPEngX
    Friend WithEvents IOUsersDataSet As IOUsersDataSet
    Friend WithEvents InOutTableBindingSource As BindingSource
    Friend WithEvents InOutTableTableAdapter As IOUsersDataSetTableAdapters.InOutTableTableAdapter
    Friend WithEvents TableAdapterManager As IOUsersDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents UsersStampsTableAdapter As IOUsersDataSetTableAdapters.UsersStampsTableAdapter
    Friend WithEvents UsersStampsBindingSource As BindingSource
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusLabel3 As ToolStripStatusLabel
    Friend WithEvents StatusLabel1 As ToolStripStatusLabel
    Friend WithEvents StatusLabel2 As ToolStripStatusLabel
    Friend WithEvents PB_Stamp As PictureBox
End Class
