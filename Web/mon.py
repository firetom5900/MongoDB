import bottle

# Home
@bottle.route('/')

#Pages
@bottle.route('/page')

#Tickers
@bottle.route('/tickers')


bottle.debug(True)
bottle.run(host='localhost', port=8080)
