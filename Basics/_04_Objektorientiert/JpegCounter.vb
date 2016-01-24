Public Class JpegCounter
    Inherits DMS.DirTree

    Public Property Count() As Long
        Get
            Return m_Count
        End Get
        Set(value As Long)
            m_Count = Value
        End Set
    End Property
    Private m_Count As Long

    Protected Overrides Function BeginScanDir(path As String) As Boolean
        Count = 0
        Return True
    End Function

    Protected Overrides Function TouchFile(path As String) As Boolean
        Dim ext As String = System.IO.Path.GetExtension(path).ToLower()
        If ext = ".jpg" Then
            Count += 1
        End If
        Return True
    End Function

End Class

