/// <reference path="blah.js"/>

QUnit.test("Blah test", function (assert) {
    var blah = new Blah();
    var result = blah.add(2, 3);
    assert.ok(5 === result);
});
