function solve() {

    var player = {
            init: function(name) {
                return this;
            },
            addPlaylist: function(playlist) {

            },
            getPlaylistById: function(id) {

            },
            removePlaylist: function(id) {

            },
            listPlaylists: function(page, size) {

            }
        },

        playlist = {
            init: function(name) {
                return this;
            },
            addPlayable: function(playlist) {

            },
            getPlayableById: function(id) {

            },
            removePlayable: function(id) {

            },
            listPlayables: function(page, size) {

            }
        },

        playable = (function() {
            var lastId = 0;
            var playable = {
                init: function(title, author) {
                    this.id = lastId += 1;
                    this.title = title;
                    this.author = author;
                    return this;
                },
                play: function() {
                    return this.id + '. ' + this.title + ' - ' + this.author;
                },
            };
            return playable;
        })();

    audio = {
            init: function() {
                return this;
            },
            play: function() {
                // body...
            }
        },

        video = {
            init: function() {
                return this;
            },
            play: function() {
                // body...
            }
        },

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
