<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contacts
    Inherits DevComponents.DotNetBar.Metro.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contacts))
        Me.ContactsDataSet = New Chimex_OS.ContactsDataSet()
        Me.DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTableAdapter = New Chimex_OS.ContactsDataSetTableAdapters.DataTableAdapter()
        Me.TableAdapterManager = New Chimex_OS.ContactsDataSetTableAdapters.TableAdapterManager()
        Me.DataBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.DataBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DataDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxX3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxX4 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxX5 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.ContactsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataBindingNavigator.SuspendLayout()
        CType(Me.DataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContactsDataSet
        '
        Me.ContactsDataSet.DataSetName = "ContactsDataSet"
        Me.ContactsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataBindingSource
        '
        Me.DataBindingSource.DataMember = "Data"
        Me.DataBindingSource.DataSource = Me.ContactsDataSet
        '
        'DataTableAdapter
        '
        Me.DataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DataTableAdapter = Me.DataTableAdapter
        Me.TableAdapterManager.UpdateOrder = Chimex_OS.ContactsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataBindingNavigator
        '
        Me.DataBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DataBindingNavigator.BindingSource = Me.DataBindingSource
        Me.DataBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DataBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DataBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DataBindingNavigatorSaveItem})
        Me.DataBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DataBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DataBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DataBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DataBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DataBindingNavigator.Name = "DataBindingNavigator"
        Me.DataBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DataBindingNavigator.Size = New System.Drawing.Size(544, 25)
        Me.DataBindingNavigator.TabIndex = 0
        Me.DataBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'DataBindingNavigatorSaveItem
        '
        Me.DataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DataBindingNavigatorSaveItem.Image = CType(resources.GetObject("DataBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DataBindingNavigatorSaveItem.Name = "DataBindingNavigatorSaveItem"
        Me.DataBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.DataBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DataDataGridView
        '
        Me.DataDataGridView.AutoGenerateColumns = False
        Me.DataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.DataDataGridView.DataSource = Me.DataBindingSource
        Me.DataDataGridView.Location = New System.Drawing.Point(0, 37)
        Me.DataDataGridView.Name = "DataDataGridView"
        Me.DataDataGridView.Size = New System.Drawing.Size(543, 220)
        Me.DataDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NAME"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NAME"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ADDRESS"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ADDRESS"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "GENDER"
        Me.DataGridViewTextBoxColumn3.HeaderText = "GENDER"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PHONE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PHONE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "EMAIL"
        Me.DataGridViewTextBoxColumn5.HeaderText = "EMAIL"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(12, 263)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(135, 35)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.ButtonX1.TabIndex = 2
        Me.ButtonX1.Text = "Add"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(211, 263)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(135, 35)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.ButtonX2.TabIndex = 3
        Me.ButtonX2.Text = "Delete"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(397, 263)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(135, 35)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.ButtonX3.TabIndex = 4
        Me.ButtonX3.Text = "Save"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name"
        '
        'TextBoxX1
        '
        Me.TextBoxX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataBindingSource, "NAME", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxX1.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX1.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX1.Location = New System.Drawing.Point(12, 331)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.PreventEnterBeep = True
        Me.TextBoxX1.Size = New System.Drawing.Size(182, 22)
        Me.TextBoxX1.TabIndex = 6
        '
        'TextBoxX2
        '
        Me.TextBoxX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX2.Border.Class = "TextBoxBorder"
        Me.TextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataBindingSource, "ADDRESS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxX2.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX2.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX2.Location = New System.Drawing.Point(15, 390)
        Me.TextBoxX2.Name = "TextBoxX2"
        Me.TextBoxX2.PreventEnterBeep = True
        Me.TextBoxX2.Size = New System.Drawing.Size(182, 22)
        Me.TextBoxX2.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 370)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Address"
        '
        'TextBoxX3
        '
        Me.TextBoxX3.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX3.Border.Class = "TextBoxBorder"
        Me.TextBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataBindingSource, "PHONE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxX3.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX3.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX3.Location = New System.Drawing.Point(214, 390)
        Me.TextBoxX3.Name = "TextBoxX3"
        Me.TextBoxX3.PreventEnterBeep = True
        Me.TextBoxX3.Size = New System.Drawing.Size(177, 22)
        Me.TextBoxX3.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(211, 370)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Phone"
        '
        'TextBoxX4
        '
        Me.TextBoxX4.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX4.Border.Class = "TextBoxBorder"
        Me.TextBoxX4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataBindingSource, "GENDER", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxX4.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX4.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX4.Location = New System.Drawing.Point(211, 331)
        Me.TextBoxX4.Name = "TextBoxX4"
        Me.TextBoxX4.PreventEnterBeep = True
        Me.TextBoxX4.Size = New System.Drawing.Size(182, 22)
        Me.TextBoxX4.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(208, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Gender"
        '
        'TextBoxX5
        '
        Me.TextBoxX5.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxX5.Border.Class = "TextBoxBorder"
        Me.TextBoxX5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataBindingSource, "EMAIL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxX5.DisabledBackColor = System.Drawing.Color.White
        Me.TextBoxX5.ForeColor = System.Drawing.Color.Black
        Me.TextBoxX5.Location = New System.Drawing.Point(397, 390)
        Me.TextBoxX5.Name = "TextBoxX5"
        Me.TextBoxX5.PreventEnterBeep = True
        Me.TextBoxX5.Size = New System.Drawing.Size(132, 22)
        Me.TextBoxX5.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(394, 370)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Email"
        '
        'Contacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 436)
        Me.Controls.Add(Me.TextBoxX5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxX3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxX4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxX2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxX1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonX3)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.DataDataGridView)
        Me.Controls.Add(Me.DataBindingNavigator)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Contacts"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contacts"
        CType(Me.ContactsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataBindingNavigator.ResumeLayout(False)
        Me.DataBindingNavigator.PerformLayout()
        CType(Me.DataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContactsDataSet As Chimex_OS.ContactsDataSet
    Friend WithEvents DataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTableAdapter As Chimex_OS.ContactsDataSetTableAdapters.DataTableAdapter
    Friend WithEvents TableAdapterManager As Chimex_OS.ContactsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxX3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxX4 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxX5 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
