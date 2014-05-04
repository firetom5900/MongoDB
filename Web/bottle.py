import bottle

html_end = "</body></html>"

def html_headertitle(title):
    return "<!DOCTYPE html><html><head><title>" + title + "</title></head><body>"

# Home
@bottle.route('/')
def default():
	body = ""
	return html_headertitle("My Title") + body + html_end

#Pages
@bottle.route('/page')

bottle.debug(True)
bottle.run(host='localhost', port=8080)