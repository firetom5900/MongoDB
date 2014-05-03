import bottle
import pymongo

@bottle.route('/')
def index():
	scon = pymongo.MongoClient('localhost', 27017)
	db = scon.StockAnalysis
	spy = db.SPY
	lt = spy.find_one()
	
	return '<b>Last price %s</b>' % lt['last']
	
bottle.run(host='localhost', port=8082)
# cmd => python localserv.py => localhost:8082