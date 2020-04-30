Imports System.Web.Caching
Imports ScryLib

Public Class ScryClientMain
    Protected Scry As ScryAPI = New ScryAPI()
    Private Sub ScryClientMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub setLoadButton_Click(sender As Object, e As EventArgs) Handles setLoadButton.Click
        Dim Request As SetListRequest = Scry.PerformRequest(New SetListRequest())
        If Request.Response IsNot Nothing Then
            setListCount.Text = Request.Data.Data.Count
            SetList.Items.Clear()

            For Each cardSet As CardSet In Request.Data.Data
                Dim codeLvi As ListViewItem.ListViewSubItem = New ListViewItem.ListViewSubItem()
                codeLvi.Text = cardSet.Code
                codeLvi.Name = "Code"
                Dim nameLvi As ListViewItem.ListViewSubItem = New ListViewItem.ListViewSubItem()
                nameLvi.Text = cardSet.Name
                nameLvi.Name = "Name"
                Dim cardCountLvi As ListViewItem.ListViewSubItem = New ListViewItem.ListViewSubItem()
                cardCountLvi.Text = cardSet.CardCount.ToString()
                cardCountLvi.Name = "Cards"

                Dim inputArray = New ListViewItem.ListViewSubItem() {codeLvi, nameLvi, cardCountLvi}

                Dim parentLvi As ListViewItem = New ListViewItem(inputArray, 0)
                SetList.Items.Add(parentLvi)

            Next

            SetList.Items.Add(New ListViewItem())
        End If
    End Sub

    Private Sub cardLoadButton_Click(sender As Object, e As EventArgs) Handles cardLoadButton.Click
        If SetList.SelectedItems.Count < 1 Then
            MessageBox.Show("You must select at least one set of cards from the left.")
            Return
        End If

        Dim TotalCardCount As Integer = 0
        CardList.Items.Clear()

        For Each cardSet As ListViewItem In SetList.SelectedItems
            Dim name As String = cardSet.SubItems(cardSet.SubItems.IndexOfKey("Name")).Text
            Dim cardCount As String = cardSet.SubItems(cardSet.SubItems.IndexOfKey("Cards")).Text
            Dim code As String = cardSet.SubItems(cardSet.SubItems.IndexOfKey("Code")).Text

            Dim group As ListViewGroup = New ListViewGroup()
            group.Name = code
            group.Header = code + " - " + name + ", Cards: " + cardCount
            group.HeaderAlignment = HorizontalAlignment.Center

            Dim request As CardSearchRequest = Scry.PerformRequest(New CardSearchRequest("e:" + code))
            Dim requestData As CardList = request.Data

            For Each card In requestData.Data

                Dim nameLvi As ListViewItem.ListViewSubItem = New ListViewItem.ListViewSubItem()
                nameLvi.Text = card.Name
                nameLvi.Name = "Name"
                Dim rarityLvi As ListViewItem.ListViewSubItem = New ListViewItem.ListViewSubItem()
                rarityLvi.Text = card.Rarity

                If card.Rarity = "uncommon" Then
                    rarityLvi.ForeColor = Color.Silver
                ElseIf card.Rarity = "rare" Then
                    rarityLvi.ForeColor = Color.Gold
                ElseIf card.Rarity = "mythic" Then
                    rarityLvi.ForeColor = Color.SaddleBrown
                End If


                rarityLvi.Name = "Rarity"
                Dim priceLvi As ListViewItem.ListViewSubItem = New ListViewItem.ListViewSubItem()
                priceLvi.Text = "$" + card.Prices.Usd
                priceLvi.Name = "Price"
                Dim numberLvi As ListViewItem.ListViewSubItem = New ListViewItem.ListViewSubItem()
                numberLvi.Text = card.CollectorNumber.ToString()
                numberLvi.Name = "Number"

                Dim inputArray As ListViewItem.ListViewSubItem() = {nameLvi, rarityLvi, priceLvi, numberLvi}
                Dim parentLvi As ListViewItem = New ListViewItem(inputArray, 0)
                group.Items.Add(parentLvi)
                CardList.Items.Add(parentLvi)

            Next
            CardList.Groups.Add(group)
            Threading.Thread.Sleep(100)
        Next
    End Sub
End Class
