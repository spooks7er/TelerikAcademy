/* Task Description */
/* 
 *	Create a module for working with books
 *	The module must provide the following functionalities:
 **	Add a new book to category
 **	Each book has unique title, author and isbn
 **	It must return the newly created book with assigned ID
 **	If the category is missing, it must be automatically created
 **	List all books
 *	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 *	Categories are sorted by ID
 *	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
 *	When adding a book/category, the ID is generated automatically
 *	Add validation everywhere, where possible
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	Author is any non-empty string
 *	Unique params are Book title and Book isbn
 *	Book isbn is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */

function solve() {
    var library = (function() {
        var books = [],
            categories = [];

        function listBooks(by) {
            if (by) {
                if (by.hasOwnProperty('category') || by.hasOwnProperty('author')) {
                    return books.filter(function(book) {
                        return book.category === by.category || book.author === by.author;
                    });
                }
            }

            return books;
        }

        function addBook(book) {

            if (!book.title) {
                throw 'Error: Missing title.';
            }

            if (book.category.length < 2 || book.category.length > 100 ||
                book.title.length < 2 || book.title.length > 100) {

                throw 'Error: Title and Category must between 2 and 100 characters.';
            }

            if (!(book.isbn.length === 10 || book.isbn.length === 13)) {
                throw 'Error: isbn must be 10 or 13 digits.';
            }

            if (!(book.author)) {
                throw 'Error: Author must not be empty.';
            }

            if (!ifBookExists(book)) {
                throw "Error: This book already exists.";
            }

            book.ID = books.length + 1;
            books.push(book);
            addCategory(book.category);
            return book;
        }

        function ifBookExists(book) {
            var i,
                len = books.length;
            for (i = 0; i < len; i += 1) {
                if (book.title === books[i].title || book.isbn === books[i].isbn) {
                    return false;
                }
            }

            return true;
        }

        function listCategories() {
            return categories.map(function(ctg) {
                ctg = ctg.name;
                return ctg;
            });
        }

        function addCategory(category) {
            var i,
                len = categories.length;
            for (i = 0; i < len; i += 1) {
                if (category === categories[i].name) {
                    return;
                }
            }
            category = {
                ID: len + 1,
                name: category,
            };
            categories.push(category);
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
    }());

    return library;
}

module.exports = solve;

// var library = solve();

// var newBook = {
//     title: 'A Dance with dragons',
//     isbn: '1321321123',
//     author: 'GRRMARTIN',
//     category: 'Fantasy',
// };
// var newBook2 = {
//     title: 'whaever',
//     isbn: '1321321123444',
//     author: 'asdasd',
//     category: 'adventure',
// };
// var newBook3 = {
//     title: 'whaever111',
//     isbn: '1321321123441',
//     author: 'asdasd',
//     category: 'Crime',
// };
// var newBook4 = {
//     title: 'whaever111333',
//     isbn: '1321321123555',
//     author: 'asdasd',
//     category: 'Crime',
// };


// // library.books.add(newBook)
// // library.books.add(newBook2)
// library.books.add(newBook3);
// library.books.add(newBook4);
// console.log(library.books.add(newBook));
// console.log(library.books.add(newBook2));
// console.log(library.books.add(newBook3));
// console.log(library.categories.list());

// console.log(library.categories.list({category : 'Crime' }));

// console.log(library.books.list({
//     asd: 'Crime'
// }));


// console.log(library.categories.list());
