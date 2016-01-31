Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class KeplerDBZugriffe

    <TestMethod()> Public Sub KeplerDBZugriffe_Abfragen()

        Try


            ' 1) Objektrelationalen Mapper anlegen
            Dim orm As New KeplerDBEntities

            ' 2) Zähle alle Himmelskörper in der KeplerDB
            Dim AnzHimmelskoerper = orm.HimmelskoerperTab.Count()

            ' 3) Alle Himmelskörper, die Planeten sind, auflisten
            Dim AllePlaneten = orm.HimmelskoerperTab.Where(Function(r) r.HimmelskoerperTypenTab.Name = "Planet").ToArray()
            Dim ds As New KeplerDataSet

            Dim idCounter As Integer = 0

            For Each planet In AllePlaneten

                If Not planet.Name.StartsWith("Neu") Then
                    Debug.WriteLine("Name : " & planet.Name & " D: " & planet.Sterne_Planeten_MondeTab.Aequatordurchmesser_in_km)
                End If

                Dim row = ds.Planeten.NewPlanetenRow()
                row.ID = idCounter
                idCounter += 1

                row.Name = planet.Name
                row.Masse = planet.Masse_in_kg

                ds.Planeten.AddPlanetenRow(row)

            Next

            Dim Erde = ds.Planeten.Single(Function(r) r.Name = "Erde")

            Dim AlleSchwererAlsDieErde = ds.Planeten.Where(Function(r) r.Masse > Erde.Masse).ToArray()








            ' Einen Datensatz aktualisieren
            Dim Mars = orm.HimmelskoerperTab.Single(Function(r) r.Name = "Mars")

            Mars.Sterne_Planeten_MondeTab.Aequatordurchmesser_in_km *= 10

            ' Durch folgende Anweisung werden alle Änderungen am Objektmodell in die Datenbank übernommen
            orm.SaveChanges()

            ' Ein ungebundenen Himmelskoerperdatensatz erzeugen und konfigurieren
            Dim neuerPlanet = orm.HimmelskoerperTab.Create()
            neuerPlanet.Name = "Neu"
            neuerPlanet.HimmelskoerperTypenTab = orm.HimmelskoerperTypenTab.Single(Function(r) r.Name = "Planet")

            ' Den neuen Datensatz der Liste der Himmelskörper hinzufügen
            orm.HimmelskoerperTab.Add(neuerPlanet)


            orm.SaveChanges()

        Catch ex As Exception
            Debug.WriteLine(ex.Message)

        End Try

    End Sub

End Class