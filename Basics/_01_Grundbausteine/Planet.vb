

''' <summary>
''' Planeten- Datensatz
''' </summary>
''' <remarks></remarks>
Public Structure Planet
    ''' <summary>
    ''' Name des Planeten
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Name As String

    ''' <summary>
    ''' Bei Planeten wie Jupiter oder Saturn: ja
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property istGasplanet As Boolean

    ''' <summary>
    '''  Durchmesser des Planeten
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DiameterInKm As Double

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property GravityInMeterPerSec As Double
End Structure



