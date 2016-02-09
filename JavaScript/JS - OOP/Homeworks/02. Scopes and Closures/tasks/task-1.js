/* Task Description */
/* 
 *	Create a module for working with books
 *	The module must provide the following functionalities:
 *	Add a new book to category
 *	Each book has unique title, author and ISBN
 *	It must return the newly created book with assigned ID
 *	If the category is missing, it must be automatically created
 *	List all books
 *	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 *	Categories are sorted by ID
 *	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
 *	When adding a book/category, the ID is generated automatically
 *	Add validation everywhere, where possible
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	Author is any non-empty string
 *	Unique params are Book title and Book ISBN
 *	Book ISBN is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */
function solve() {
    var library = (function () {
        var books = [];
        var categories = [];

        var filtred = [];

        function listBooks() {
            var args = arguments[0];
            if (books.length === 0) {
                return [];
            }

            if (books.length === 1) {
                if (!args || books[0].category === args.category) {
                    return books;
                } else {
                    return [];
                }
            }

            if (args) {
                filtred = books.filter(function (b) {
                    return b.category === args.category;
                });
            } else {
                filtred = books;
            }
            return filtred.sort(function (a, b) {
                return a.ID - b.ID;
            });
        }

        function checkIfUnique(book) {
            for (var i = 0; i < books.length; i += 1) {
                if (books[i].title === book.title) {
                    throw new Error();
                }

                if (books[i].isbn === book.isbn.trim()) {
                    throw new Error();
                }
            }
        }

        function checkForNeededLength(book) {
            if (book.title.trim().length < 2 || book.title.trim().length > 100) {
                throw new Error();
            }
            if (book.category.trim().length < 2 || book.category.trim().length > 100) {
                throw new Error();
            }
            if (book.author.trim().length < 1) {
                throw new Error();
            }
            if (book.isbn.length !== 10 && book.isbn.length !== 13) {
                throw new Error();
            }
            if (isNaN(book.isbn)) {
                throw new Error();
            }
        }

        function addCategories(category) {
            category.ID = categories.length + 1;
            category.name = category;
            categories.push(category);
        }

        function addBook(book) {

            checkIfUnique(book);

            checkForNeededLength(book);

            if (categories.indexOf(book.category) < 0) {
                addCategories(book.category);
            }

            book.ID = books.length + 1;
            books.push(book);
            return book;
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
    }());
    return library;
}
module.exports = solve;
