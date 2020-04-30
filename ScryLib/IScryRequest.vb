Imports RestSharp

Public Interface IScryRequest(Of T As New)
    Inherits IExecutable

    ReadOnly Property Params As Dictionary(Of String, String)
    ReadOnly Property Path As String
    ReadOnly Property Response As RestResponse(Of T)
    ReadOnly Property Status As ResponseStatus
    ReadOnly Property Request As RestRequest

    ReadOnly Property Data As T

    Function Perform() As IScryRequest(Of T)

End Interface
