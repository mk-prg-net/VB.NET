Namespace States
    ''' <summary>
    ''' (c) Martin Korneffel 2016
    ''' Zustand wird erreicht, wenn aus einer Liste von Datensätzen einer für die Bearbeitung auszuwählen ist
    ''' </summary>
    ''' <typeparam name="TID"></typeparam>
    ''' <typeparam name="TRecord"></typeparam>
    ''' <remarks></remarks>
    Public MustInherit Class ListOfRecords(Of TID, TRecord As IRecordWithProcessingStatus(Of TID))
        Inherits Base

        ''' <summary>
        ''' Liste von Datensätzen, die bearbeitet werden können
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public MustOverride ReadOnly Property Records As IEnumerable(Of TRecord)

    End Class
End Namespace
