Imports Newtonsoft.Json
Imports Newtonsoft.Json.Schema
Imports RestSharp

Public MustInherit Class BaseScryRequest(Of T As New)

    Implements IScryRequest(Of T)

    Protected _Response As RestResponse(Of T)

    Protected _Request As RestRequest = New RestRequest(Path)

    Protected _Data As T

    Public Sub New()
        _Request = New RestRequest(Path, DataFormat.Json)

    End Sub

    Public ReadOnly Property Response As RestResponse(Of T) Implements IScryRequest(Of T).Response
        Get
            Return _Response
        End Get
    End Property

    Public ReadOnly Property Status As ResponseStatus Implements IScryRequest(Of T).Status
        Get
            Return _Response.StatusCode
        End Get
    End Property

    Public ReadOnly Property Request As RestRequest Implements IScryRequest(Of T).Request
        Get
            Return _Request
        End Get
    End Property

    Public ReadOnly Property Data As T Implements IScryRequest(Of T).Data
        Get
            Return _Data
        End Get
    End Property

    Public MustOverride Property Params As Dictionary(Of String, String) Implements IScryRequest(Of T).Params
    Public MustOverride ReadOnly Property Path As String Implements IScryRequest(Of T).Path

    Public Sub Execute() Implements IScryRequest(Of T).Execute
        Perform()
    End Sub

    Public Function Perform() As IScryRequest(Of T) Implements IScryRequest(Of T).Perform
        _Response = ScryAPI.Client.Execute(Of T)(_Request)
        _Data = _Response.Data

        If _Response.ErrorException IsNot Nothing Then
            Const Message As String = "Error, Check inner exception."
            Throw New Exception(Message, _Response.ErrorException)
        End If
        Return Me
    End Function
End Class
