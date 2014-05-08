Function GetJsonPage ($site, $db, $collection)
{
    $date = Get-Date -f "yyyyMMddHHmmss"
    
    $destination = "D:\MongoDB\bin\Import\file" + $date + ".json"
    $webGrab = New-Object System.Net.WebClient
    $webGrab.DownloadFile($site, $destination)

    $cmd = "D:\MongoDB\bin\mongoimport.exe -file $destination -db $db -collection $collection"
    CMD /C $cmd
}

GetJsonPage -site "" -db "DB" -collection "CO"
