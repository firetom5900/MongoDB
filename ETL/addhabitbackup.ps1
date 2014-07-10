Function AddHabitBackup ($db, $c)
{
    $completed = Get-Content "C:\Habits\completed.json"
    $progress = Get-Content "C:\Habits\progress.json"
    Add-Type -Path "D:\MongoDB\bin\MongoDB.Bson.dll"
    Add-Type -Path "D:\MongoDB\bin\MongoDB.Driver.dll"

    $mongodb = [MongoDB.Driver.MongoDatabase]::Create('mongodb://Timothy/' + $db +'?safe=true')

    $cln = $mongodb[$c]
    #[MongoDB.Bson.BsonDocument] $insertvalue = @{ "_id" = "new ISODate()"; "Completed"= $completed; "Progress"= $progress;}
    $cln.Insert($insertvalue) | Out-Null
}
