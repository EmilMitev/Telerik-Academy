/* 
 Create a function that:
 *   **Takes** a collection of books
 *   Each book has propeties `title` and `author`
 **  `author` is an object that has properties `firstName` and `lastName`
 *   **finds** the most popular author (the author with biggest number of books)
 *   **prints** the author to the console
 *	if there is more than one author print them all sorted in ascending order by fullname
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   **Use underscore.js for all operations**
 */

function solve() {
    return function (books) {
        var counts = {};

        _.each(books, function (book) {
            var authorFullName = book.author.firstName + ' ' + book.author.lastName;

            if (!counts[authorFullName]) {
                counts[authorFullName] = 0;
            }

            counts[authorFullName]++;
        });

        var mostPopularAuthor = [];
        var countBook = _.max(counts);

        _.each(counts, function (value, key) {
            if (value === countBook) {
                mostPopularAuthor.push(key);
            }
        });

        _.chain(mostPopularAuthor)
            .sortBy()
            .each(function (name) {
                console.log(name);
            });

    };
}

module.exports = solve;
