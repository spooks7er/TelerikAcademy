function solve() {
    var library = (function () {
        var books = [],
            categories = [];

        function validateStringLength(string, stringName) {
            if (string.length < 2 || string.length > 100) {
                throw new Error(stringName + ' must be between 2 and 100 characters');
            }
        }

        function validateAuthor(author) {
            if (author === '') {
                throw new Error('author must be an non-empty string');
            }
        }

        function validateISBN(ISBN) {
            if (!/^(?:\d{10}|\d{13})$/.test(ISBN)) {
                throw new Error('ISBN must be 10 or 13 digits');
            }
        }

        function isBookInList(newBook) {
            return books.some(function(book){
                return book.title == newBook.title || book.isbn == newBook.isbn;
            });
        }

        function addCategory(newCategory) {
            if (!categories.some(function (category){return category === newCategory;})) {
                categories.push(newCategory);
            }
        }

        function addBook(book) {
            validateStringLength(book.title, 'title');
            validateStringLength(book.category, 'category');
            validateAuthor(book.author);
            validateISBN(book.isbn);

            if (isBookInList(book)) {
                throw new Error('A book with the same title or ISBN is already added');
            }
            book.ID = books.length + 1;
            books.push(book);
            addCategory(book.category);
            return book;
        }

        function listBooks(by) {
            var sortedBooks = [];

            if (!by || !Object.keys(by).length) { //if 'by' is undefined or is an empty object
                sortedBooks = books;
            }
            else if (by.hasOwnProperty('category') || by.hasOwnProperty('author')) {
                sortedBooks = books.filter(function(book){
                    return book.category == by.category || book.author == by.author;
                });
            }

            return sortedBooks;
        }

        function listCategories() {
            return categories;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    } ());
    return library;
}

var library = solve();


var newBook = {
    title: 'A Dance with dragons',
    isbn: '1321321123',
    author: 'GRRMARTIN',
    category: 'Fantasy',
}

var newBook2 = {
    title: 'whaever',
    isbn: '1321321123444',
    author: 'asdasd',
    category: 'adventure',
}
var newBook3 = {
    title: 'whaever111',
    isbn: '1321321123441',
    author: 'asdasd',
    category: 'Crime',
}

var newBook4 = {
    title: 'whaever333',
    isbn: '1321321123451',
    author: 'asdasd',
    category: 'Crime',
}
library.books.add(newBook)
library.books.add(newBook2)
library.books.add(newBook3)
library.books.add(newBook4)
// console.log(library.books.add(newBook));
// console.log(library.books.add(newBook2));
// console.log(library.books.add(newBook3))
// console.log(library.categories.list())

console.log(library.categories.list())