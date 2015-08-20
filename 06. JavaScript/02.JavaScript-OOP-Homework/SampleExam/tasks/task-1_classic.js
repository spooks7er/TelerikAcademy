function solve() {

    var module = (function() {
        var currentPlayerId = 0,
            currentPlaylistId = 0,
            currentPlayableId = 0;

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

        //Player
        function Player(name) {
            this.name = name;
            this.id = currentPlayerId += 1;
            this.playlists = [];
        }

        Player.prototype.addPlaylist = function(playlistToAdd) {
            if (playlistToAdd instanceof Playlist) {
                this.playlists.push(playlistToAdd);
                return this;
            }

            throw 'Object is not of Playlist instance.';
        };

        Player.prototype.getPlaylistById = function(id) {
            var found = this.playlists.filter(function(obj) {
                return obj.id === id;
            })[0];

            if (found) {
                return found;
            } else {
                return null;
            }
        };

        Player.prototype.removePlaylist = function(id) {
            if (id instanceof Playlist) {
                this.removePlaylist(id.id);
            } else {
                if (!this.getPlaylistById(id)) {
                    throw 'Playlist with the provided id is not contained in the player.';
                }

                this.playlists = this.playlists.filter(function(obj) {
                    return obj.id !== id;
                });
            }

            return this;
        };

        Player.prototype.listPlaylists = function(page, size) {
            var i,
                whole,
                remainder,
                plPage = [],
                sortedPlaylists = this.playlists.sort(dynamicSortMultiple('name', 'id')),
                len = sortedPlaylists.length;

            if (typeof(page) === 'undefined' || typeof(size) === 'undefined' ||
                page < 0 || size <= 0 ||
                page * size > this.playables.length) {
                throw 'page size error';
            }

            if (len <= size) {
                return sortedPlaylists;
            }

            remainder = len % size;

            if (remainder === 0) {
                for (i = page * size; i < page * size + size; i += 1) {
                    plPage.push(sortedPlaylists[i]);
                }
            } else {
                whole = len - remainder;

                if (page > (whole / size) - 1) {
                    for (i = whole; i < whole + remainder; i += 1) {
                        plPage.push(sortedPlaylists[i]);
                    }
                } else {
                    for (i = page * size; i < page * size + size; i += 1) {
                        plPage.push(sortedPlaylists[i]);
                    }
                }
            }

            return plPage;
        };

        Player.prototype.contains = function(playable, playlist) {

        };

        Player.prototype.search = function(pattern) {

            // Returns an array of all playlists, that contain a song, which title contains the pattern
            // --In the returned array, only id and title of the playlists are returned
            // Returns empty array ig no such playlists exists

        };

        //Playlist
        function Playlist(name) {
            this.name = name;
            this.id = currentPlaylistId += 1;
            this.playables = [];
        }

        Playlist.prototype.addPlayable = function(playable) {
            if (!playable.id || !playable.name) {
                throw 'error add playable';
            }
            this.playables.push(playable);
            return this;
        };

        Playlist.prototype.getPlayableById = function(id) {
            var found = this.playables.filter(function(obj) {
                return obj.id === id;
            })[0];

            if (found) {
                return found;
            } else {
                return null;
            }
        };

        Playlist.prototype.removePlayable = function(id) {
            if (!id) {
                throw 'no playable provided ';
            }
            if (typeof(id) === 'object') { // it was instanceof Playable but test use generic objects and dont use playable constructor
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
        };

        Playlist.prototype.listPlayables = function(page, size) {
            var i,
                whole,
                remainder,
                plPage = [],
                sortedPlayables = this.playables.sort(dynamicSortMultiple('title', 'id')),
                len = sortedPlayables.length;

            if (page * size > len || page < 0 || size <= 0) {
                throw 'page size error';
            }

            if (len <= size) {
                return sortedPlayables;
            }

            remainder = len % size;

            if (remainder === 0) {
                for (i = page * size; i < page * size + size; i += 1) {
                    plPage.push(sortedPlayables[i]);
                }
            } else {
                whole = len - remainder;

                if (page > (whole / size) - 1) {
                    for (i = whole; i < whole + remainder; i += 1) {
                        plPage.push(sortedPlayables[i]);
                    }
                } else {
                    for (i = page * size; i < page * size + size; i += 1) {
                        plPage.push(sortedPlayables[i]);
                    }
                }
            }

            return plPage;
        };

        //Playable
        function Playable(title, author) {
            this.title = title;
            this.author = author;
            this.id = currentPlayableId += 1;
        }

        Playable.prototype.play = function() {
            return this.id + '. ' + this.title + ' - ' + this.author;
        };

        //Audio
        function Audio(title, author, length) {
            if (length <= 0) {
                throw 'error length <= 0';
            }

            Playable.call(this, title, author);
            this.length = length;
        }

        Audio.prototype = Object.create(Playable.prototype);
        Audio.prototype.constructor = Audio;

        Audio.prototype.play = function() {
            return Playable.prototype.play.call(this) + ' - ' + this.length;
        };

        //Video
        function Video(title, author, imdbRating) {
            if (imdbRating < 1 || imdbRating > 5) {
                throw 'error in imdbRating';
            }

            Playable.call(this, title, author);
            this.imdbRating = imdbRating;
        }

        Video.prototype = Object.create(Playable.prototype);
        Video.prototype.constructor = Video;

        Video.prototype.play = function() {
            return Playable.prototype.play.call(this) + ' - ' + this.imdbRating;
        };

        return {
            getPlayer: function(name) {
                return new Player(name);
            },
            getPlaylist: function(name) {
                return new Playlist(name);
            },
            getAudio: function(title, author, length) {
                return new Audio(title, author, length);
            },
            getVideo: function(title, author, imdbRating) {
                return new Video(title, author, imdbRating);
            }
        };

    })();

    return module;
}

module.exports = solve;

var module = solve();

//var result = module;
// var i, j, name, player, playlist, results;
// name = 'Rock and Roll';
// player = result.getPlayer(name);
// playlist = result.getPlaylist(name);
// player.addPlaylist(playlist).removePlaylist(playlist.id);
// //expect(player.getPlaylistById(playlist.id)).to.be["null"];
// console.log(player.getPlaylistById(playlist.id))


// var gotten,
//     name = 'Rock and roll',
//     plName = 'Banana Rock',
//     plAuthor = 'Wombles',
//     playlist = result.getPlaylist(name),
//     playable = {
//         id: 1,
//         name: plName,
//         author: plAuthor
//     };

// playlist.addPlayable(playable);
// playlist.removePlayable(playable);
// gotten = playlist.getPlayableById(1);
// console.log(gotten === null);

// playlist.addPlayable(playable);
// playlist.removePlayable(1);
// gotten = playlist.getPlayableById(1);
// console.log(gotten === null);

//playlist.removePlayable(10);



var player = module.getPlayer('asd');

var song = module.getAudio('du hast', 'rammstein', '4:32');
var song2 = module.getAudio('du hast', 'rammstein', '4:32');
//console.log(song2.play());
//console.log(song instanceof Audio);
// var movie = module.getVideo('the matrix', 'brothers waichowsky', 4);
// console.log(movie.play());

// var plst1 = module.getPlaylist('plst1');

// player.addPlaylist(plst1);

//var foundplst = player.getPlaylistById(1);

//console.log(foundplst);

// player.removePlaylist(plst1);

// console.log(player.listPlaylists(0, 10));

// for (var i = 0; i < 35; i++) {
//     player.addPlaylist(module.getPlaylist('plst' + i));
// }

//console.log(player.playlists);
//console.log(player.listPlaylists(1, 35));
