Namespace States
    ''' <summary>
    ''' (c) Martin Korneffel  2016
    ''' Abstrakte Klassenfabriken für die Workflowzustände
    ''' </summary>
    ''' <typeparam name="TID"></typeparam>
    ''' <typeparam name="TRecord"></typeparam>
    ''' <remarks></remarks>
    Public MustInherit Class Factories(Of TID, TRecord As IRecordWithProcessingStatus(Of TID))

        Public MustOverride Function CreateStart() As Start

        Public MustOverride Function CreateListOfRecords() As ListOfRecords(Of TID, TRecord)

        Public MustOverride Function CreateEditRecord(record As TRecord) As EditRecord(Of TID, TRecord)

        Public MustOverride Function CreateERR_record_not_editable(record As TRecord) As ERR_record_not_editable(Of TID, TRecord)

        Public MustOverride Function CreateValidationResult(record As TRecord) As ValidationResult(Of TID, TRecord)

    End Class
End Namespace
