db.habz.find().forEach(function(doc) {print(doc.days_of_success/(doc.days_of_success + doc.days_of_failure))})

db.habz.find().forEach(function(doc) {print(doc.creation_date, doc.days_of_success/(doc.days_of_success + doc.days_of_failure))})

