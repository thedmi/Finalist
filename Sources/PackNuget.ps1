
Push-Location Finalist

nuget pack -Build -Prop Configuration=Release -Output ..\..\..\LocalNugetFeed

Pop-Location

Push-Location Finalist.Serialization.JsonNet

nuget pack -Build -Prop Configuration=Release -Output ..\..\..\LocalNugetFeed

Pop-Location
