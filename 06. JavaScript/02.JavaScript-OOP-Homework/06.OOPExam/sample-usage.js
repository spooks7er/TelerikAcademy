function solve(argument) {
    var module = (function() {
        String.prototype.isNumberStr = function() {
            // if (typeof(this) !== 'string') {
            // 	return false;
            // }
            return /^\d+$/.test(this);
        };

        function dynamicSort(property) {
            var sortOrder = 1;
            if (property[0] === "-") {
                sortOrder = -1;
                property = property.substr(1);
            }
            return function(a, b) {
                var result = (a[property] < b[property]) ? -1 : (a[property] > b[property]) ? 1 : 0;
                return result * sortOrder;
            };
        }

        function dynamicSortMultiple() {
            var props = arguments;
            return function(obj1, obj2) {
                var i = 0,
                    result = 0,
                    numberOfProperties = props.length;
                while (result === 0 && i < numberOfProperties) {
                    result = dynamicSort(props[i])(obj1, obj2);
                    i++;
                }
                return result;
            };
        }
        var validator = {
                isStringValid: function(str, minLen, maxLen) {
                    return typeof(str) === 'string' && str.length >= minLen && str.length <= maxLen;
                },
            },

            itemId = 0,
            catId = 0;

        // Item
        function Item(name, description) {
            if (!validator.isStringValid(name, 2, 40)) {
                throw 'invalid item name';
            }

            this.id = itemId += 1;
            this.name = name;
            this.description = description;
        }

        // Book
        function Book(name, isbn, genre, description) {
            if (typeof(isbn) !== 'string' || !isbn.isNumberStr() || !(isbn.length === 10 || isbn.length === 13)) {
                throw 'invalid isbn';
            }

            if (!validator.isStringValid(genre, 2, 20)) {
                throw 'invalid book genre text';
            }

            Item.call(this, name, description);
            this.isbn = isbn;
            this.genre = genre;
        }

        Book.prototype = Object.create(Item.prototype);
        Book.prototype.constructor = Book;

        // Media
        function Media(name, rating, duration, description) {
            if (typeof(rating) !== 'number' || rating < 1 || rating > 5) {
                throw 'invalid rating';
            }

            if (typeof(duration) !== 'number' || duration <= 0) {
                throw 'ivalid duration';
            }

            Item.call(this, name, description);
            this.rating = rating;
            this.duration = duration;
        }

        Media.prototype = Object.create(Item.prototype);
        Media.prototype.constructor = Media;

        // Catalog 
        function Catalog(name) {
            if (!validator.isStringValid(name, 2, 40)) {
                throw 'invalid catalog name';
            }
            this.id = catId += 1;
            this.name = name;
            this.items = [];
        }

        Catalog.prototype.add = function() {
            var i,
                items = [], //.slice.call(arguments),
                len;

            if (arguments[0] instanceof Array) {
                items = arguments[0]; //.slice();
            } else {
                items = [].slice.call(arguments);
            }

            len = items.length;

            if (len === 0) {
                throw 'no items were passed';
            }

            items.forEach(function(item) {
                if (!item.id || !item.name || !item.description) {
                    throw 'invalid items added';
                }
            });

            for (i = 0; i < len; i += 1) {
                this.items.push(items[i]);
            }

            // for (i = 0; i < len; i += 1) {
            //     if (!items[i].id || !items[i].name || !items[i].description) {
            //         throw 'invalid items added';
            //     }
            // }

            return this;
        };

        Catalog.prototype.find = function(id) {

            if (arguments.length === 0) {
                throw 'no agruments in find()';
            }

            if (typeof(id) !== 'number') {
                if (typeof(id) !== 'object') {
                    throw 'id is not a number, or not a valid search criteria';
                } else {
                    if (id.id || id.name) {
                        if (!id.name) {
                            return this.items.filter(function(obj) {
                                return obj.id === id.id;
                            });
                        } else if (!id.id) {
                            return this.items.filter(function(obj) {
                                return obj.name === id.name;
                            });
                        } else {
                            return this.items.filter(function(obj) {
                                return obj.id === id.id && obj.name === id.name;
                            });
                        }

                    }
                    throw 'invalid search options';
                }
            }

            var found = this.items.filter(function(obj) {
                return obj.id === id;
            })[0];

            if (found) {
                return found;
            } else {
                return null;
            }
        };

        Catalog.prototype.search = function(pattern) {
            if (typeof(pattern) !== 'string' || pattern.length < 1) {
                throw 'ivalid pattern';
            }
            var thisItems = this.items;
            pattern = pattern.toLowerCase();
            return this.items.filter(function(item) {
                return item.name.toLowerCase().indexOf(pattern) >= 0 ||
                    item.description.toLowerCase().indexOf(pattern) >= 0;
            });
            // var arr = [];
            // for (var i = 0; i < thisItems.length; i++) {
            //     if (thisItems[i].name.toLowerCase().indexOf(pattern) >= 0) {
            //         arr.push(thisItems[i]);
            //         continue;
            //     }
            //     if (thisItems[i].description.toLowerCase().indexOf(pattern) >=0) {
            //     	arr.push(thisItems[i]);
            //     }
            // }
            // return arr;
        };

        // BookCatalog 
        function BookCatalog(name) {
            Catalog.call(this, name);
        }

        BookCatalog.prototype = Object.create(Catalog.prototype);
        BookCatalog.prototype.constructor = BookCatalog;

        BookCatalog.prototype.add = function() {
            if (arguments[0] instanceof Array) {
                items = arguments[0]; //.slice();
            } else {
                items = [].slice.call(arguments);
            }
            items.forEach(function(item) {
                if (!item.id || !item.name || !item.description || !item.isbn || !item.genre) {
                    throw 'invalid books added';
                }
            });
            return Catalog.prototype.add.call(this, items);
        };

        BookCatalog.prototype.getGenres = function() {
            var genres = [];

            for (var i = 0; i < this.items.length; i++) {
                if (genres.indexOf(this.items[i].genre)) {
                    genres.push(this.items[i].genre);
                }
            }
            return genres;
        };

        BookCatalog.prototype.find = function(id) {

            if (arguments.length === 0) {
                throw 'no agruments in find()';
            }

            if (typeof(id) !== 'number') {
                if (typeof(id) !== 'object') {
                    throw 'id is not a number, or not a valid search criteria';
                } else {
                    if (id.id || id.name || id.genre) {
                        if (!id.name && !id.genre) {
                            return this.items.filter(function(obj) {
                                return obj.id === id.id;
                            });
                        } else if (!id.id && !id.genre) {
                            return this.items.filter(function(obj) {
                                return obj.name === id.name;
                            });
                        } else if (!id.id && !id.name) {
                            return this.items.filter(function(obj) {
                                return obj.genre === id.genre;
                            });
                        } else if (!id.name) {
                            return this.items.filter(function(obj) {
                                return obj.id === id.id && obj.genre === id.genre;
                            });
                        } else if (!id.id) {
                            return this.items.filter(function(obj) {
                                return obj.name === id.name && obj.genre === id.genre;
                            });
                        } else if (!id.genre) {
                            return this.items.filter(function(obj) {
                                return obj.name === id.name && obj.id === id.id;
                            });
                        } else {
                            return this.items.filter(function(obj) {
                                return obj.id === id.id && obj.name === id.name && obj.genre === id.genre;
                            });
                        }

                    }
                    throw 'invalid search options';
                }
            }

            return Catalog.prototype.find.call(this, id);
        };

        // MediaCatalog 
        function MediaCatalog(name) {
            Catalog.call(this, name);
        }

        MediaCatalog.prototype = Object.create(Catalog.prototype);
        MediaCatalog.prototype.constructor = MediaCatalog;

        MediaCatalog.prototype.add = function() {
            if (arguments[0] instanceof Array) {
                items = arguments[0]; //.slice();
            } else {
                items = [].slice.call(arguments);
            }
            items.forEach(function(item) {
                if (!item.id || !item.name || !item.description || !item.rating || !item.duration) {
                    throw 'invalid medias added';
                }
            });
            return Catalog.prototype.add.call(this, items);
        };

        MediaCatalog.prototype.getTop = function(count) {
            if (typeof(count) !== 'number' || count < 1) {
                throw 'invalid count';
            }
            //count = count - 1;
            var sortedItems = this.items.sort(dynamicSort('-rating'));
            return sortedItems.slice(0, count);
        };

        MediaCatalog.prototype.getSortedByDuration = function() {
            return this.items.sort(dynamicSortMultiple('duration', '-id'));
        };

        return {
            getBook: function(name, isbn, genre, description) {
                return new Book(name, isbn, genre, description);
            },
            getMedia: function(name, rating, duration, description) {
                return new Media(name, rating, duration, description);
            },
            getBookCatalog: function(name) {
                return new BookCatalog(name);
            },
            getMediaCatalog: function(name) {
                return new MediaCatalog(name);
            }
        };
    })();

    return module;
}

var module = solve();

var catalog = module.getBookCatalog('John\'s catalog');

var book1 = module.getBook('The secrets of the JavaScript Ninja', '1234567890', 'IT', 'A book about JavaScript');
var book2 = module.getBook('JavaScript: The Good Parts', '0123456789', 'IT', 'A good book about JS');
catalog.add(book1);
catalog.add(book2);

console.log(catalog.find(book1.id));
//returns book1

console.log(catalog.find({
    id: book2.id,
    genre: 'IT'
}));
//returns book2

console.log(catalog.search('js'));
// returns book2

console.log(catalog.search('javascript'));
//returns book1 and book2

console.log(catalog.search('Te sa zeleni'));
    //returns []
