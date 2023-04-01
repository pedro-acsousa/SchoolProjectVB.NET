Imports System

Public Class Form1
    Dim i As Integer = 40
    Dim a, countrnd As New Random
    Dim x, count, value As Integer
    Dim resposta As String
    Dim pontuacao As Integer
    Dim perguntaapresentada As Integer
    Dim numerodaperg As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i = 40
        Comecar.AxWindowsMediaPlayer1.Ctlcontrols.pause()
        'TODO: This line of code loads data into the 'QuizzDataSet.Lvl1' table. You can move, or remove it, as needed.
        Me.Lvl1TableAdapter.Fill(Me.QuizzDataSet.Lvl1)
        Label3.Text = ""


        'nota- as perguntas não são random mas não há repetidas, esclarecer com o professor

        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        Randomize()

        count = Lvl1DataGridView.RowCount - 1

        value = countrnd.Next(0, count)
        Lvl1BindingSource.Position = value
        If Lvl1DataGridView.CurrentRow.Cells(6).Value = "available" Then
            Lvl1BindingSource.Position = value

            ' Lvl1BindingSource.Find("disponivel", "available")
        Else
            Do
                value = countrnd.Next(0, count)
                Lvl1BindingSource.Position = value
            Loop Until Lvl1DataGridView.CurrentRow.Cells(6).Value = "available"
            Lvl1BindingSource.Position = value

            ' Lvl1BindingSource.Find("disponivel", "available")

        End If


        Lvl1DataGridView.CurrentRow.Cells(6).Value = "unavailable"
        TextBox1.Text = Lvl1DataGridView.CurrentRow.Cells(1).Value
        Dim pos = Lvl1BindingSource.Position
        Lvl1BindingSource.EndEdit()
        Lvl1TableAdapter.Update(QuizzDataSet.Lvl1)
        Lvl1TableAdapter.Fill(QuizzDataSet.Lvl1)

        ' TextBox1.Text = Lvl1DataGridView.CurrentRow.Cells(1).Value
        Lvl1BindingSource.Position = pos
        x = a.Next(1, 24)
        If x = 1 Then
            Call Module1.caso1()
        ElseIf x = 2 Then
            Call Module1.caso2()
        ElseIf x = 3 Then
            Call Module1.caso3()
        ElseIf x = 4 Then
            Call Module1.caso4()
        ElseIf x = 5 Then
            Call Module1.caso5()
        ElseIf x = 6 Then
            Call Module1.caso6()
        ElseIf x = 7 Then
            Call Module1.caso7()
        ElseIf x = 8 Then
            Call Module1.caso8()
        ElseIf x = 9 Then
            Call Module1.caso9()
        ElseIf x = 10 Then
            Call Module1.caso10()
        ElseIf x = 11 Then
            Call Module1.caso11()
        ElseIf x = 12 Then
            Call Module1.caso12()
        ElseIf x = 13 Then
            Call Module1.caso13()
        ElseIf x = 14 Then
            Call Module1.caso14()
        ElseIf x = 15 Then
            Call Module1.caso15()
        ElseIf x = 16 Then
            Call Module1.caso16()
        ElseIf x = 17 Then
            Call Module1.caso17()
        ElseIf x = 18 Then
            Call Module1.caso18()
        ElseIf x = 19 Then
            Call Module1.caso19()
        ElseIf x = 20 Then
            Call Module1.caso20()
        ElseIf x = 21 Then
            Call Module1.caso21()
        ElseIf x = 22 Then
            Call Module1.caso22()
        ElseIf x = 23 Then
            Call Module1.caso23()
        ElseIf x = 24 Then
            Call Module1.caso24()
        Else
            MsgBox("Erro!")


        End If

        RadioButton1.Text = Lvl1DataGridView.CurrentRow.Cells(n).Value
        RadioButton2.Text = Lvl1DataGridView.CurrentRow.Cells(n1).Value
        RadioButton3.Text = Lvl1DataGridView.CurrentRow.Cells(n2).Value
        RadioButton4.Text = Lvl1DataGridView.CurrentRow.Cells(n3).Value


        Timer1.Interval = 1000
        My.Computer.Audio.Play("C:\PAP Pedro Sousa\soundsquizz\CLOCKmodded.wav", AudioPlayMode.Background)
        Timer1.Start()
        numerodaperg = 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        i = i - 1
        Label3.Text = "Tempo: " & i & " segundos"
        If i = 30 Then

            ' My.Computer.Audio.Play("C:\PAP Pedro Sousa\soundsquizz\30.wav", AudioPlayMode.Background)
            'My.Computer.Audio.Play("C:\PAP Pedro Sousa\soundsquizz\SecondsRemaining.wav", AudioPlayMode.Background)

        End If
        If i = 0 Then
            Timer1.Stop()
            Button2.Enabled = False
            MsgBox("Acabou o tempo!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Acabou")
            Lvl1BindingSource.EndEdit()
            Lvl1TableAdapter.Update(QuizzDataSet.Lvl1)
            Lvl1TableAdapter.Fill(QuizzDataSet.Lvl1)

            If Not (RadioButton1.Checked Or RadioButton2.Checked Or RadioButton3.Checked Or RadioButton4.Checked) Then

                Button2.Enabled = False
                MsgBox("Não respondeu", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                Lvl1BindingSource.EndEdit()
                Lvl1TableAdapter.Update(QuizzDataSet.Lvl1)
                Lvl1TableAdapter.Fill(QuizzDataSet.Lvl1)
                Exit Sub
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button2.Enabled = True
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        Randomize()
        i = 40

        count = Lvl1DataGridView.RowCount - 1
        value = countrnd.Next(0, count)
        Lvl1BindingSource.Position = value


        If Lvl1DataGridView.CurrentRow.Cells(6).Value = "available" Then
            Lvl1BindingSource.Position = value

            ' Lvl1BindingSource.Find("disponivel", "available")
        Else
            Do
                value = countrnd.Next(0, count)
                Lvl1BindingSource.Position = value
            Loop Until Lvl1DataGridView.CurrentRow.Cells(6).Value = "available"
            Lvl1BindingSource.Position = value

            ' Lvl1BindingSource.Find("disponivel", "available")

        End If





        '  Lvl1BindingSource.Position = Lvl1BindingSource.Find("disponivel", "available")
        Lvl1DataGridView.CurrentRow.Cells(6).Value = "unavailable"
        numerodaperg = numerodaperg + 1
        If numerodaperg = 10 Then
            MsgBox("Acabou as perguntas", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Fim")
            Button1.Enabled = False
            Button2.Enabled = False
            MsgBox("Pode prosseguir para o próximo nível se acumulou pontos suficientes (60)", MsgBoxStyle.Information)
            If pontuacao >= 60 Then
                If MsgBox("Conseguiu pontos suficientes, deseja seguir para o nível 2?", MsgBoxStyle.Question, vbYesNo) = vbYes Then
                    'chamar o lvl 2 aqui
                End If
            End If
            Exit Sub
        End If
        TextBox1.Text = Lvl1DataGridView.CurrentRow.Cells(1).Value



        x = a.Next(1, 24)
        If x = 1 Then
            Call Module1.caso1()
        ElseIf x = 2 Then
            Call Module1.caso2()
        ElseIf x = 3 Then
            Call Module1.caso3()
        ElseIf x = 4 Then
            Call Module1.caso4()
        ElseIf x = 5 Then
            Call Module1.caso5()
        ElseIf x = 6 Then
            Call Module1.caso6()
        ElseIf x = 7 Then
            Call Module1.caso7()
        ElseIf x = 8 Then
            Call Module1.caso8()
        ElseIf x = 9 Then
            Call Module1.caso9()
        ElseIf x = 10 Then
            Call Module1.caso10()
        ElseIf x = 11 Then
            Call Module1.caso11()
        ElseIf x = 12 Then
            Call Module1.caso12()
        ElseIf x = 13 Then
            Call Module1.caso13()
        ElseIf x = 14 Then
            Call Module1.caso14()
        ElseIf x = 15 Then
            Call Module1.caso15()
        ElseIf x = 16 Then
            Call Module1.caso16()
        ElseIf x = 17 Then
            Call Module1.caso17()
        ElseIf x = 18 Then
            Call Module1.caso18()
        ElseIf x = 19 Then
            Call Module1.caso19()
        ElseIf x = 20 Then
            Call Module1.caso20()
        ElseIf x = 21 Then
            Call Module1.caso21()
        ElseIf x = 22 Then
            Call Module1.caso22()
        ElseIf x = 23 Then
            Call Module1.caso23()
        ElseIf x = 24 Then
            Call Module1.caso24()
        Else
            MsgBox("Erro!")


        End If

        RadioButton1.Text = Lvl1DataGridView.CurrentRow.Cells(n).Value
        RadioButton2.Text = Lvl1DataGridView.CurrentRow.Cells(n1).Value
        RadioButton3.Text = Lvl1DataGridView.CurrentRow.Cells(n2).Value
        RadioButton4.Text = Lvl1DataGridView.CurrentRow.Cells(n3).Value

        Dim pos2 = Lvl1BindingSource.Position

        Lvl1BindingSource.EndEdit()
        Lvl1TableAdapter.Update(QuizzDataSet.Lvl1)
        Lvl1TableAdapter.Fill(QuizzDataSet.Lvl1)

        Lvl1BindingSource.Position = pos2
        Timer1.Interval = 1000
        My.Computer.Audio.Play("C:\PAP Pedro Sousa\soundsquizz\CLOCKmodded.wav", AudioPlayMode.Background)
        Timer1.Start()
    End Sub

    Private Sub Lvl1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Lvl1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.QuizzDataSet)

    End Sub


  
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If resposta = Lvl1DataGridView.CurrentRow.Cells(2).Value Then
            My.Computer.Audio.Play("C:\PAP Pedro Sousa\soundsquizz\correct.wav")
            MsgBox("Respondeu corretamente!", MsgBoxStyle.Information)
            Timer1.Stop()
            pontuacao = pontuacao + 10
            TextBox2.Text = pontuacao
            Lvl1BindingSource.EndEdit()
            Lvl1TableAdapter.Update(QuizzDataSet.Lvl1)
            Lvl1TableAdapter.Fill(QuizzDataSet.Lvl1)
        Else
            My.Computer.Audio.Play("C:\PAP Pedro Sousa\soundsquizz\wrong.wav")
            MsgBox("Respondeu incorretamente! Não ganha pontos!", MsgBoxStyle.Critical)
            Timer1.Stop()
        End If
        Button2.Enabled = False
        Lvl1BindingSource.EndEdit()
        Lvl1TableAdapter.Update(QuizzDataSet.Lvl1)
        Lvl1TableAdapter.Fill(QuizzDataSet.Lvl1)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            resposta = RadioButton1.Text
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            resposta = RadioButton2.Text()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            resposta = RadioButton3.Text
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            resposta = RadioButton4.Text
        End If

    End Sub


    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        For Each linha As DataGridViewRow In Lvl1DataGridView.Rows
            Lvl1DataGridView.Rows(linha.Index).Cells("disponivel").Value() = "available"
        Next
        My.Computer.Audio.Stop()
        Lvl1BindingSource.EndEdit()
        Lvl1TableAdapter.Update(QuizzDataSet.Lvl1)
        Lvl1TableAdapter.Fill(QuizzDataSet.Lvl1)
        If MsgBox("Deseja gravar a pontuação?" + MsgBoxStyle.YesNo) = vbYes Then
            sessao.UtilizadoresBindingSource.Position = sessao.pos

            'gravar pontuacao aqui NAO ESQUECER


            Lvl1BindingSource.EndEdit()
            Lvl1TableAdapter.Update(QuizzDataSet.Lvl1)
            Lvl1TableAdapter.Fill(QuizzDataSet.Lvl1)
            Me.Close()
        End If
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Comecar.AxWindowsMediaPlayer1.URL = "c:\PAP Pedro Sousa\videos\intro.mp4"
    End Sub
End Class
