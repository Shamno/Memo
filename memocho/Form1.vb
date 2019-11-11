Imports System.IO

Public Class Form1
	Private filepath As String

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	End Sub

	Private Sub 新規作成ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新規作成ToolStripMenuItem.Click
		TextBox1.Clear()
		'全部消す
	End Sub

	Private Sub 開くToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 開くToolStripMenuItem.Click
		OpenFileDialog1.ShowDialog()
	End Sub

	Private Sub 保存ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存ToolStripMenuItem.Click
		If filepath = Nothing Then
			SaveFileDialog1.ShowDialog()
			Call save()
		Else
			Call save()
		End If
	End Sub

	Private Sub 名前を付けて保存ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 名前を付けて保存ToolStripMenuItem.Click
		SaveFileDialog1.ShowDialog()
	End Sub


	Private Sub コピーToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles コピーToolStripMenuItem.Click
		If TextBox1.SelectionLength > 0 Then    '選択されている文字列があるときはコピーする
			TextBox1.Copy()
		End If
	End Sub

	Private Sub ペーストToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ペーストToolStripMenuItem.Click
		Dim data As IDataObject = Clipboard.GetDataObject()
		If (Not data Is Nothing) AndAlso (data.GetDataPresent(DataFormats.Text) = True) Then    'クリップボードにテキストデータがあるときは貼り付ける
			TextBox1.Paste()
		End If
	End Sub

	Private Sub 切り取りToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 切り取りToolStripMenuItem.Click
		If TextBox1.SelectionLength > 0 Then    '選択されている文字列があるときはカットする
			TextBox1.Cut()
		End If
	End Sub

	Private Sub すべて選択ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles すべて選択ToolStripMenuItem.Click
		TextBox1.SelectAll()    'すべて選択する
	End Sub

	Private Sub 削除ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 削除ToolStripMenuItem.Click
		TextBox1.Clear()    'すべて消す
	End Sub

	Private Sub 終了ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了ToolStripMenuItem.Click

		Dim result As DialogResult = MessageBox.Show("テキストにメモが残ってます。閉じますか？", "注意",
											 MessageBoxButtons.YesNo,
											 MessageBoxIcon.Exclamation,
											 MessageBoxDefaultButton.Button2)
		If result = DialogResult.Yes Then
			Application.Exit()
		ElseIf result = DialogResult.No Then
			'何もしない
		End If

	End Sub

	Private Sub 削除ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 削除ToolStripMenuItem1.Click
		If 0 < TextBox1.SelectionLength Then
			TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.SelectionStart) & TextBox1.Text.Substring(TextBox1.SelectionStart + TextBox1.SelectionLength)
		End If
	End Sub

	Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
		filepath = SaveFileDialog1.FileName
		Call save()
	End Sub
	Private Sub save()
		Dim sw As New System.IO.StreamWriter(filepath, False, System.Text.Encoding.GetEncoding(“shift_jis”))
		sw.Write(TextBox1.Text)
		sw.Close()
	End Sub

	Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
		filepath = OpenFileDialog1.FileName
		Dim sr As New System.IO.StreamReader(filepath, System.Text.Encoding.GetEncoding(“shift_jis”)) '文字コード指定
		TextBox1.Text = sr.ReadToEnd()
		sr.Close()
	End Sub

	Private Sub つくったひとToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles つくったひとToolStripMenuItem.Click
		'メッセージボックスを表示する
		MessageBox.Show("制作者：篠沢唯菜" & vbCrLf & "制作日:2019年5月" & vbCrLf & "使用言語:VB", "つくったひと", MessageBoxButtons.OK)
	End Sub
End Class
