''' <summary>
''' (c) Martin Korneffel 2016
''' 
''' Schnittstelle eines Datensatzes, die über seinen BEarbeitungszustand informiert
''' </summary>
''' <remarks></remarks>
Public Interface IRecordWithProcessingStatus(Of TId)

    ReadOnly Property ID As TId

    ReadOnly Property ProcessingStatus As ProcessingStatus
End Interface
