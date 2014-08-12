var dbsaved = db.runCommand({listDatabases:1})

use admin
db.snaphist.insert({date: new Date(), databases: dbsaved})
