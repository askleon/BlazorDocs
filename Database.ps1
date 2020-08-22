param (
    [switch]$AddMigration,
    [switch]$Update
)

$server = ".\src\Server\"
$database = ".\src\Database\"

if ($AddMigration) {
    Set-Location $database
    $migrationName = read-host "Migration name"
    & dotnet ef migrations add "$migrationName" -s ..\Server
    Set-Location ..\..\
}

if ($Update) {
    & dotnet ef database update -s "$server"
}

