''' <summary>
''' (c) Martin Korneffel
''' Abstrakter Controller für Workflow der konkurrierenden Datensatzverarbeitung
''' </summary>
''' <typeparam name="TID">Typ der ID von Datensätzen</typeparam>
''' <typeparam name="TRecord">Typ von Datensätzen mit der Schnittstelle </typeparam>
''' <remarks></remarks>
Public MustInherit Class Controller(Of TID, TRecord As IRecordWithProcessingStatus(Of TID))

    Public MustOverride Function LoadRecords(Factory As States.Factories(Of TID, TRecord)) As States.Base


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Factory"></param>
    ''' <param name="record"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SelectRecordForEditing(Factory As States.Factories(Of TID, TRecord), record As TRecord) As States.Base

        If record.ProcessingStatus = ProcessingStatus.invalid Or record.ProcessingStatus = ProcessingStatus.unmodified Then
            Return Factory.CreateEditRecord(record)
        Else
            Return Factory.CreateERR_record_not_editable(record)
        End If

    End Function


    Public MustOverride Function SaveRecord(Factory As States.Factories(Of TID, TRecord), record As TRecord) As States.Base


    Public MustOverride Function UpdateRecordStates(Factory As States.Factories(Of TID, TRecord), records As IEnumerable(Of TRecord)) As States.Base




End Class
