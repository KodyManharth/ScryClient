Public Class SetListRequest
    Inherits BaseScryRequest(Of SetList)

    Public Overrides Property Params As Dictionary(Of String, String)
        Get
            Return New Dictionary(Of String, String)()
        End Get
        Set(value As Dictionary(Of String, String))

        End Set
    End Property

    Public Overrides ReadOnly Property Path As String
        Get
            Return "/sets"
        End Get
    End Property

End Class
