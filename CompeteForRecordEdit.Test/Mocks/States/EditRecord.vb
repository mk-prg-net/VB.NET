Namespace Mocks.States

    Public Class EditRecord
        Inherits CompeteForRecordEdit.States.EditRecord(Of Integer, Mocks.Record)

        Public Sub New(record As Mocks.Record)
            _record = record
        End Sub

        Dim _record As Mocks.Record
        Public Overrides ReadOnly Property Record As Record
            Get
                Return _record
            End Get
        End Property
    End Class

End Namespace
