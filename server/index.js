var restify = require('restify');

var server = restify.createServer();
server.use(restify.plugins.bodyParser());

server.get('/silos', function(req, res, next) {
    res.send('List of silos: [TODO]');
    return next();
});

server.get('/silos/:id', function(req, res, next) {
    res.send('Current values for silos ' + req.params['id'] + ': [TODO]');
    return next();
});

server.post('/silos/:id', function(req, res, next) {
    res.send('Data received from silos [TODO]');

    console.log(req.body);

    return next();
});

server.listen(8011, function() {
    console.log('%s listening at %s', server.name, server.url);
});
