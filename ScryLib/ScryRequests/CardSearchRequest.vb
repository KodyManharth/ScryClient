Imports System.Security.Policy
Imports System.Text
Imports System.Web

Public Class CardSearchRequest
    Inherits BaseScryRequest(Of CardList)
    Private Shared BasePath As String = "/cards/search"
    Private _Query As String = ""
    Private _SortOrder As String = "set"
    Private _SortDir As String = "auto"
    Private _Page As Integer = 1

    Sub New(Query As String, Optional Page As Integer = 1, Optional SortOrder As String = "set", Optional SortDir As String = "auto")
        MyBase.New()
        _Page = Page
        _Query = Query
        _SortDir = SortDir
        _SortOrder = SortOrder
        Request.AddQueryParameter("q", _Query)
        Request.AddQueryParameter("order", _SortOrder)
        Request.AddQueryParameter("dir", _SortDir)
        Request.AddQueryParameter("page", _Page)
    End Sub

    Public Overrides Property Params As Dictionary(Of String, String)
        Get
            Return New Dictionary(Of String, String)()
        End Get
        Set(value As Dictionary(Of String, String))
        End Set
    End Property

    Public Overrides ReadOnly Property Path As String
        Get
            Return BasePath
        End Get
    End Property
End Class
