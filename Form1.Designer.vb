Public Class Form1
    Inherits Form
    Private btnClickMe As Button

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.btnClickMe = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        ' btnClickMe
        '
        Me.btnClickMe.Location = New System.Drawing.Point(100, 50)
        Me.btnClickMe.Size = New System.Drawing.Size(100, 30)
        Me.btnClickMe.Text = "Click Me"
        AddHandler Me.btnClickMe.Click, AddressOf Me.BtnClickMe_Click
        '
        ' 
        '
        Me.ClientSize = New System.Drawing.Size(300, 150)
        Me.Controls.Add(Me.btnClickMe)
        Me.Text = "Simple Button App"
        Me.ResumeLayout(False)
    End Sub

    Private Sub BtnClickMe_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Hello, you are welcome to fernhad at github!")
    End Sub
End Class

