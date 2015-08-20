function solve() {
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
                return typeof(str) === 'string' || str.length >= minLen || str.length <= maxLen;
            },
        },

        player = (function() {
            var lastId = 0,
                player = {
                    init: function(name) {
                        this.id = lastId += 1;
                        this.name = name;
                        this.playables = [];
                        return this;
                    },
                    get name() {
                        return this._name;
                    },
                    set name(newName) {
                        if (!validator.isStringValid(newName, 3, 5)) {
                            throw 'invalid player name';
                        }
                        this._name = newName;
                    },
                    addPlaylist: function(playable) {
                        if (!playable.id || !playable.name) {
                            throw 'error add playable';
                        }
                        this.playables.push(playable);
                        return this;
                    },
                    getPlaylistById: function(id) {
                        var found = this.playables.filter(function(obj) {
                            return obj.id === id;
                        })[0];

                        if (found) {
                            return found;
                        }
                        return null;
                    },
                    removePlaylist: function(id) {
                        if (id === 'undefined') {
                            throw 'no playable provided ';
                        }

                        if (typeof(id) === 'object') {
                            if (id.id) {
                                this.removePlaylist(id.id);
                            } else {
                                throw 'invalid playable';
                            }
                        } else {
                            if (!this.getPlaylistById(id)) {
                                throw 'Playlist with the provided id is not contained in the player.';
                            }
                            this.playables = this.playables.filter(function(obj) {
                                return obj.id !== id;
                            });
                        }

                        return this;
                    },
                    listPlaylists: function(page, size) {
                        if (typeof(page) === 'undefined' || typeof(size) === 'undefined' ||
                            page < 0 || size <= 0 ||
                            page * size > this.playables.length) {
                            throw 'page size error';
                        }
                        var sortedPlaylists = this.playables.sort(dynamicSortMultiple('name', 'id'));
                        return this.playables.slice(page * size, (page + 1) * size);
                    }
                };
            return player;
        })();

    playlist = (function() {
        var lastId = 0,
            playlist = {
                init: function(name) {
                    this.id = lastId += 1;
                    this.name = name;
                    this.playables = [];
                    return this;
                },
                get name() {
                    return this._name;
                },
                set name(newName) {
                    if (!validator.isStringValid(newName, 3, 5)) {
                        throw 'invalid playlist name';
                    }
                    this._name = newName;
                },
                addPlayable: function(playable) {
                    // if (!playable.id || !playable.title) {
                    //     throw 'error add playable';
                    // }
                    this.playables.push(playable);
                    return this;
                },
                getPlayableById: function(id) {
                    var found = this.playables.filter(function(obj) {
                        return obj.id === id;
                    })[0];

                    if (found) {
                        return found;
                    }
                    return null;
                },
                removePlayable: function(id) {
                    if (id === 'undefined') {
                        throw 'no playable provided ';
                    }

                    if (typeof(id) === 'object') {
                        if (id.id) {
                            this.removePlayable(id.id);
                        } else {
                            throw 'invalid playable';
                        }
                    } else {
                        if (!this.getPlayableById(id)) {
                            throw 'Playable with the provided id is not contained in the player.';
                        }
                        this.playables = this.playables.filter(function(obj) {
                            return obj.id !== id;
                        });
                    }

                    return this;
                },
                listPlayables: function(page, size) {
                    if (typeof(page) === 'undefined' || typeof(size) === 'undefined' ||
                        page < 0 || size <= 0 ||
                        page * size > this.playables.length) {
                        throw 'page size error';
                    }
                    var sortedPlaylists = this.playables.sort(dynamicSortMultiple('title', 'id'));
                    return this.playables.slice(page * size, (page + 1) * size);
                }
            };
        return playlist;
    })();

    playable = (function() {
        var lastId = 0,
            playable = {
                init: function(title, author) {
                    this.id = lastId += 1;
                    this.title = title;
                    this.author = author;
                    return this;
                },
                get title() {
                    return this._title;
                },
                set title(newTitle) {
                    if (!validator.isStringValid(newTitle, 3, 25)) {
                        throw 'Title Error';
                    }
                    this._title = newTitle;
                },
                get author() {
                    return this._author;
                },
                set author(newAuthor) {
                    if (!validator.isStringValid(newAuthor, 3, 25)) {
                        throw 'Author Error';
                    }
                    this._author = newAuthor;
                },
                play: function() {
                    return this.id + '. ' + this.title + ' - ' + this.author;
                },
            };
        return playable;
    })();

    audio = (function(parent) {
            var audio = Object.create(playable);
            audio.init = function(title, author, lenght) {
                parent.init.call(this, title, author);
                this.lenght = lenght;
                return this;
            };
            audio.play = function() {
                return parent.play.call(this) + ' - ' + this.lenght;
            };

            Object.defineProperty(audio, 'lenght', {
                get: function() {
                    return this._lenght;
                },
                set: function(newLnenght) {
                    if (newLnenght <= 0) {
                        throw 'Invalid audio Lenght';
                    }
                    this._lenght = +newLnenght;
                }
            });
            return audio;
        })(playable),

        video = (function(parent) {
            var video = Object.create(playable);
            video.init = function(title, author, imdbRating) {
                parent.init.call(this, title, author);
                this.imdbRating = imdbRating;
                return this;
            };
            video.play = function() {
                return parent.play.call(this) + ' - ' + this.imdbRating;
            };

            Object.defineProperty(video, 'imdbRating', {
                get: function() {
                    return this._imdbRating;
                },
                set: function(newimdbRating) {
                    if (typeof(newimdbRating) !== 'number' || newimdbRating < 1 || newimdbRating > 5) {
                        throw 'error in imdbRating';
                    }
                    this._imdbRating = newimdbRating;
                }
            });
            return video;
        })(playable),

        module = {
            getPlayer: function(name) {
                return Object.create(player).init(name);
            },
            getPlaylist: function(name) {
                return Object.create(playlist).init(name);
            },
            getAudio: function(title, author, length) {
                return Object.create(audio).init(title, author, length);
            },
            getVideo: function(title, author, imdbRating) {
                return Object.create(video).init(title, author, imdbRating);
            }
        };

    return module;
}
module.exports = solve;
var module = solve();

var result = module;
// var returnedPlayable,
//     name = 'Rock and roll',
//     playlist = result.getPlaylist(name),
//     playable = result.getAudio('Banana Rock', 'Wombles', 5);

// returnedPlayable = playlist.addPlayable(playable).getPlayableById(1);

// console.log(playable.id === returnedPlayable.id);
// console.log(playable.name === returnedPlayable.name);
// console.log(playable.author === returnedPlayable.author);
// //console.log(module.getAudio('asdasd', 'someauthor', 5));

var gotten,
    name = 'Rock and roll',
    plName = 'Banana Rock',
    plAuthor = 'Wombles',
    playlist = result.getPlaylist(name),
    playable = result.getAudio('Banana Rock', 'Wombles', 5);

playlist.addPlayable(playable);
playlist.removePlayable(playable);
gotten = playlist.getPlayableById(1);

console.log(gotten);

playlist.addPlayable(playable);
playlist.removePlayable(1);
gotten = playlist.getPlayableById(1);

console.log(gotten);




// playlist.removePlayable(10);

// var plist = module.getPlaylist('plist name');
// for (var i = 0; i < 35; i++) {
//     plist.addPlayable(module.getAudio('asdasd_' + i, 'someauthor', 5));
// }
// var playbl = plist.getPlayableById(74);
// console.log(playbl);
// plist.removePlayable(playbl);
// console.log(plist.listPlayables(0, 35));
