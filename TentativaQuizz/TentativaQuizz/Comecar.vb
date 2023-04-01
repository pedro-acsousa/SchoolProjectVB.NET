Public Class Comecar

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sessao.ShowDialog()
        Me.AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub Comecar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim music(1) As String
 
        ' My.Computer.Audio.Play("")
        ' My.Computer.Audio.Stop()

        '  My.Computer.Audio.Play(")

        Music(0) = "C:\PAP Pedro Sousa\soundsquizz\hello.wav"
        music(1) = "C:\PAP Pedro Sousa\soundsquizz\intro.wav"

        '  My.Computer.Audio.Play(music(0), AudioPlayMode.WaitToComplete)
        '   My.Computer.Audio.Play(music(1), AudioPlayMode.Background)


        AxWindowsMediaPlayer1.URL = "c:\PAP Pedro Sousa\videos\intro.mp4"



    End Sub

    Private Sub Comecar_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        AxWindowsMediaPlayer1.URL = "c:\PAP Pedro Sousa\videos\intro.mp4"
    End Sub
End Class