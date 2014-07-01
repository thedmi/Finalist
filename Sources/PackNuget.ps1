
Push-Location FinalList

nuget pack -Build -Prop Configuration=Release -Output ..\..\..\LocalNugetFeed

Pop-Location

Push-Location FinalList.Serialization.JsonNet

nuget pack -Build -Prop Configuration=Release -Output ..\..\..\LocalNugetFeed

Pop-Location
