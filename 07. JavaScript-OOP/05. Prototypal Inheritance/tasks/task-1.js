function solve() {
    var domElement = (function () {
        var domElement = {
            init: function (type) {
                this.type = type;
                this.attributes = {};
                this.children = [];
                this.content = '';
                this.parent = null;
                return this;
            },
            appendChild: function (child) {
                if (typeof child !== 'string') {
                    child.parent = this;
                }
                this.children.push(child);
                return this;
            },
            addAttribute: function (name, value) {
                if (name === '' || (name.match(/[^\w\-]/))) {
                    throw 'Letters, digits and - only';
                }
                this.attributes[name] = value;
                return this;
            },
            removeAttribute: function (attribute) {
                if (isExistAttribute(attribute, this)) {
                    delete this.attributes[attribute];
                } else {
                    throw new Error('You are trying to remove an unexisting attribute!');
                }
                return this;
            },
            get innerHTML() {
                return createInnerHtml(this);
            }
        };

        function createInnerHtml(obj) {
            var innerResult = '',
                result;
            if (obj.children.length > 0) {
                obj.children.forEach(function (item) {
                    typeof item === 'string' ? innerResult += item : innerResult += item.innerHTML;
                });
                result = '<' + obj.type + parseAttributes(obj.attributes) + '>' + innerResult + '</' + obj.type + '>';
            } else {
                result = '<' + obj.type + parseAttributes(obj.attributes) + '>' + obj.content + '</' + obj.type + '>';
            }
            return result;
        }

        function isString(obj) {
            return ((typeof obj == 'string' || obj instanceof String) && obj)
        }

        function isExistAttribute(attribute, self) {
            if (isString(attribute)) {
                for (var attr in self.attributes) {
                    if (attr === attribute) {
                        return true;
                    }
                }
                return false;
            } else {
                return false;
            }
        }

        function parseAttributes(obj) {
            var result = ' ',
                attr,
                arr = [];
            for (attr in obj) {
                arr.push([attr, obj[attr]]);
            }
            arr.sort();
            arr.forEach(function (item) {
                result += item[0] + '="' + item[1] + '" ';
            });
            return result.trimRight();
        }

        Object.defineProperty(domElement, 'type', {
            get: function () {
                return this._type;
            },
            set: function (value) {
                if (value === '' || value.match(/[^\w]/)) {
                    throw 'Letters and digits only';
                }
                this._type = value;
            },
            enumerable: true
        });

        Object.defineProperty(domElement, 'content', {
            get: function () {
                return this._content;
            },
            set: function (value) {
                if (!this.hasChildren) {
                    this._content = value;
                }
            },
            enumerable: true
        });

        return domElement;
    }());

    return domElement;
}
module.exports = solve;
