Namespace Mocks
    Public Class Record
        Implements IRecordWithProcessingStatus(Of Integer)

        Sub New(ID As Integer, pstat As ProcessingStatus)
            _ID = ID
            _pstat = pstat
        End Sub


        Dim _ID As Integer
        Dim _pstat As ProcessingStatus

        Public ReadOnly Property ID As Integer Implements IRecordWithProcessingStatus(Of Integer).ID
            Get
                Return _ID
            End Get
        End Property

        Public ReadOnly Property ProcessingStatus As ProcessingStatus Implements IRecordWithProcessingStatus(Of Integer).ProcessingStatus
            Get
                Return _pstat
            End Get
        End Property
    End Class
End Namespace

