Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class _04_07_Fehlerbehandlung

    Private Shared Sub up1()
        Try
            Debug.WriteLine("UP1: Vor dem ersten Fehler.")
            'throw new Exception("Erster Fehler aus UP1");
            up2()
            Debug.WriteLine("UP1: Nach dem ersten Fehler.")
        Catch ex As Exception

            ' Fehlerobjekt erneut werfen
            'throw;
            Throw New Exception("CATCH Handler aus UP1", ex)
        Finally
            Debug.WriteLine("Finally aus UP1")
        End Try
    End Sub

    Private Shared Sub up2()
        Dim fs As New System.IO.FileStream("C:\Fantasie.txt", System.IO.FileMode.Open)
    End Sub


    <TestMethod()> Public Sub _04_07_Fehlerbehandlung_Test()
        Try
            up2()
        Catch ex As System.IO.FileNotFoundException
            Debug.WriteLine("FileNotFoundException: " + ex.Message)
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            Debug.WriteLine("Finally aus Main")
        End Try

        ' Achtung: Abgeleitete Fehler müssen vor den Fehlern der Basisikalsse analysiert werden
        'try
        '{
        '    up2();
        '}            
        'catch (Exception ex)
        '{
        '    Debug.WriteLine(ex.Message);
        '}
        'catch (System.IO.FileNotFoundException ex)
        '{
        '    Debug.WriteLine("FileNotFoundException: " + ex.Message);
        '}
        'finally
        '{
        '    Debug.WriteLine("Finally aus Main");
        '}

        Try
            Debug.WriteLine("HP1: Vor dem ersten Fehler.")
            up1()
            Debug.WriteLine("HP1: Nach dem ersten Fehler.")
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            If ex.InnerException IsNot Nothing Then

                Debug.WriteLine("Ursrünglicher Fehler: " + ex.InnerException.Message)
            End If

            Debug.WriteLine(mko.ExceptionHelper.FlattenExceptionMessages(ex))
        End Try


    End Sub

End Class