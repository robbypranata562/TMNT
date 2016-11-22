Imports Braincase.GanttChart
Imports Braincase.GanttChart.Chart


Public Class Form1
    Dim TMNT As New ProjectManager()
    Dim Tasking As New Task() With {.Name = "Tasking 1"}
    Dim Tasking2 As New Task() With {.Name = "Tasking 2"}
    Dim chart As New Chart

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GC_Load(sender As Object, e As EventArgs) Handles GC.Load
        TMNT.Add(Tasking)
        TMNT.SetStart(Tasking, 0)
        TMNT.SetEnd(Tasking, 3)
        TMNT.SetComplete(Tasking, 0.3)

        TMNT.Add(Tasking2)
        TMNT.SetComplete(Tasking2, 0.9)
        TMNT.SetStart(Tasking2, 3)
        TMNT.SetEnd(Tasking2, 6)
        TMNT.Start = New Date(2016, 11, 9)
        TMNT.Relate(Tasking, Tasking2)

        GC.Init(TMNT)

    End Sub
    Private Sub GC_TaskMouseOver(sender As Object, e As TaskMouseEventArgs) Handles GC.TaskMouseOver
        Dim message = "Start Date = " + TMNT.GetDateTime(e.Task.Start).Date.ToString + vbCrLf +
                        "End Date = " + TMNT.GetDateTime(e.Task.End).Date.ToString + vbCrLf +
                        "Duration = " + e.Task.Duration.ToString + vbCrLf +
                        "Completed = " + e.Task.Complete.ToString
        GC.SetToolTip(e.Task, message)
    End Sub

    Private Sub GC_TaskMouseDrag(sender As Object, e As TaskDragDropEventArgs) Handles GC.TaskMouseDrag

    End Sub

    Private Sub GC_TaskMouseDrop(sender As Object, e As TaskDragDropEventArgs) Handles GC.TaskMouseDrop
        '   MessageBox.Show(e.Source.Name + TMNT.GetDateTime(e.Source.Start.ToString))
    End Sub

    Private Sub GC_LocationChanged(sender As Object, e As EventArgs) Handles GC.LocationChanged

    End Sub
End Class
