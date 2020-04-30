Imports System.Net
Imports RestSharp
Imports RestSharp.Serializers.NewtonsoftJson

Public Class ScryAPI
    Private Const _BaseUrl As String = "https://api.scryfall.com"
    Friend Shared _Client As RestClient
    Private Shared _RequestQueue As TimedQueue(Of IExecutable)

    Friend Shared ReadOnly Property Client As RestClient
        Get
            Return _Client
        End Get
    End Property

    Sub New()
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 Or SecurityProtocolType.Tls11 Or SecurityProtocolType.Tls

        _Client = New RestClient(_BaseUrl)
        _Client.UseNewtonsoftJson()
        _RequestQueue = New TimedQueue(Of IExecutable)(100)
    End Sub

    Public Function PerformRequest(Of T As New)(Request As IScryRequest(Of T)) As IScryRequest(Of T)
        '_RequestQueue.Add(Request)
        Return Request.Perform()
    End Function

End Class
