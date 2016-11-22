Imports Braincase.GanttChart


Public Class Form1
    Dim TMNT As New ProjectManager()
    Dim Tasking As New Task() With {.Name = "Tasking 1"}
    Dim Tasking2 As New Task() With {.Name = "Tasking 2"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Tasking.Name("Tasking 1")


        'TMNT.

    End Sub

    Private Sub GC_Load(sender As Object, e As EventArgs) Handles GC.Load
        TMNT.Add(Tasking)
        'TMNT.SetDuration(Tasking, 4)
        TMNT.SetComplete(Tasking, 0.3)
        TMNT.Add(Tasking2)
        'TMNT.SetDuration(Tasking2, 2)
        TMNT.SetComplete(Tasking2, 0.9)
        TMNT.SetStart(Tasking, 1)
        TMNT.SetEnd(Tasking, 3)
        TMNT.SetStart(Tasking2, 4)
        TMNT.SetEnd(Tasking2, 6)

        GC.Init(TMNT)
    End Sub

    Private Sub GC_TaskSelected(sender As Object, e As TaskMouseEventArgs) Handles GC.TaskSelected
        'GC.SetToolTip((Task), Tasking.Name, Tasking.Complete.ToString)
        'If e.Task Then

        'End If
        'MessageBox.Show(Tasking.Name + " " + Tasking.Start.ToString + " " + Tasking.End.ToString + " " + Tasking.Duration.ToString + " " + Tasking.Complete.ToString)
        'ToolTip1.Show("sda", Me)
        MessageBox.Show(e.Task.ToString
                        )
    End Sub

    Private Sub GC_MouseHover(sender As Object, e As EventArgs) Handles GC.MouseHover

        ' MessageBox.Show(Tasking.Name + " " + Tasking.Start.ToString + " " + Tasking.End.ToString + " " + Tasking.Duration.ToString + " " + Tasking.Complete.ToString)
     
    End Sub
End Class
