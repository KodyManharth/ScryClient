
Imports System.Timers
Public Class TimedQueue(Of T As IExecutable)
    Protected _Queue As Queue(Of T) = New Queue(Of T)()
    Protected _Timer As Timer = New Timer()
    Protected _TickTime As Double

    Public Sub New(Optional TickTime As Double = 100)
        _Timer.Interval = TickTime
        _Timer.AutoReset = True
        AddHandler _Timer.Elapsed, New ElapsedEventHandler(AddressOf DoTick)
        _Timer.Start()
    End Sub

    Public Sub Add(item As T)
        _Queue.Enqueue(item)
    End Sub

    Public Sub DoTick()
        If _Queue.Count > 0 Then
            _Queue.Dequeue().Execute()
        End If
    End Sub

End Class

