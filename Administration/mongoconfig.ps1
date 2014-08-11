Function AddMongoConfig ($mongopath)
{
    $nl = [Environment]::NewLine
    $d = Get-Date -uFormat "%Y%m%d"
    $configpath = $mongopath + "config\"
   
    if ((Test-Path $configpath) -eq $false)
    {
        New-Item $configpath -ItemType Directory
    }

    $options = "## MongoDB Configuration File" + $nl
    $options = "## Test/Diag quiet false" + $nl
    $options += "logpath=config\mongodb.log" + $nl
    $options += "profile=2" + $nl
    $options += "slowms=25" + $nl
    $options += "verbose=true" + $nl
    $options += "vv=true" + $nl
    $options += "noprealloc=false" + $nl
    #$options += "" + $nl
    
    $config = $configpath + "mongodb.conf"
    if ((Test-Path $config) -eq $true)
    {
        $new = $configpath + "mongodb_" + $d + ".conf"
        Rename-Item $config $new
        New-Item $config -ItemType File
        Add-Content $config $options
    }
    else
    {
        New-Item $config -ItemType File
        Add-Content $config $options
    }

}

AddMongoConfig -mongopath "D:\MongoDB\bin\"
