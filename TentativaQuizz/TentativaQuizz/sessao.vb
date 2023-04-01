Public Class sessao
    Public pos As Integer
    Private Sub UtilizadoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UtilizadoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.QuizzDataSet)

    End Sub

    Private Sub sessao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuizzDataSet.Utilizadores' table. You can move, or remove it, as needed.
        Me.UtilizadoresTableAdapter.Fill(Me.QuizzDataSet.Utilizadores)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        registo.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim utilizador, password As String
        utilizador = TextBox1.Text
        password = TextBox2.Text
        For Each linha As DataGridViewRow In UtilizadoresDataGridView.Rows
            If utilizador = UtilizadoresDataGridView.Rows(linha.Index).Cells(2).Value() And password = UtilizadoresDataGridView.Rows(linha.Index).Cells(3).Value() Then
                MsgBox("Bem vindo: " & UtilizadoresDataGridView.Rows(linha.Index).Cells(1).Value, MsgBoxStyle.Exclamation)

                pos = UtilizadoresBindingSource.Position
                Form1.ShowDialog()
                Me.Close()
                Exit Sub
            End If
        Next
        MsgBox("Utilizador não encontrado!", MsgBoxStyle.Critical)
   
    End Sub
End Class