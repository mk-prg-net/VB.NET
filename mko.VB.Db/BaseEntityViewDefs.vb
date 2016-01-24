Public Module BaseEntityViewDefs

    ''' <summary>
    ''' Zustand einer View, wenn ihre Inhalte bearbeitet werden
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum ViewState
        ' View wurde neu angelegt
        Detached

        ' View wurde einer Collection hinzugefügt
        Added

        ' View wurde nicht geändert und ist Member einer Collection
        Unchanged

        ' Eigenschaften der View wurden geändert
        Modified

        ' View wurde zum löschen Markiert
        Deleted
    End Enum
End Module
