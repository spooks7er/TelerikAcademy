function solve() {
    var module = (function() {
        String.prototype.isNumberStr = function() {
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
            catId = 0,

            Item = (function() {
                function Item(name, description) {
                    this.id = itemId += 1;
                    this.name = name;
                    this.description = description;
                }

                Object.defineProperty(Item.prototype, 'name', {
                    get: function() {
                        return this._name;
                    },
                    set: function(val) {
                        if (!validator.isStringValid(val, 2, 40)) {
                            throw 'invalid item name';
                        }
                        this._name = val;
                    }
                });

                Object.defineProperty(Item.prototype, 'description', {
                    get: function() {
                        return this._description;
                    },
                    set: function(val) {
                        if (!val || typeof(val) !== 'string') {
                            throw 'invalid item description';
                        }
                        this._description = val;
                    }
                });
                return Item;
            })(),

            Book = (function(parent) {
                function Book(name, isbn, genre, description) {
                    parent.call(this, name, description);
                    this.isbn = isbn;
                    this.genre = genre;
                }

                Book.prototype = Object.create(parent.prototype);
                Book.prototype.constructor = Book;

                Object.defineProperty(Book.prototype, 'isbn', {
                    get: function() {
                        return this._isbn;
                    },
                    set: function(isbn) {
                        if (!isbn || typeof(isbn) !== 'string' || !isbn.isNumberStr() || !(isbn.length === 10 || isbn.length === 13)) {
                            throw 'invalid isbn';
                        }
                        this._isbn = isbn;
                    }
                });

                Object.defineProperty(Book.prototype, 'genre', {
                    get: function() {
                        return this._genre;
                    },
                    set: function(genre) {
                        if (!genre || !validator.isStringValid(genre, 2, 20)) {
                            throw 'invalid genre';
                        }
                        this._genre = genre;
                    }
                });

                return Book;
            })(Item),

            Media = (function(parent) {
                function Media(name, rating, duration, description) {
                    parent.call(this, name, description);
                    this.rating = rating;
                    this.duration = duration;
                }

                Media.prototype = Object.create(parent.prototype);
                Media.prototype.constructor = Media;

                Object.defineProperty(Media.prototype, 'rating', {
                    get: function() {
                        return this._rating;
                    },
                    set: function(rating) {
                        if (!rating || typeof(rating) !== 'number' || rating < 1 || rating > 5) {
                            throw 'invalid rating';
                        }
                        this._rating = rating;
                    }
                });

                Object.defineProperty(Media.prototype, 'duration', {
                    get: function() {
                        return this._duration;
                    },
                    set: function(duration) {
                        if (!duration || typeof(duration) !== 'number' || duration <= 0) {
                            throw 'invalid duration';
                        }
                        this._duration = duration;
                    }
                });

                return Media;
            })(Item),

            Catalog = (function() {
                function Catalog(name) {
                    this.id = catId += 1;
                    this.name = name;
                    this.items = [];
                }

                Object.defineProperty(Catalog.prototype, 'name', {
                    get: function() {
                        return this._name;
                    },
                    set: function(val) {
                        if (!validator.isStringValid(val, 2, 40)) {
                            throw 'invalid catalog name';
                        }
                        this._name = val;
                    }
                });

                Catalog.prototype.add = function() {
                    var i,
                        items = [],
                        len;

                    if (arguments[0] instanceof Array) {
                        items = arguments[0];
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
                };
                return Catalog;
            })(),

            BookCatalog = (function(parent) {
                function BookCatalog(name) {
                    Catalog.call(this, name);
                }

                BookCatalog.prototype = Object.create(Catalog.prototype);
                BookCatalog.prototype.constructor = BookCatalog;

                BookCatalog.prototype.add = function() {
                    if (arguments[0] instanceof Array) {
                        items = arguments[0];
                    } else {
                        items = [].slice.call(arguments);
                    }
                    items.forEach(function(item) {
                        if (!item.id || !item.name || !item.description || !item.isbn || !item.genre) {
                            throw 'invalid books added';
                        }
                    });
                    return parent.prototype.add.call(this, items);
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

                    return parent.prototype.find.call(this, id);
                };
                return BookCatalog;
            })(Catalog),

            MediaCatalog = (function(parent) {
                function MediaCatalog(name) {
                    parent.call(this, name);
                }

                MediaCatalog.prototype = Object.create(Catalog.prototype);
                MediaCatalog.prototype.constructor = MediaCatalog;

                MediaCatalog.prototype.add = function() {
                    if (arguments[0] instanceof Array) {
                        items = arguments[0];
                    } else {
                        items = [].slice.call(arguments);
                    }
                    items.forEach(function(item) {
                        if (!item.id || !item.name || !item.description || !item.rating || !item.duration) {
                            throw 'invalid medias added';
                        }
                    });
                    return parent.prototype.add.call(this, items);
                };

                MediaCatalog.prototype.getTop = function(count) {
                    if (typeof(count) !== 'number' || count < 1) {
                        throw 'invalid count';
                    }

                    var sortedItems = this.items.sort(dynamicSort('-rating'));
                    sortedItems = sortedItems.slice(0, count);

                    var i, len = sortedItems.length,
                        result = [],
                        obj = {};
                    for (i = 0; i < len; i += 1) {
                        obj.id = sortedItems[i].id;
                        obj.name = sortedItems[i].name;
                        result.push(obj);
                    }
                    return result;
                };

                MediaCatalog.prototype.getSortedByDuration = function() {
                    return this.items.sort(dynamicSortMultiple('duration', '-id'));
                };

                MediaCatalog.prototype.find = function(id) {

                    if (arguments.length === 0) {
                        throw 'no agruments in find()';
                    }

                    if (typeof(id) !== 'number') {
                        if (typeof(id) !== 'object') {
                            throw 'id is not a number, or not a valid search criteria';
                        } else {
                            if (id.id || id.name || id.rating) {
                                if (!id.name && !id.rating) {
                                    return this.items.filter(function(obj) {
                                        return obj.id === id.id;
                                    });
                                } else if (!id.id && !id.rating) {
                                    return this.items.filter(function(obj) {
                                        return obj.name === id.name;
                                    });
                                } else if (!id.id && !id.name) {
                                    return this.items.filter(function(obj) {
                                        return obj.rating === id.rating;
                                    });
                                } else if (!id.name) {
                                    return this.items.filter(function(obj) {
                                        return obj.id === id.id && obj.rating === id.rating;
                                    });
                                } else if (!id.id) {
                                    return this.items.filter(function(obj) {
                                        return obj.name === id.name && obj.rating === id.rating;
                                    });
                                } else if (!id.rating) {
                                    return this.items.filter(function(obj) {
                                        return obj.name === id.name && obj.id === id.id;
                                    });
                                } else {
                                    return this.items.filter(function(obj) {
                                        return obj.id === id.id && obj.name === id.name && obj.rating === id.rating;
                                    });
                                }

                            }
                            throw 'invalid search options';
                        }
                    }

                    return parent.prototype.find.call(this, id);
                };

                return MediaCatalog;
            })(Catalog);

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