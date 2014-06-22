Function DupeJsonValue ($key, $value, $no)
{
    $total = '"' + $key + '" : "' + $value + '"'
    
    if ($no -gt 1)
    {
        $total = $total*$no
        $total = $total.Replace('""','" , "')
    }

    $total = '{' + $total + '}'
    $total
}
