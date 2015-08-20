/* Task Description */
/*
 * Create an object domElement, that has the following properties and methods:
 * use prototypal inheritance, without function constructors
 * method init() that gets the domElement type
 * i.e. `Object.create(domElement).init('div')`
 * property type that is the type of the domElement
 * a valid type is any non-empty string that contains only Latin letters and digits
 * property innerHTML of type string
 * gets the domElement, parsed as valid HTML
 * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
 * property content of type string
 * sets the content of the element
 * works only if there are no children
 * property attributes
 * each attribute has name and value
 * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
 * property children
 * each child is a domElement or a string
 * property parent
 * parent is a domElement
 * method appendChild(domElement / string)
 * appends to the end of children list
 * method addAttribute(name, value)
 * throw Error if type is not valid
 * method removeAttribute(attribute)
 * throw Error if attribute does not exist in the domElement
 */


/* Example

var meta = Object.create(domElement)
  .init('meta')
  .addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
  .init('head')
  .appendChild(meta)

var div = Object.create(domElement)
  .init('div')
  .addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
  .init('body')
  .appendChild(div)
  .addAttribute('id', 'cuki')
  .addAttribute('bgcolor', '#012345');

var root = Object.create(domElement)
  .init('html')
  .appendChild(head)
  .appendChild(body);

console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/


function solve() {
    var domElement = (function() {
        var lt = '<',
            gt = '>',
            slash = '/',
            children = [];

        var domElement = {
            init: function(type) {
                if (!type || typeof(type) !== 'string' || !/^[a-zA-Z0-9]+$/.test(type)) {
                    throw 'Error invalid type';
                }

                this.type = type;
                this.attributes = [];
                this.children = [];
                this._content = '';

                return this;
            },
            appendChild: function(child) {
                if (typeof(child) !== 'string') {
                    child.parent = this;
                }

                this.children.push(child);

                return this;
            },
            addAttribute: function(name, value) {
                if (!name || typeof(name) !== 'string' || !/^[a-zA-Z0-9-]+$/.test(name)) {
                    throw 'Error invalid attribute name';
                }

                var i,
                    len = this.attributes.length;

                for (i = 0; i < len; i += 1) {
                    if (this.attributes[i].indexOf(name) > -1) {
                        this.attributes[i] = name + '=' + '"' + value + '"';
                        return this;
                    }
                }

                this.attributes.push(name + '=' + '"' + value + '"');
                this.attributes = this.attributes.sort();
                return this;
            },
            removeAttribute: function(name) {
                var hasAttr = 0,
                    i,
                    len = this.attributes.length;

                for (i = 0; i < len; i += 1) {
                    if (this.attributes[i].indexOf(name) > -1) {
                        hasAttr = 1;
                        this.attributes.splice(i, 1);
                        i -= 1;
                        len -= 1;
                    }
                }

                if (!hasAttr) {
                    throw 'Error no such attribute';
                }
                return this;
            },
            get innerHTML() {
                var i,
                    len = this.children.length,
                    attributes = '',
                    children = '';

                if (this.attributes.length !== 0) {
                    attributes = ' ' + this.attributes.join(' ');
                }

                if (len === 0) {
                    return lt + this.type + attributes + gt + this.content + lt + slash + this.type + gt;
                }

                for (i = 0; i < len; i += 1) {
                    if (typeof(this.children[i]) === 'string') {
                        children += this.children[i];
                        continue;
                    }
                    children += this.children[i].innerHTML;
                }

                return lt + this.type + attributes + gt + children + lt + slash + this.type + gt;
            },
            get content() {
                return this._content;
            },
            set content(value) {
                this._content = value;
            }
        };
        return domElement;
    }());
    return domElement;
}

module.exports = solve;

var domElement = solve();

var text = 'Some text here, doesn\'t really matter that much what it is.',
    root = Object.create(domElement).init('p');
    
root.content = text;

console.log(root);
// var text = 'Some text here, doesn\'t really matter that much what it is.',
//     root = Object.create(domElement)
//     .init('p')
//     .appendChild(text);

// console.log(root.innerHTML === '<p>' + text + '</p>');

// console.log(child.parent);
