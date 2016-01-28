Namespace States

    ''' <summary>
    ''' (c) Martin Korneffel 2016
    ''' ZUstand wird erreicht, wenn ein Datensatz zum editieren erfolgreich ausgewählt wurde
    ''' </summary>
    ''' <typeparam name="TID"></typeparam>
    ''' <typeparam name="TRecord"></typeparam>
    ''' <remarks></remarks>
    Public MustInherit Class EditRecord(Of TID, TRecord As IRecordWithProcessingStatus(Of TID))
        Inherits Base

        ''' <summary>
        ''' Der zu editierende Datensatz
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public MustOverride ReadOnly Property Record As TRecord

    End Class
End Namespace
