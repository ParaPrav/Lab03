<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
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
        Me.CarInventoryTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmbMakes = New System.Windows.Forms.ComboBox()
        Me.cmbYears = New System.Windows.Forms.ComboBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.lvwCars = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMakePrompt = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.Price = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbMakes
        '
        Me.cmbMakes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMakes.FormattingEnabled = True
        Me.cmbMakes.Items.AddRange(New Object() {"Acura", "Audi", "BMW", "Cadillac", "Chevrolet", "Chrysler", "Dodge", "Ford", "GMC", "Honda", "Hyundai", "Infiniti", "Lexus", "Lincoln", "Mercedes-Benz", "Nissan", "Subaru", "Toyota", "Volkswagen", "Volvo"})
        Me.cmbMakes.Location = New System.Drawing.Point(99, 10)
        Me.cmbMakes.Name = "cmbMakes"
        Me.cmbMakes.Size = New System.Drawing.Size(121, 24)
        Me.cmbMakes.TabIndex = 1
        Me.CarInventoryTips.SetToolTip(Me.cmbMakes, "Select the Car Brand.")
        '
        'cmbYears
        '
        Me.cmbYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYears.FormattingEnabled = True
        Me.cmbYears.Items.AddRange(New Object() {"2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990"})
        Me.cmbYears.Location = New System.Drawing.Point(99, 76)
        Me.cmbYears.Name = "cmbYears"
        Me.cmbYears.Size = New System.Drawing.Size(121, 24)
        Me.cmbYears.TabIndex = 5
        Me.CarInventoryTips.SetToolTip(Me.cmbYears, "Select the Car Year.")
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(99, 43)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(119, 22)
        Me.txtModel.TabIndex = 3
        Me.CarInventoryTips.SetToolTip(Me.txtModel, "Enter Model")
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(99, 109)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(119, 22)
        Me.txtPrice.TabIndex = 7
        Me.CarInventoryTips.SetToolTip(Me.txtPrice, "Enter Model")
        '
        'chkNew
        '
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Location = New System.Drawing.Point(35, 142)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(81, 24)
        Me.chkNew.TabIndex = 8
        Me.chkNew.Text = "&New:"
        Me.chkNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CarInventoryTips.SetToolTip(Me.chkNew, "Check if the Car is New.")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'lvwCars
        '
        Me.lvwCars.BackColor = System.Drawing.SystemColors.Window
        Me.lvwCars.CheckBoxes = True
        Me.lvwCars.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwCars.FullRowSelect = True
        Me.lvwCars.Location = New System.Drawing.Point(12, 172)
        Me.lvwCars.MultiSelect = False
        Me.lvwCars.Name = "lvwCars"
        Me.lvwCars.Size = New System.Drawing.Size(492, 253)
        Me.lvwCars.TabIndex = 9
        Me.lvwCars.TileSize = New System.Drawing.Size(10, 10)
        Me.CarInventoryTips.SetToolTip(Me.lvwCars, "Select a car to modify.")
        Me.lvwCars.UseCompatibleStateImageBehavior = False
        Me.lvwCars.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        '
        'colID
        '
        Me.colID.Text = "ID"
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(209, 524)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(94, 31)
        Me.btnEnter.TabIndex = 11
        Me.btnEnter.Text = "&Enter"
        Me.CarInventoryTips.SetToolTip(Me.btnEnter, "Enter the Car Details")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(309, 524)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(94, 31)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "&Reset"
        Me.CarInventoryTips.SetToolTip(Me.btnReset, "Restart the Program")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(409, 524)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 31)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.CarInventoryTips.SetToolTip(Me.btnExit, "Exit the Program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMakePrompt
        '
        Me.lblMakePrompt.Location = New System.Drawing.Point(12, 10)
        Me.lblMakePrompt.Name = "lblMakePrompt"
        Me.lblMakePrompt.Size = New System.Drawing.Size(83, 23)
        Me.lblMakePrompt.TabIndex = 0
        Me.lblMakePrompt.Text = "Ma&ke:"
        Me.lblMakePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(12, 43)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(83, 23)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "&Model:"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(12, 76)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(83, 23)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "&Year:"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Price
        '
        Me.Price.Location = New System.Drawing.Point(12, 109)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(83, 23)
        Me.Price.TabIndex = 6
        Me.Price.Text = "&Price($):"
        Me.Price.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(13, 428)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(490, 83)
        Me.lblResult.TabIndex = 10
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(515, 567)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lvwCars)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.cmbYears)
        Me.Controls.Add(Me.cmbMakes)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMakePrompt)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarInventory"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CarInventoryTips As ToolTip
    Friend WithEvents lblMakePrompt As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents Price As Label
    Friend WithEvents cmbMakes As ComboBox
    Friend WithEvents cmbYears As ComboBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents lvwCars As ListView
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
End Class
