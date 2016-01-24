' Klassenblock
Namespace _01_01_Blockstruktur

    Public Module Modulblock

        Public Class Klassenblock

            Public Shared Sub Unterprogrammblock()

                ' Schleifenblock
                Do
                    ' Bedingter Anweisungsblock
                    If True Then

                        ' Using- Block
                        Using fred_vollgas As New Auto

                            Debug.WriteLine("_00_01_Blockstruktur.Modulblock.Klassenblock.Unterprogrammblock")

                        End Using

                    End If
                Loop While False
            End Sub
        End Class

        Public Class Klassenblock2
            Public Shared Sub Unterprogrammblock()
                Debug.WriteLine("_00_01_Blockstruktur.Modulblock.Klassenblock2.Unterprogrammblock")
            End Sub
        End Class

    End Module

    Public Module Modulblock2
        Public Sub Unterprogrammblock()
            Debug.WriteLine("_00_01_Blockstruktur.Modulblock2.Unterprogrammblock")
        End Sub
    End Module

End Namespace

Namespace _00_01_Blockstruktur_2

    Public Module Modulblock
        Public Sub Unterprogrammblock()
            Debug.WriteLine("_00_01_Blockstruktur_2.Modulblock.Unterprogrammblock")
        End Sub
    End Module

End Namespace
