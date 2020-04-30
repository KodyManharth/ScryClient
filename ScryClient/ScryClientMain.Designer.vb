<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScryClientMain
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
        Me.SetList = New System.Windows.Forms.ListView()
        Me.Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SetName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cards = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CardList = New System.Windows.Forms.ListView()
        Me.CardName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Rarity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.setsLabel = New System.Windows.Forms.Label()
        Me.setLoadButton = New System.Windows.Forms.Button()
        Me.cardLoadButton = New System.Windows.Forms.Button()
        Me.cardsLabel = New System.Windows.Forms.Label()
        Me.setListCount = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SetList
        '
        Me.SetList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Code, Me.SetName, Me.Cards})
        Me.SetList.HideSelection = False
        Me.SetList.Location = New System.Drawing.Point(12, 38)
        Me.SetList.Name = "SetList"
        Me.SetList.Size = New System.Drawing.Size(323, 400)
        Me.SetList.TabIndex = 0
        Me.SetList.UseCompatibleStateImageBehavior = False
        Me.SetList.View = System.Windows.Forms.View.Details
        '
        'Code
        '
        Me.Code.Text = "Code"
        Me.Code.Width = 39
        '
        'SetName
        '
        Me.SetName.Text = "Name"
        Me.SetName.Width = 110
        '
        'Cards
        '
        Me.Cards.Text = "Cards"
        '
        'CardList
        '
        Me.CardList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CardName, Me.Rarity, Me.Price, Me.Number})
        Me.CardList.HideSelection = False
        Me.CardList.Location = New System.Drawing.Point(341, 38)
        Me.CardList.Name = "CardList"
        Me.CardList.Size = New System.Drawing.Size(305, 400)
        Me.CardList.TabIndex = 1
        Me.CardList.UseCompatibleStateImageBehavior = False
        Me.CardList.View = System.Windows.Forms.View.Details
        '
        'CardName
        '
        Me.CardName.Text = "Name"
        Me.CardName.Width = 116
        '
        'Rarity
        '
        Me.Rarity.Text = "Rarity"
        Me.Rarity.Width = 48
        '
        'Price
        '
        Me.Price.Text = "Price"
        Me.Price.Width = 49
        '
        'Number
        '
        Me.Number.Text = "Number"
        '
        'setsLabel
        '
        Me.setsLabel.AutoSize = True
        Me.setsLabel.Location = New System.Drawing.Point(13, 19)
        Me.setsLabel.Name = "setsLabel"
        Me.setsLabel.Size = New System.Drawing.Size(28, 13)
        Me.setsLabel.TabIndex = 2
        Me.setsLabel.Text = "Sets"
        '
        'setLoadButton
        '
        Me.setLoadButton.Location = New System.Drawing.Point(129, 14)
        Me.setLoadButton.Name = "setLoadButton"
        Me.setLoadButton.Size = New System.Drawing.Size(78, 23)
        Me.setLoadButton.TabIndex = 3
        Me.setLoadButton.Text = "Load Sets"
        Me.setLoadButton.UseVisualStyleBackColor = True
        '
        'cardLoadButton
        '
        Me.cardLoadButton.Location = New System.Drawing.Point(568, 14)
        Me.cardLoadButton.Name = "cardLoadButton"
        Me.cardLoadButton.Size = New System.Drawing.Size(78, 23)
        Me.cardLoadButton.TabIndex = 4
        Me.cardLoadButton.Text = "Load Cards"
        Me.cardLoadButton.UseVisualStyleBackColor = True
        '
        'cardsLabel
        '
        Me.cardsLabel.AutoSize = True
        Me.cardsLabel.Location = New System.Drawing.Point(380, 19)
        Me.cardsLabel.Name = "cardsLabel"
        Me.cardsLabel.Size = New System.Drawing.Size(66, 13)
        Me.cardsLabel.TabIndex = 5
        Me.cardsLabel.Text = "Cards: None"
        '
        'setListCount
        '
        Me.setListCount.AutoSize = True
        Me.setListCount.Location = New System.Drawing.Point(47, 19)
        Me.setListCount.Name = "setListCount"
        Me.setListCount.Size = New System.Drawing.Size(10, 13)
        Me.setListCount.TabIndex = 6
        Me.setListCount.Text = "-"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(781, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 306)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'ScryClientMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.setListCount)
        Me.Controls.Add(Me.cardsLabel)
        Me.Controls.Add(Me.cardLoadButton)
        Me.Controls.Add(Me.setLoadButton)
        Me.Controls.Add(Me.setsLabel)
        Me.Controls.Add(Me.CardList)
        Me.Controls.Add(Me.SetList)
        Me.Name = "ScryClientMain"
        Me.Text = "ScryClient"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SetList As ListView
    Friend WithEvents CardList As ListView
    Friend WithEvents setsLabel As Label
    Friend WithEvents setLoadButton As Button
    Friend WithEvents cardLoadButton As Button
    Friend WithEvents cardsLabel As Label
    Friend WithEvents setListCount As Label
    Friend WithEvents Code As ColumnHeader
    Friend WithEvents SetName As ColumnHeader
    Friend WithEvents Cards As ColumnHeader
    Friend WithEvents CardName As ColumnHeader
    Friend WithEvents Rarity As ColumnHeader
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents Number As ColumnHeader
    Friend WithEvents PictureBox1 As PictureBox
End Class
