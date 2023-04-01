Public Class registo
    Dim utilizador, password As String
    Dim nome As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        utilizador = TextBox1.Text
        password = TextBox2.Text

        Dim disponivel As Boolean = True
        If Not (TextBox1.Text = "" Or TextBox2.Text = "") Then


            For Each linha As DataGridViewRow In sessao.UtilizadoresDataGridView.Rows
                If utilizador = sessao.UtilizadoresDataGridView.Rows(linha.Index).Cells(2).Value() Then
                    MsgBox("Já existe um utilizador com um username idêntico!", MsgBoxStyle.Critical, vbOKOnly)
                    disponivel = False
                    Exit Sub
                End If
            Next

            If disponivel = True Then
                MsgBox("Username disponível!", MsgBoxStyle.Information, vbOKOnly)

                Do
                    nome = InputBox("Qual o seu nome?", "Nome")
                Loop Until nome <> ""



                Label1.Visible = True
                Button1.Visible = True
            End If
        Else
            MsgBox("Campos em Branco!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            sessao.UtilizadoresBindingSource.MoveLast()
            sessao.UtilizadoresBindingSource.AddNew()

            sessao.UtilizadoresDataGridView.CurrentRow.Cells(2).Value() = utilizador
            sessao.UtilizadoresDataGridView.CurrentRow.Cells(3).Value() = password
            sessao.UtilizadoresDataGridView.CurrentRow.Cells(1).Value() = nome

            sessao.UtilizadoresBindingSource.EndEdit()
            sessao.UtilizadoresTableAdapter.Update(sessao.QuizzDataSet.Utilizadores)
            sessao.UtilizadoresTableAdapter.Fill(sessao.QuizzDataSet.Utilizadores)
            MsgBox("Utilizador Gravado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Gravado!")
        Catch ex As Exception
            MsgBox(ex.ToString + Chr(13) + "Operação não efetuada")
        End Try
    End Sub
End Class