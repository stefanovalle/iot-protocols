var restify = require('restify');

var server = restify.createServer();
server.use(restify.plugins.bodyParser());

server.get('/stations', function(req, res, next) {
    res.send('List of stations: [TODO]');
    return next();
});

server.get('/stations/:station', function(req, res, next) {
    res.send('Current values for station ' + req.params['station'] + ': [TODO]');
    return next();
});

server.post('/stations/:station', function(req, res, next) {
    res.send('Data received from station [TODO]');

    // uncomment to see posted data
    //console.log(req.body);

    return next();
});

server.listen(8080, function() {
    console.log('%s listening at %s', server.name, server.url);
});
