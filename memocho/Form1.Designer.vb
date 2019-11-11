<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

	'Windows フォーム デザイナーで必要です。
	Private components As System.ComponentModel.IContainer

	'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
	'Windows フォーム デザイナーを使用して変更できます。  
	'コード エディターを使って変更しないでください。
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.ファイルToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.新規作成ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.開くToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.保存ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.名前を付けて保存ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.終了ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.編集ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.コピーToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ペーストToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.切り取りToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.削除ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.すべて選択ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.削除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ヘルプToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.つくったひとToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.つかいかたToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルToolStripMenuItem, Me.編集ToolStripMenuItem, Me.ヘルプToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
		Me.MenuStrip1.TabIndex = 2
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'ファイルToolStripMenuItem
		'
		Me.ファイルToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新規作成ToolStripMenuItem, Me.開くToolStripMenuItem, Me.保存ToolStripMenuItem, Me.名前を付けて保存ToolStripMenuItem, Me.ToolStripSeparator1, Me.終了ToolStripMenuItem})
		Me.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem"
		Me.ファイルToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
		Me.ファイルToolStripMenuItem.Text = "ファイル(&F)"
		'
		'新規作成ToolStripMenuItem
		'
		Me.新規作成ToolStripMenuItem.Name = "新規作成ToolStripMenuItem"
		Me.新規作成ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
		Me.新規作成ToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
		Me.新規作成ToolStripMenuItem.Text = "新規作成(&N)"
		'
		'開くToolStripMenuItem
		'
		Me.開くToolStripMenuItem.Name = "開くToolStripMenuItem"
		Me.開くToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
		Me.開くToolStripMenuItem.Text = "開く(&O)"
		'
		'保存ToolStripMenuItem
		'
		Me.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem"
		Me.保存ToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
		Me.保存ToolStripMenuItem.Text = "保存(&S)"
		'
		'名前を付けて保存ToolStripMenuItem
		'
		Me.名前を付けて保存ToolStripMenuItem.Name = "名前を付けて保存ToolStripMenuItem"
		Me.名前を付けて保存ToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
		Me.名前を付けて保存ToolStripMenuItem.Text = "名前を付けて保存(&A)"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(215, 6)
		'
		'終了ToolStripMenuItem
		'
		Me.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem"
		Me.終了ToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
		Me.終了ToolStripMenuItem.Text = "終了"
		'
		'編集ToolStripMenuItem
		'
		Me.編集ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.コピーToolStripMenuItem, Me.ペーストToolStripMenuItem, Me.切り取りToolStripMenuItem, Me.削除ToolStripMenuItem1, Me.すべて選択ToolStripMenuItem, Me.削除ToolStripMenuItem})
		Me.編集ToolStripMenuItem.Name = "編集ToolStripMenuItem"
		Me.編集ToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
		Me.編集ToolStripMenuItem.Text = "編集"
		'
		'コピーToolStripMenuItem
		'
		Me.コピーToolStripMenuItem.Name = "コピーToolStripMenuItem"
		Me.コピーToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
		Me.コピーToolStripMenuItem.Text = "コピー(&C)"
		'
		'ペーストToolStripMenuItem
		'
		Me.ペーストToolStripMenuItem.Name = "ペーストToolStripMenuItem"
		Me.ペーストToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
		Me.ペーストToolStripMenuItem.Text = "貼り付け(&V)"
		'
		'切り取りToolStripMenuItem
		'
		Me.切り取りToolStripMenuItem.Name = "切り取りToolStripMenuItem"
		Me.切り取りToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
		Me.切り取りToolStripMenuItem.Text = "切り取り(&T)"
		'
		'削除ToolStripMenuItem1
		'
		Me.削除ToolStripMenuItem1.Name = "削除ToolStripMenuItem1"
		Me.削除ToolStripMenuItem1.Size = New System.Drawing.Size(216, 26)
		Me.削除ToolStripMenuItem1.Text = "削除"
		'
		'すべて選択ToolStripMenuItem
		'
		Me.すべて選択ToolStripMenuItem.Name = "すべて選択ToolStripMenuItem"
		Me.すべて選択ToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
		Me.すべて選択ToolStripMenuItem.Text = "すべて選択(&A)"
		'
		'削除ToolStripMenuItem
		'
		Me.削除ToolStripMenuItem.Name = "削除ToolStripMenuItem"
		Me.削除ToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
		Me.削除ToolStripMenuItem.Text = "すべて削除(&L)"
		'
		'ヘルプToolStripMenuItem
		'
		Me.ヘルプToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.つくったひとToolStripMenuItem, Me.つかいかたToolStripMenuItem})
		Me.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem"
		Me.ヘルプToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
		Me.ヘルプToolStripMenuItem.Text = "ヘルプ"
		'
		'つくったひとToolStripMenuItem
		'
		Me.つくったひとToolStripMenuItem.Name = "つくったひとToolStripMenuItem"
		Me.つくったひとToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
		Me.つくったひとToolStripMenuItem.Text = "つくったひと"
		'
		'つかいかたToolStripMenuItem
		'
		Me.つかいかたToolStripMenuItem.Name = "つかいかたToolStripMenuItem"
		Me.つかいかたToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
		Me.つかいかたToolStripMenuItem.Text = "つかいかた"
		'
		'TextBox1
		'
		Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TextBox1.Location = New System.Drawing.Point(0, 28)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(0)
		Me.TextBox1.Multiline = True
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
		Me.TextBox1.Size = New System.Drawing.Size(800, 422)
		Me.TextBox1.TabIndex = 3
		'
		'SaveFileDialog1
		'
		Me.SaveFileDialog1.Filter = """テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*"""
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "Form1"
		Me.Text = "メモ帳"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents ファイルToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents 新規作成ToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents 開くToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents 保存ToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents 名前を付けて保存ToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents 編集ToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents コピーToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents 切り取りToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ペーストToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents すべて選択ToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents 削除ToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ヘルプToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents つくったひとToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents つかいかたToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
	Friend WithEvents 終了ToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents SaveFileDialog1 As SaveFileDialog
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents 削除ToolStripMenuItem1 As ToolStripMenuItem
End Class
