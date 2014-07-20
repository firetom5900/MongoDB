$bit = (Get-WmiObject win32_operatingsystem).OSArchitecture

if ($bit -like "*64*")
{
    [System.Diagnostics.Process]::Start("https://fastdl.mongodb.org/win32/mongodb-win32-x86_64-2008plus-2.6.3-signed.msi")
}
else
{
    [System.Diagnostics.Process]::Start("https://fastdl.mongodb.org/win32/mongodb-win32-i386-2.6.3-signed.msi")
}
