Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Linq

<TestClass()> Public Class AccessDB

    Const ConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                                       "Data Source=.\NewMDB.mdb;" & _
                                       "Jet OLEDB:Engine Type=5"

    ''' <summary>
    ''' Programatisch eine neue Access- DB anlegen
    ''' https://support.microsoft.com/en-us/kb/317867
    ''' 
    ''' Die Datenbank wurde anschliessend mittels Microsoft SQL- Server Mgmt- Studio 
    ''' und einem Export- Paket mit den Daten der originalen Kepler DB befüllt. 
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod()> Public Sub Access_Create_DB()

        Try

            Dim cat = New ADOX.Catalog()


            cat.Create(ConnectionString)

            cat = Nothing

        Catch ex As Exception
            Debug.WriteLine("DB anlegen fehlgeschlagen: " + ex.Message)
        End Try

    End Sub


    ''' <summary>
    ''' Zugriff mittels der elementaren ADO- Objekte wie Connection und Command
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod()> Public Sub Access_AccessData_ADO_classic()

        Try
            Using con = New OleDb.OleDbConnection(ConnectionString)

                Dim cmd As New OleDb.OleDbCommand()

                cmd.Connection = con
                cmd.CommandText = "Select * from HimmelskoerperTab;"

                con.Open()

                Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()

                    While reader.Read()

                        Dim name As String = CType(reader("Name"), String)
                        Dim masse_in_kg As Double = CType(reader("Masse_in_kg"), Double)

                        Debug.Print(name & ", Masse: " & masse_in_kg)

                    End While

                End Using
                con.Close()

            End Using

        Catch ex As Exception
            Debug.WriteLine(ex)

        End Try

    End Sub

    <TestMethod()> Public Sub Access_AccessData_ADO_DataSet()

        Try
            Using con = New OleDb.OleDbConnection(ConnectionString)

                ' Adapter zum Füllen der Tabellen anlegen
                Dim adpHimmelkoerper As New KeplerDataSetTableAdapters.HimmelskoerperTabTableAdapter()
                Dim adpHimmelkoerperTypen As New KeplerDataSetTableAdapters.HimmelskoerperTypenTabTableAdapter()
                Dim adpSpektralklassen As New KeplerDataSetTableAdapters.SpektralklasseTabTableAdapter()
                Dim adpSternePalanetenMonde As New KeplerDataSetTableAdapters.Sterne_Planeten_MondeTabTableAdapter()
                Dim adpPlaneten As New KeplerDataSetTableAdapters.PlanetenTableAdapter()


                Dim ds As New KeplerDataSet()

                ' Tabellen mit Definitionsbereichen in das Dataset laden)
                adpHimmelkoerperTypen.Fill(ds.HimmelskoerperTypenTab)
                adpSpektralklassen.Fill(ds.SpektralklasseTab)


                ' Tabellen mit einer Auswahl an Entities laden (Planeten, Sterne)
                adpSternePalanetenMonde.ClearBeforeFill = False
                adpSternePalanetenMonde.FillByPlanets(ds.Sterne_Planeten_MondeTab)
                adpSternePalanetenMonde.FillByStars(ds.Sterne_Planeten_MondeTab)

                adpHimmelkoerper.ClearBeforeFill = False
                adpHimmelkoerper.FillByStars(ds.HimmelskoerperTab)
                ' Problem mit der nicht gesetzten Eigenschaft SpektralklasseId
                adpHimmelkoerper.FillByPlanets(ds.HimmelskoerperTab)
                adpPlaneten.Fill(ds.Planeten)

                ' Zugriff auf Stern Sonne 
                Dim sonne = ds.HimmelskoerperTab.Single(Function(r) r.Name = "Sonne")
                Assert.IsNotNull(sonne)

                Assert.IsNotNull(sonne.HimmelskoerperTypenTabRow)
                Assert.IsNotNull("Stern", sonne.HimmelskoerperTypenTabRow.Name)

                Assert.IsNotNull(sonne.SpektralklasseTabRow)
                Assert.AreEqual("G", sonne.SpektralklasseTabRow.Name)

                Assert.IsNotNull(sonne.Sterne_Planeten_MondeTabRow)

                ' Zugriff auf Jupiter mittels LINQ
                Dim jupiter = ds.HimmelskoerperTab.Single(Function(r) r.Name = "Jupiter")
                Assert.IsNotNull(jupiter)

                Assert.IsTrue(20.0 < jupiter.Sterne_Planeten_MondeTabRow.Fallbeschleunigung_in_meter_pro_sec)

                ' Zugriff auf den Planeten Erde mittel LINQ To DataSet
                Dim erde = ds.Planeten.Single(Function(r) r.Name = "Erde")
                Assert.IsNotNull(erde)

                ' Zugriff auf Detaildaten über Navigationseigenschaften

                Assert.IsNotNull(erde.Sterne_Planeten_MondeTabRow)
                Assert.AreEqual(9.81, Math.Round(erde.Sterne_Planeten_MondeTabRow.Fallbeschleunigung_in_meter_pro_sec, 2))


                ' Alle Planeten, die leichter als die Erde sind
                Dim alleLeichten = ds.HimmelskoerperTab.Where(Function(r) r.Masse_in_kg <= erde.Masse_in_kg)


                For Each planet In alleLeichten
                    Assert.IsTrue(planet.Masse_in_kg <= erde.Masse_in_kg)
                Next




            End Using



        Catch ex As Exception
            Debug.WriteLine(ex)

        End Try


    End Sub












End Class