Namespace States
    ''' <summary>
    ''' (c) Martin Korneffel 2016
    ''' Zustand wird erreicht, wenn ein für das editieren ausgewählter Datensatz nicht editierbar ist
    ''' </summary>
    ''' <typeparam name="TID"></typeparam>
    ''' <typeparam name="TRecord"></typeparam>
    ''' <remarks></remarks>
    Public MustInherit Class ERR_record_not_editable(Of TID, TRecord As IRecordWithProcessingStatus(Of TID))
        Inherits Base

        ''' <summary>
        ''' Datensatz, der nicht editiert werden konnte
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public MustOverride ReadOnly Property Record As TRecord

        ''' <summary>
        ''' Begründung, warum der Datensatz nicht editierbar ist
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public MustOverride ReadOnly Property ErrorMessage As String

    End Class
End Namespace
