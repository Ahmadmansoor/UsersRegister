<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccessForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccessForm))
        Me.Bu_Exit = New System.Windows.Forms.Button()
        Me.AxZKFPEngX1 = New AxZKFPEngXControl.AxZKFPEngX()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PB_Stamp = New System.Windows.Forms.PictureBox()
        Me.InOutTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InOutTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IOUsersDataSet = New UsersRegister.IOUsersDataSet()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UsersStampsTableAdapter = New UsersRegister.IOUsersDataSetTableAdapters.UsersStampsTableAdapter()
        Me.UsersStampsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InOutTableTableAdapter = New UsersRegister.IOUsersDataSetTableAdapters.InOutTableTableAdapter()
        Me.TableAdapterManager = New UsersRegister.IOUsersDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Bu_export = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.AxZKFPEngX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PB_Stamp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InOutTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InOutTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IOUsersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersStampsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bu_Exit
        '
        Me.Bu_Exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bu_Exit.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bu_Exit.Location = New System.Drawing.Point(624, 16)
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
        Me.AxZKFPEngX1.Location = New System.Drawing.Point(871, 148)
        Me.AxZKFPEngX1.Name = "AxZKFPEngX1"
        Me.AxZKFPEngX1.OcxState = CType(resources.GetObject("AxZKFPEngX1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxZKFPEngX1.Size = New System.Drawing.Size(24, 24)
        Me.AxZKFPEngX1.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel3, Me.StatusLabel1, Me.StatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 723)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1250, 26)
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
        Me.PB_Stamp.BackgroundImage = Global.UsersRegister.My.Resources.Resources.error_
        Me.PB_Stamp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PB_Stamp.Location = New System.Drawing.Point(536, 16)
        Me.PB_Stamp.Name = "PB_Stamp"
        Me.PB_Stamp.Size = New System.Drawing.Size(81, 66)
        Me.PB_Stamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Stamp.TabIndex = 35
        Me.PB_Stamp.TabStop = False
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
        Me.InOutTableDataGridView.Location = New System.Drawing.Point(8, 10)
        Me.InOutTableDataGridView.Name = "InOutTableDataGridView"
        Me.InOutTableDataGridView.Size = New System.Drawing.Size(1236, 609)
        Me.InOutTableDataGridView.TabIndex = 35
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
        'InOutTableBindingSource
        '
        Me.InOutTableBindingSource.DataMember = "InOutTable"
        Me.InOutTableBindingSource.DataSource = Me.IOUsersDataSet
        '
        'IOUsersDataSet
        '
        Me.IOUsersDataSet.DataSetName = "IOUsersDataSet"
        Me.IOUsersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'UsersStampsTableAdapter
        '
        Me.UsersStampsTableAdapter.ClearBeforeFill = True
        '
        'UsersStampsBindingSource
        '
        Me.UsersStampsBindingSource.DataMember = "UsersStamps"
        Me.UsersStampsBindingSource.DataSource = Me.IOUsersDataSet
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Bu_export)
        Me.GroupBox1.Controls.Add(Me.Bu_Exit)
        Me.GroupBox1.Controls.Add(Me.PB_Stamp)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(8, 625)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1236, 91)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        '
        'Bu_export
        '
        Me.Bu_export.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bu_export.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bu_export.Location = New System.Drawing.Point(403, 16)
        Me.Bu_export.Margin = New System.Windows.Forms.Padding(4)
        Me.Bu_export.Name = "Bu_export"
        Me.Bu_export.Size = New System.Drawing.Size(126, 68)
        Me.Bu_export.TabIndex = 36
        Me.Bu_export.Text = "Export to Excel"
        Me.Bu_export.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(362, 727)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(76, 22)
        Me.CheckBox1.TabIndex = 37
        Me.CheckBox1.Text = "Enable"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'AccessForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1250, 749)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.InOutTableDataGridView)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.AxZKFPEngX1)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "AccessForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AccessForm"
        CType(Me.AxZKFPEngX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PB_Stamp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InOutTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InOutTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IOUsersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersStampsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bu_Exit As Button
    Friend WithEvents AxZKFPEngX1 As AxZKFPEngXControl.AxZKFPEngX
    Friend WithEvents IOUsersDataSet As IOUsersDataSet
    Friend WithEvents UsersStampsTableAdapter As IOUsersDataSetTableAdapters.UsersStampsTableAdapter
    Friend WithEvents UsersStampsBindingSource As BindingSource
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusLabel3 As ToolStripStatusLabel
    Friend WithEvents StatusLabel1 As ToolStripStatusLabel
    Friend WithEvents StatusLabel2 As ToolStripStatusLabel
    Friend WithEvents PB_Stamp As PictureBox
    Friend WithEvents InOutTableBindingSource As BindingSource
    Friend WithEvents InOutTableTableAdapter As IOUsersDataSetTableAdapters.InOutTableTableAdapter
    Friend WithEvents TableAdapterManager As IOUsersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InOutTableDataGridView As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Bu_export As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
