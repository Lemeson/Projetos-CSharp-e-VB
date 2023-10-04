Public Class Demo
    Public Shared Instances As Long
    Public Sub New()
        Instances += 1
    End Sub
    Protected Overrides Sub Finalize()
        Instances -= 1
    End Sub

End Class
