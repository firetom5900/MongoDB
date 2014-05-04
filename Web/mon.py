import bottle

# Home
@bottle.route('/')

#Pages
@bottle.route('/page')

bottle.debug(True)
bottle.run(host='localhost', port=8080)