Namespace States
    ''' <summary>
    ''' (c) MArtin Korneffel 2016
    ''' Zustand wird erreicht, wenn ein editierter Datensatz versucht wurde zu speichern
    ''' </summary>
    ''' <remarks></remarks>
    Public MustInherit Class ValidationResult(Of TID, TRecord As IRecordWithProcessingStatus(Of TID))
        Inherits Base

        ''' <summary>
        ''' Der Datensatz, für den eine Validierung und Speicherung versucht wurde
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public MustOverride ReadOnly Property Record As TRecord

        ''' <summary>
        ''' True, wenn der bearbeitete Datensatz gültig und erfolgreich im zentralen Repository gespeichert
        ''' werden konnte
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property IsValid As Boolean
            Get
                Return Record.ProcessingStatus = ProcessingStatus.valid
            End Get
        End Property

        ''' <summary>
        ''' Im Falle einer gescheiterten Gültigkeitsprüfung oder fehlgeschlagenen Sicherung im zentralen
        ''' Repository die genaue Fehlermeldung
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public MustOverride ReadOnly Property ValidationMessage As String


    End Class
End Namespace

