QUnit.module('Requirement 5');
QUnit.test( "startsWith", function( assert ) {
  assert.ok('hang the dj'.startsWith('hang'));
  assert.notOk('hang the dj'.startsWith('Hang'));
  assert.notOk('hang the dj'.startsWith('I’ve got a room for rent'));
  assert.ok('hang the dj'.startsWith(''));
  assert.ok('hang the dj'.startsWith('hang the'));
  assert.ok('hang the dj'.startsWith('han'));
  assert.ok('hang the dj'.startsWith('hang t'));
  assert.notOk('hang the dj'.startsWith(42));
  assert.notOk('hang the dj'.startsWith({ first: "Johnny" }));
});

QUnit.test( "endsWith", function( assert ) {
  assert.ok('hang the dj'.endsWith('dj'));
  assert.notOk('hang the dj'.endsWith('panic on the streets'));
  assert.ok('hang the dj'.endsWith(''));
  assert.ok('hang the dj'.endsWith('the dj'));
  assert.ok('hang the dj'.endsWith('e dj'));
  assert.ok('hang the dj'.endsWith('j'));
  assert.notOk('hang the dj'.endsWith(42));
  assert.notOk('hang the dj'.endsWith({ first: "Johnny" }));
});

QUnit.module('Requirement 6');
QUnit.test( "stripHtml", function( assert ) {
  assert.equal('<p>Shoplifters of the World <em>Unite</em>!</p>'.stripHtml(), 'Shoplifters of the World Unite!');
  assert.equal('1 &lt; 2'.stripHtml(), '1 &lt; 2');
});
